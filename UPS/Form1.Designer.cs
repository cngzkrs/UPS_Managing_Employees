namespace UPS
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnGetAllEmployees = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            this.btnGetEmpsByName = new System.Windows.Forms.Button();
            this.txtEmpName = new System.Windows.Forms.TextBox();
            this.btnPost = new System.Windows.Forms.Button();
            this.btnGetEmployeeById = new System.Windows.Forms.Button();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.txtPut = new System.Windows.Forms.TextBox();
            this.btnPutById = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtDeleteById = new System.Windows.Forms.TextBox();
            this.lblPageNum = new System.Windows.Forms.Label();
            this.lblpgnum = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGetAllEmployees
            // 
            this.btnGetAllEmployees.BackColor = System.Drawing.SystemColors.Info;
            this.btnGetAllEmployees.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGetAllEmployees.Location = new System.Drawing.Point(25, 10);
            this.btnGetAllEmployees.Name = "btnGetAllEmployees";
            this.btnGetAllEmployees.Size = new System.Drawing.Size(163, 61);
            this.btnGetAllEmployees.TabIndex = 0;
            this.btnGetAllEmployees.Text = "Get All Employees";
            this.btnGetAllEmployees.UseVisualStyleBackColor = false;
            this.btnGetAllEmployees.Click += new System.EventHandler(this.btnGetAllEmployees_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Enabled = false;
            this.btnLeft.Image = ((System.Drawing.Image)(resources.GetObject("btnLeft.Image")));
            this.btnLeft.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLeft.Location = new System.Drawing.Point(904, 205);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(54, 26);
            this.btnLeft.TabIndex = 2;
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnRight
            // 
            this.btnRight.Image = ((System.Drawing.Image)(resources.GetObject("btnRight.Image")));
            this.btnRight.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRight.Location = new System.Drawing.Point(964, 205);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(51, 26);
            this.btnRight.TabIndex = 2;
            this.btnRight.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // dgvEmployees
            // 
            this.dgvEmployees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmployees.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgvEmployees.ColumnHeadersHeight = 25;
            this.dgvEmployees.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dgvEmployees.Location = new System.Drawing.Point(12, 237);
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.RowHeadersWidth = 45;
            this.dgvEmployees.Size = new System.Drawing.Size(1002, 371);
            this.dgvEmployees.TabIndex = 1;
            this.dgvEmployees.Text = "dataGridView1";
            // 
            // btnGetEmpsByName
            // 
            this.btnGetEmpsByName.Location = new System.Drawing.Point(176, 100);
            this.btnGetEmpsByName.Name = "btnGetEmpsByName";
            this.btnGetEmpsByName.Size = new System.Drawing.Size(169, 33);
            this.btnGetEmpsByName.TabIndex = 0;
            this.btnGetEmpsByName.Text = "Get Employees By Name";
            this.btnGetEmpsByName.UseVisualStyleBackColor = true;
            this.btnGetEmpsByName.Click += new System.EventHandler(this.btnGetEmpsByName_Click);
            // 
            // txtEmpName
            // 
            this.txtEmpName.Location = new System.Drawing.Point(28, 106);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.Size = new System.Drawing.Size(142, 25);
            this.txtEmpName.TabIndex = 3;
            // 
            // btnPost
            // 
            this.btnPost.BackColor = System.Drawing.SystemColors.Info;
            this.btnPost.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPost.Location = new System.Drawing.Point(520, 10);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(163, 61);
            this.btnPost.TabIndex = 4;
            this.btnPost.Text = "Create a New Employee ";
            this.btnPost.UseVisualStyleBackColor = false;
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
            // 
            // btnGetEmployeeById
            // 
            this.btnGetEmployeeById.Location = new System.Drawing.Point(176, 149);
            this.btnGetEmployeeById.Name = "btnGetEmployeeById";
            this.btnGetEmployeeById.Size = new System.Drawing.Size(169, 33);
            this.btnGetEmployeeById.TabIndex = 5;
            this.btnGetEmployeeById.Text = "Get Employeed By Id";
            this.btnGetEmployeeById.UseVisualStyleBackColor = true;
            this.btnGetEmployeeById.Click += new System.EventHandler(this.btnGetEmployeeById_Click);
            // 
            // txtUserId
            // 
            this.txtUserId.Location = new System.Drawing.Point(28, 154);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(142, 25);
            this.txtUserId.TabIndex = 6;
            // 
            // txtPut
            // 
            this.txtPut.Location = new System.Drawing.Point(523, 105);
            this.txtPut.Name = "txtPut";
            this.txtPut.Size = new System.Drawing.Size(142, 25);
            this.txtPut.TabIndex = 6;
            // 
            // btnPutById
            // 
            this.btnPutById.Location = new System.Drawing.Point(671, 100);
            this.btnPutById.Name = "btnPutById";
            this.btnPutById.Size = new System.Drawing.Size(169, 33);
            this.btnPutById.TabIndex = 7;
            this.btnPutById.Text = "Put Employeed By Id";
            this.btnPutById.UseVisualStyleBackColor = true;
            this.btnPutById.Click += new System.EventHandler(this.btnPutById_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(671, 149);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(169, 33);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete Employee By Id";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtDeleteById
            // 
            this.txtDeleteById.Location = new System.Drawing.Point(523, 154);
            this.txtDeleteById.Name = "txtDeleteById";
            this.txtDeleteById.Size = new System.Drawing.Size(142, 25);
            this.txtDeleteById.TabIndex = 9;
            // 
            // lblPageNum
            // 
            this.lblPageNum.AutoSize = true;
            this.lblPageNum.Enabled = false;
            this.lblPageNum.Location = new System.Drawing.Point(859, 614);
            this.lblPageNum.Name = "lblPageNum";
            this.lblPageNum.Size = new System.Drawing.Size(92, 17);
            this.lblPageNum.TabIndex = 10;
            this.lblPageNum.Text = "Page Number:";
            // 
            // lblpgnum
            // 
            this.lblpgnum.AutoSize = true;
            this.lblpgnum.Location = new System.Drawing.Point(957, 615);
            this.lblpgnum.Name = "lblpgnum";
            this.lblpgnum.Size = new System.Drawing.Size(0, 17);
            this.lblpgnum.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 678);
            this.Controls.Add(this.lblpgnum);
            this.Controls.Add(this.lblPageNum);
            this.Controls.Add(this.txtDeleteById);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnPutById);
            this.Controls.Add(this.txtPut);
            this.Controls.Add(this.txtUserId);
            this.Controls.Add(this.btnGetEmployeeById);
            this.Controls.Add(this.btnPost);
            this.Controls.Add(this.txtEmpName);
            this.Controls.Add(this.btnGetEmpsByName);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.dgvEmployees);
            this.Controls.Add(this.btnGetAllEmployees);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "UPS - Yılmaz Cengiz Akarsu";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetAllEmployees;
        private System.Windows.Forms.DataGridView dgvEmployees;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnGetEmpsByName;
        private System.Windows.Forms.TextBox txtEmpName;
        private System.Windows.Forms.Button btnPost;
        private System.Windows.Forms.Button btnGetEmployeeById;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.TextBox txtPut;
        private System.Windows.Forms.Button btnPutById;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtDeleteById;
        private System.Windows.Forms.Label lblPageNum;
        private System.Windows.Forms.Label lblpgnum;
    }
}

