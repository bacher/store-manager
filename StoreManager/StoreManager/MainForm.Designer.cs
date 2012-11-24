namespace StoreManager
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtDocumentCaption = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGivenQty = new System.Windows.Forms.TextBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.statusStripMain = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.statusStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDocumentCaption
            // 
            this.txtDocumentCaption.Location = new System.Drawing.Point(77, 12);
            this.txtDocumentCaption.Name = "txtDocumentCaption";
            this.txtDocumentCaption.ReadOnly = true;
            this.txtDocumentCaption.Size = new System.Drawing.Size(176, 20);
            this.txtDocumentCaption.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Document:";
            // 
            // txtItemName
            // 
            this.txtItemName.Location = new System.Drawing.Point(77, 38);
            this.txtItemName.Multiline = true;
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.ReadOnly = true;
            this.txtItemName.Size = new System.Drawing.Size(250, 79);
            this.txtItemName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Item:";
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(77, 133);
            this.txtQty.Mask = "00000";
            this.txtQty.Name = "txtQty";
            this.txtQty.PromptChar = ' ';
            this.txtQty.Size = new System.Drawing.Size(55, 20);
            this.txtQty.TabIndex = 4;
            this.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtQty.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Count:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(138, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "of";
            // 
            // txtGivenQty
            // 
            this.txtGivenQty.Location = new System.Drawing.Point(160, 133);
            this.txtGivenQty.Name = "txtGivenQty";
            this.txtGivenQty.ReadOnly = true;
            this.txtGivenQty.Size = new System.Drawing.Size(55, 20);
            this.txtGivenQty.TabIndex = 7;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(252, 162);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 8;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // statusStripMain
            // 
            this.statusStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStripMain.Location = new System.Drawing.Point(0, 194);
            this.statusStripMain.Name = "statusStripMain";
            this.statusStripMain.Size = new System.Drawing.Size(339, 22);
            this.statusStripMain.SizingGrip = false;
            this.statusStripMain.TabIndex = 9;
            this.statusStripMain.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(160, 162);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 10;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Visible = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 216);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.statusStripMain);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.txtGivenQty);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtItemName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDocumentCaption);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "Document Item";
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.statusStripMain.ResumeLayout(false);
            this.statusStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDocumentCaption;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtQty;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGivenQty;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.StatusStrip statusStripMain;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.Button btnRefresh;
    }
}

