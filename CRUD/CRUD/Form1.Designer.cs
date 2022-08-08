namespace CRUD
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tbNOBR = new System.Windows.Forms.TextBox();
            this.lbSLNOBR = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lbKEY_MAN = new System.Windows.Forms.Label();
            this.tbKEY_MAN = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvTable = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).BeginInit();
            this.SuspendLayout();
            // 
            // tbNOBR
            // 
            this.tbNOBR.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbNOBR.Location = new System.Drawing.Point(68, 101);
            this.tbNOBR.Name = "tbNOBR";
            this.tbNOBR.Size = new System.Drawing.Size(258, 45);
            this.tbNOBR.TabIndex = 0;
            // 
            // lbSLNOBR
            // 
            this.lbSLNOBR.AutoSize = true;
            this.lbSLNOBR.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbSLNOBR.Location = new System.Drawing.Point(63, 58);
            this.lbSLNOBR.Name = "lbSLNOBR";
            this.lbSLNOBR.Size = new System.Drawing.Size(127, 35);
            this.lbSLNOBR.TabIndex = 1;
            this.lbSLNOBR.Text = "員工編號";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSearch.Location = new System.Drawing.Point(332, 96);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(162, 51);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "查詢";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lbKEY_MAN
            // 
            this.lbKEY_MAN.AutoSize = true;
            this.lbKEY_MAN.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbKEY_MAN.Location = new System.Drawing.Point(63, 154);
            this.lbKEY_MAN.Name = "lbKEY_MAN";
            this.lbKEY_MAN.Size = new System.Drawing.Size(127, 35);
            this.lbKEY_MAN.TabIndex = 4;
            this.lbKEY_MAN.Text = "建檔人員";
            // 
            // tbKEY_MAN
            // 
            this.tbKEY_MAN.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbKEY_MAN.Location = new System.Drawing.Point(68, 197);
            this.tbKEY_MAN.Name = "tbKEY_MAN";
            this.tbKEY_MAN.Size = new System.Drawing.Size(258, 45);
            this.tbKEY_MAN.TabIndex = 0;
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCreate.Location = new System.Drawing.Point(500, 96);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(162, 51);
            this.btnCreate.TabIndex = 2;
            this.btnCreate.Text = "新增";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnModify
            // 
            this.btnModify.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnModify.Location = new System.Drawing.Point(332, 192);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(162, 51);
            this.btnModify.TabIndex = 2;
            this.btnModify.Text = "修改";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDelete.Location = new System.Drawing.Point(668, 96);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(162, 51);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "刪除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dgvTable
            // 
            this.dgvTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTable.Location = new System.Drawing.Point(68, 306);
            this.dgvTable.Name = "dgvTable";
            this.dgvTable.RowHeadersWidth = 62;
            this.dgvTable.RowTemplate.Height = 31;
            this.dgvTable.Size = new System.Drawing.Size(1194, 417);
            this.dgvTable.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 791);
            this.Controls.Add(this.dgvTable);
            this.Controls.Add(this.lbKEY_MAN);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lbSLNOBR);
            this.Controls.Add(this.tbKEY_MAN);
            this.Controls.Add(this.tbNOBR);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNOBR;
        private System.Windows.Forms.Label lbSLNOBR;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lbKEY_MAN;
        private System.Windows.Forms.TextBox tbKEY_MAN;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvTable;
    }
}

