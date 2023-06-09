namespace zadacha6
{
    partial class Form1
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
            this.lblID = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblBreed = new System.Windows.Forms.Label();
            this.txtbID = new System.Windows.Forms.TextBox();
            this.txtbAge = new System.Windows.Forms.TextBox();
            this.txtbDesc = new System.Windows.Forms.TextBox();
            this.txtbName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cmbbBreed = new System.Windows.Forms.ComboBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnSelectAll = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(29, 24);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(20, 16);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID";
            this.lblID.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(29, 80);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 16);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            this.lblName.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(29, 142);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(39, 16);
            this.lblDesc.TabIndex = 2;
            this.lblDesc.Text = "Desc";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(29, 202);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(32, 16);
            this.lblAge.TabIndex = 3;
            this.lblAge.Text = "Age";
            // 
            // lblBreed
            // 
            this.lblBreed.AutoSize = true;
            this.lblBreed.Location = new System.Drawing.Point(29, 273);
            this.lblBreed.Name = "lblBreed";
            this.lblBreed.Size = new System.Drawing.Size(44, 16);
            this.lblBreed.TabIndex = 4;
            this.lblBreed.Text = "Breed";
            // 
            // txtbID
            // 
            this.txtbID.Location = new System.Drawing.Point(128, 24);
            this.txtbID.Name = "txtbID";
            this.txtbID.Size = new System.Drawing.Size(100, 22);
            this.txtbID.TabIndex = 5;
            // 
            // txtbAge
            // 
            this.txtbAge.Location = new System.Drawing.Point(128, 202);
            this.txtbAge.Name = "txtbAge";
            this.txtbAge.Size = new System.Drawing.Size(100, 22);
            this.txtbAge.TabIndex = 7;
            // 
            // txtbDesc
            // 
            this.txtbDesc.Location = new System.Drawing.Point(128, 136);
            this.txtbDesc.Name = "txtbDesc";
            this.txtbDesc.Size = new System.Drawing.Size(100, 22);
            this.txtbDesc.TabIndex = 8;
            // 
            // txtbName
            // 
            this.txtbName.Location = new System.Drawing.Point(128, 80);
            this.txtbName.Name = "txtbName";
            this.txtbName.Size = new System.Drawing.Size(100, 22);
            this.txtbName.TabIndex = 9;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(49, 348);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(191, 348);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(363, 344);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 27);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // cmbbBreed
            // 
            this.cmbbBreed.FormattingEnabled = true;
            this.cmbbBreed.Location = new System.Drawing.Point(128, 273);
            this.cmbbBreed.Name = "cmbbBreed";
            this.cmbbBreed.Size = new System.Drawing.Size(121, 24);
            this.cmbbBreed.TabIndex = 13;
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(128, 415);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 14;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.Location = new System.Drawing.Point(295, 415);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(75, 23);
            this.btnSelectAll.TabIndex = 15;
            this.btnSelectAll.Text = "Select All";
            this.btnSelectAll.UseVisualStyleBackColor = true;
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(517, 63);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(256, 308);
            this.listBox1.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnSelectAll);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.cmbbBreed);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtbName);
            this.Controls.Add(this.txtbDesc);
            this.Controls.Add(this.txtbAge);
            this.Controls.Add(this.txtbID);
            this.Controls.Add(this.lblBreed);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblID);
            this.Name = "Form1";
            this.Text = "Animals";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblBreed;
        private System.Windows.Forms.TextBox txtbID;
        private System.Windows.Forms.TextBox txtbAge;
        private System.Windows.Forms.TextBox txtbDesc;
        private System.Windows.Forms.TextBox txtbName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox cmbbBreed;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnSelectAll;
        private System.Windows.Forms.ListBox listBox1;
    }
}