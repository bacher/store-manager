using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlServerCe;

namespace StoreManager
{
    public struct Item
    {
        public int documentID;
        public string documentName;
        public int lineID;
        public string name;
        public int qty;
        public int givenQry;
    }



    public partial class MainForm : Form
    {
        private string connectionString;
        private bool firstActivation = true;

        private int? currentDocumentID = null;
        private Item currentItem;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            connectionString = Properties.Settings.Default.ConnectionString;
        }

        private void ShowNextItem()
        {
            bool res = true;
            try
            {
                res = GetNextItemInDocument(currentDocumentID);
            }
            catch
            {
                MessageBox.Show("Database errors.\n\nApplication will be closed.", "Error");
                Application.Exit();
            }

            if (res == false)
            {
                if (currentDocumentID == null)
                {
                    currentDocumentID = null;

                    EmptyFormFields();

                    MessageBox.Show("All items are processed.", "Store Manager");
                    btnRefresh.Visible = true;
                }
                else
                {
                    currentDocumentID = null;
                    ShowNextItem();
                }
            }
            else
            {
                txtQty.Focus();
                btnRefresh.Visible = false;
            }
        }

        private void EmptyFormFields()
        {
            txtDocumentCaption.Text = txtGivenQty.Text = txtItemName.Text = txtQty.Text = string.Empty;
        }

        private bool GetNextItemInDocument(int? DocumentID = null)
        {
            bool findFirstDocument = DocumentID == null ? true : false;

            bool result = false;

            using (var sqlConnection = new SqlCeConnection(connectionString))
            {
                var command = new SqlCeCommand(
                    "SELECT Doc.DocumentID, Doc.Name, Item.LineID, Item.ItemName, Item.GivenQty " +
                    "FROM Document as Doc " +
                    "INNER JOIN DocumentLine as Item " +
                    "ON Doc.DocumentID = Item.DocumentID " +
                    "WHERE Item.Qty is NULL " + (findFirstDocument? "" : "and Doc.DocumentID = @documentID ") +
                    "ORDER BY Doc.DocumentID, Item.LineID",
                    sqlConnection
                );

                command.Parameters.Add("documentID", DocumentID);
                sqlConnection.Open();
                var reader = command.ExecuteReader();

                try
                {
                    if (reader.Read())
                    {
                        //MessageBox.Show(string.Format("{0} {1} {2} {3} {4}", reader[0], reader[1], reader[2], reader[3], reader[4]));
                        Item item;

                        item.documentID = reader.GetInt32(0);
                        item.documentName = reader.GetString(1);
                        item.lineID = reader.GetInt32(2);
                        item.name = reader.GetString(3);
                        item.givenQry = reader.GetInt32(4);
                        item.qty = 0;

                        currentDocumentID = item.documentID;

                        SetFormFields(item);

                        result = true;                        
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database connection error.", "Error!");
                    throw ex;
                }
                finally
                {
                    reader.Close();
                }
            }
            return result;
        }

        private void SetFormFields(Item item)
        {
            currentItem = item;

            txtDocumentCaption.Text = currentItem.documentName;
            txtItemName.Text = currentItem.name;
            txtQty.Text = "0";
            txtGivenQty.Text = currentItem.givenQry.ToString();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            // Data verification

            if (currentDocumentID != null)
            {

                int qty;
                if (int.TryParse(txtQty.Text, out qty))
                {
                    if (qty <= currentItem.givenQry)
                    {
                        currentItem.qty = qty;
                        bool res = SaveQtyToDatabase(currentItem);

                        if (res == false)
                        {
                            MessageBox.Show("Could not apply changes.", "Error.");
                        }
                        else
                        {
                            ShowNextItem();
                        }

                    }
                    else
                    {
                        MessageBox.Show(string.Format("Can not take more than a given.", txtQty.Text), "Verification problem.");
                        txtQty.Text = currentItem.givenQry.ToString();
                    }
                }
                else
                {
                    MessageBox.Show(string.Format("Value of \"{0}\" can not be parsed to Int.", txtQty.Text), "Verification problem.");
                    txtQty.Text = string.Empty;
                }
            }
        }

        private bool SaveQtyToDatabase(Item item)
        {
            bool result = false;

            using (var sqlConnection = new SqlCeConnection(connectionString))
            {
                var command = new SqlCeCommand(
                    "UPDATE DocumentLine " +
                    "SET Qty = @NewQty " +
                    "WHERE LineID = @LineID",
                    sqlConnection
                );

                command.Parameters.Add("NewQty", item.qty);
                command.Parameters.Add("LineID", item.lineID);

                sqlConnection.Open();

                try
                {
                    int rowAffected = command.ExecuteNonQuery();
                    result = (rowAffected > 0);
                }
                catch
                {
                    result = false;
                }                
            }

            return result;
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            if (firstActivation)
            {
                firstActivation = false;
                ShowNextItem();               
            }

            txtQty.Focus();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ShowNextItem();
        }
    }
}
