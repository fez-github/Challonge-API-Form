
namespace APIFormTake2
{
    partial class GenericForm
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
            this.txt_Resource = new System.Windows.Forms.TextBox();
            this.lbl_Resource = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.cmb_Method = new System.Windows.Forms.ComboBox();
            this.lbl_Method = new System.Windows.Forms.Label();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.txt_APIKey = new System.Windows.Forms.TextBox();
            this.lbl_APIKey = new System.Windows.Forms.Label();
            this.dgv_Parameters = new System.Windows.Forms.DataGridView();
            this.ParameterValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ParameterName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_CallAPI = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Body = new System.Windows.Forms.TextBox();
            this.lbl_Body = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Parameters)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Resource
            // 
            this.txt_Resource.Location = new System.Drawing.Point(145, 34);
            this.txt_Resource.Name = "txt_Resource";
            this.txt_Resource.Size = new System.Drawing.Size(180, 23);
            this.txt_Resource.TabIndex = 0;
            // 
            // lbl_Resource
            // 
            this.lbl_Resource.AutoSize = true;
            this.lbl_Resource.Location = new System.Drawing.Point(207, 16);
            this.lbl_Resource.Name = "lbl_Resource";
            this.lbl_Resource.Size = new System.Drawing.Size(55, 15);
            this.lbl_Resource.TabIndex = 1;
            this.lbl_Resource.Text = "Resource";
            this.lbl_Resource.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(206, 110);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(182, 23);
            this.txt_Name.TabIndex = 2;
            // 
            // cmb_Method
            // 
            this.cmb_Method.FormattingEnabled = true;
            this.cmb_Method.Items.AddRange(new object[] {
            "GET",
            "POST",
            "PUT",
            "DELETE"});
            this.cmb_Method.Location = new System.Drawing.Point(478, 34);
            this.cmb_Method.Name = "cmb_Method";
            this.cmb_Method.Size = new System.Drawing.Size(141, 23);
            this.cmb_Method.TabIndex = 3;
            // 
            // lbl_Method
            // 
            this.lbl_Method.AutoSize = true;
            this.lbl_Method.Location = new System.Drawing.Point(520, 16);
            this.lbl_Method.Name = "lbl_Method";
            this.lbl_Method.Size = new System.Drawing.Size(49, 15);
            this.lbl_Method.TabIndex = 4;
            this.lbl_Method.Text = "Method";
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.Location = new System.Drawing.Point(265, 92);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(60, 15);
            this.lbl_Username.TabIndex = 5;
            this.lbl_Username.Text = "Username";
            // 
            // txt_APIKey
            // 
            this.txt_APIKey.Location = new System.Drawing.Point(474, 110);
            this.txt_APIKey.Name = "txt_APIKey";
            this.txt_APIKey.Size = new System.Drawing.Size(146, 23);
            this.txt_APIKey.TabIndex = 6;
            // 
            // lbl_APIKey
            // 
            this.lbl_APIKey.AutoSize = true;
            this.lbl_APIKey.Location = new System.Drawing.Point(522, 92);
            this.lbl_APIKey.Name = "lbl_APIKey";
            this.lbl_APIKey.Size = new System.Drawing.Size(47, 15);
            this.lbl_APIKey.TabIndex = 7;
            this.lbl_APIKey.Text = "API Key";
            // 
            // dgv_Parameters
            // 
            this.dgv_Parameters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Parameters.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ParameterValue,
            this.ParameterName});
            this.dgv_Parameters.Location = new System.Drawing.Point(49, 184);
            this.dgv_Parameters.Name = "dgv_Parameters";
            this.dgv_Parameters.RowTemplate.Height = 25;
            this.dgv_Parameters.Size = new System.Drawing.Size(271, 258);
            this.dgv_Parameters.TabIndex = 8;
            this.dgv_Parameters.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ParameterValue
            // 
            this.ParameterValue.HeaderText = "Parameter Value";
            this.ParameterValue.Name = "ParameterValue";
            // 
            // ParameterName
            // 
            this.ParameterName.HeaderText = "Parameter Name";
            this.ParameterName.Name = "ParameterName";
            // 
            // btn_CallAPI
            // 
            this.btn_CallAPI.Location = new System.Drawing.Point(663, 344);
            this.btn_CallAPI.Name = "btn_CallAPI";
            this.btn_CallAPI.Size = new System.Drawing.Size(149, 66);
            this.btn_CallAPI.TabIndex = 9;
            this.btn_CallAPI.Text = "Call API";
            this.btn_CallAPI.UseVisualStyleBackColor = true;
            this.btn_CallAPI.Click += new System.EventHandler(this.btn_CallAPI_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "api.challonge.com/v1/";
            // 
            // txt_Body
            // 
            this.txt_Body.AcceptsTab = true;
            this.txt_Body.Location = new System.Drawing.Point(384, 205);
            this.txt_Body.Multiline = true;
            this.txt_Body.Name = "txt_Body";
            this.txt_Body.Size = new System.Drawing.Size(262, 237);
            this.txt_Body.TabIndex = 11;
            // 
            // lbl_Body
            // 
            this.lbl_Body.AutoSize = true;
            this.lbl_Body.Location = new System.Drawing.Point(474, 184);
            this.lbl_Body.Name = "lbl_Body";
            this.lbl_Body.Size = new System.Drawing.Size(79, 15);
            this.lbl_Body.TabIndex = 12;
            this.lbl_Body.Text = "Request Body";
            // 
            // GenericForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 481);
            this.Controls.Add(this.lbl_Body);
            this.Controls.Add(this.txt_Body);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_CallAPI);
            this.Controls.Add(this.dgv_Parameters);
            this.Controls.Add(this.lbl_APIKey);
            this.Controls.Add(this.txt_APIKey);
            this.Controls.Add(this.lbl_Username);
            this.Controls.Add(this.lbl_Method);
            this.Controls.Add(this.cmb_Method);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.lbl_Resource);
            this.Controls.Add(this.txt_Resource);
            this.Name = "GenericForm";
            this.Text = "GenericForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Parameters)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Resource;
        private System.Windows.Forms.Label lbl_Resource;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.ComboBox cmb_Method;
        private System.Windows.Forms.Label lbl_Method;
        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.TextBox txt_APIKey;
        private System.Windows.Forms.Label lbl_APIKey;
        private System.Windows.Forms.DataGridView dgv_Parameters;
        private System.Windows.Forms.DataGridViewTextBoxColumn ParameterValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn ParameterName;
        private System.Windows.Forms.Button btn_CallAPI;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Body;
        private System.Windows.Forms.Label lbl_Body;
    }
}