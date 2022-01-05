
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
            this.lbl_BaseURL = new System.Windows.Forms.Label();
            this.txt_Body = new System.Windows.Forms.TextBox();
            this.lbl_Body = new System.Windows.Forms.Label();
            this.txt_BaseURL = new System.Windows.Forms.TextBox();
            this.lbl_Slash = new System.Windows.Forms.Label();
            this.lbl_Headers = new System.Windows.Forms.Label();
            this.lbl_GETSave = new System.Windows.Forms.Label();
            this.txt_GETSave = new System.Windows.Forms.TextBox();
            this.btn_FolderCall = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.cmb_CallFile = new System.Windows.Forms.ComboBox();
            this.lbl_CallFile = new System.Windows.Forms.Label();
            this.txt_Status = new System.Windows.Forms.TextBox();
            this.lbl_Status = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Parameters)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Resource
            // 
            this.txt_Resource.Location = new System.Drawing.Point(209, 34);
            this.txt_Resource.Name = "txt_Resource";
            this.txt_Resource.Size = new System.Drawing.Size(180, 23);
            this.txt_Resource.TabIndex = 1;
            // 
            // lbl_Resource
            // 
            this.lbl_Resource.AutoSize = true;
            this.lbl_Resource.Location = new System.Drawing.Point(271, 16);
            this.lbl_Resource.Name = "lbl_Resource";
            this.lbl_Resource.Size = new System.Drawing.Size(55, 15);
            this.lbl_Resource.TabIndex = 1;
            this.lbl_Resource.Text = "Resource";
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(110, 110);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(182, 23);
            this.txt_Name.TabIndex = 3;
            // 
            // cmb_Method
            // 
            this.cmb_Method.FormattingEnabled = true;
            this.cmb_Method.Items.AddRange(new object[] {
            "GET",
            "POST",
            "PUT",
            "DELETE"});
            this.cmb_Method.Location = new System.Drawing.Point(431, 34);
            this.cmb_Method.Name = "cmb_Method";
            this.cmb_Method.Size = new System.Drawing.Size(141, 23);
            this.cmb_Method.TabIndex = 2;
            // 
            // lbl_Method
            // 
            this.lbl_Method.AutoSize = true;
            this.lbl_Method.Location = new System.Drawing.Point(473, 16);
            this.lbl_Method.Name = "lbl_Method";
            this.lbl_Method.Size = new System.Drawing.Size(49, 15);
            this.lbl_Method.TabIndex = 4;
            this.lbl_Method.Text = "Method";
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.Location = new System.Drawing.Point(169, 92);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(60, 15);
            this.lbl_Username.TabIndex = 5;
            this.lbl_Username.Text = "Username";
            // 
            // txt_APIKey
            // 
            this.txt_APIKey.Location = new System.Drawing.Point(349, 110);
            this.txt_APIKey.Name = "txt_APIKey";
            this.txt_APIKey.Size = new System.Drawing.Size(146, 23);
            this.txt_APIKey.TabIndex = 4;
            // 
            // lbl_APIKey
            // 
            this.lbl_APIKey.AutoSize = true;
            this.lbl_APIKey.Location = new System.Drawing.Point(397, 92);
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
            this.dgv_Parameters.Location = new System.Drawing.Point(12, 231);
            this.dgv_Parameters.Name = "dgv_Parameters";
            this.dgv_Parameters.RowTemplate.Height = 25;
            this.dgv_Parameters.Size = new System.Drawing.Size(334, 237);
            this.dgv_Parameters.TabIndex = 8;
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
            this.btn_CallAPI.Location = new System.Drawing.Point(297, 488);
            this.btn_CallAPI.Name = "btn_CallAPI";
            this.btn_CallAPI.Size = new System.Drawing.Size(68, 42);
            this.btn_CallAPI.TabIndex = 9;
            this.btn_CallAPI.Text = "Call API";
            this.btn_CallAPI.UseVisualStyleBackColor = true;
            this.btn_CallAPI.Click += new System.EventHandler(this.btn_CallAPI_Click);
            // 
            // lbl_BaseURL
            // 
            this.lbl_BaseURL.AutoSize = true;
            this.lbl_BaseURL.Location = new System.Drawing.Point(75, 16);
            this.lbl_BaseURL.Name = "lbl_BaseURL";
            this.lbl_BaseURL.Size = new System.Drawing.Size(55, 15);
            this.lbl_BaseURL.TabIndex = 10;
            this.lbl_BaseURL.Text = "Base URL";
            // 
            // txt_Body
            // 
            this.txt_Body.AcceptsTab = true;
            this.txt_Body.Location = new System.Drawing.Point(539, 231);
            this.txt_Body.Multiline = true;
            this.txt_Body.Name = "txt_Body";
            this.txt_Body.Size = new System.Drawing.Size(262, 237);
            this.txt_Body.TabIndex = 11;
            // 
            // lbl_Body
            // 
            this.lbl_Body.AutoSize = true;
            this.lbl_Body.Location = new System.Drawing.Point(629, 210);
            this.lbl_Body.Name = "lbl_Body";
            this.lbl_Body.Size = new System.Drawing.Size(79, 15);
            this.lbl_Body.TabIndex = 12;
            this.lbl_Body.Text = "Request Body";
            // 
            // txt_BaseURL
            // 
            this.txt_BaseURL.Location = new System.Drawing.Point(23, 34);
            this.txt_BaseURL.Name = "txt_BaseURL";
            this.txt_BaseURL.Size = new System.Drawing.Size(168, 23);
            this.txt_BaseURL.TabIndex = 0;
            // 
            // lbl_Slash
            // 
            this.lbl_Slash.AutoSize = true;
            this.lbl_Slash.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Slash.Location = new System.Drawing.Point(193, 33);
            this.lbl_Slash.Name = "lbl_Slash";
            this.lbl_Slash.Size = new System.Drawing.Size(16, 21);
            this.lbl_Slash.TabIndex = 14;
            this.lbl_Slash.Text = "/";
            // 
            // lbl_Headers
            // 
            this.lbl_Headers.AutoSize = true;
            this.lbl_Headers.Location = new System.Drawing.Point(128, 210);
            this.lbl_Headers.Name = "lbl_Headers";
            this.lbl_Headers.Size = new System.Drawing.Size(50, 15);
            this.lbl_Headers.TabIndex = 15;
            this.lbl_Headers.Text = "Headers";
            // 
            // lbl_GETSave
            // 
            this.lbl_GETSave.AutoSize = true;
            this.lbl_GETSave.Location = new System.Drawing.Point(285, 159);
            this.lbl_GETSave.Name = "lbl_GETSave";
            this.lbl_GETSave.Size = new System.Drawing.Size(103, 15);
            this.lbl_GETSave.TabIndex = 16;
            this.lbl_GETSave.Text = "GET Save Location";
            // 
            // txt_GETSave
            // 
            this.txt_GETSave.Location = new System.Drawing.Point(257, 177);
            this.txt_GETSave.Name = "txt_GETSave";
            this.txt_GETSave.ReadOnly = true;
            this.txt_GETSave.Size = new System.Drawing.Size(149, 23);
            this.txt_GETSave.TabIndex = 5;
            // 
            // btn_FolderCall
            // 
            this.btn_FolderCall.Location = new System.Drawing.Point(412, 176);
            this.btn_FolderCall.Name = "btn_FolderCall";
            this.btn_FolderCall.Size = new System.Drawing.Size(48, 23);
            this.btn_FolderCall.TabIndex = 18;
            this.btn_FolderCall.Text = "Folder";
            this.btn_FolderCall.UseVisualStyleBackColor = true;
            this.btn_FolderCall.Click += new System.EventHandler(this.btn_FolderCall_Click);
            // 
            // cmb_CallFile
            // 
            this.cmb_CallFile.FormattingEnabled = true;
            this.cmb_CallFile.Location = new System.Drawing.Point(609, 58);
            this.cmb_CallFile.Name = "cmb_CallFile";
            this.cmb_CallFile.Size = new System.Drawing.Size(253, 23);
            this.cmb_CallFile.TabIndex = 19;
            this.cmb_CallFile.SelectedIndexChanged += new System.EventHandler(this.cmb_CallFile_SelectedIndexChanged);
            // 
            // lbl_CallFile
            // 
            this.lbl_CallFile.AutoSize = true;
            this.lbl_CallFile.Location = new System.Drawing.Point(689, 37);
            this.lbl_CallFile.Name = "lbl_CallFile";
            this.lbl_CallFile.Size = new System.Drawing.Size(61, 15);
            this.lbl_CallFile.TabIndex = 20;
            this.lbl_CallFile.Text = "Select Call";
            // 
            // txt_Status
            // 
            this.txt_Status.Location = new System.Drawing.Point(460, 499);
            this.txt_Status.Name = "txt_Status";
            this.txt_Status.Size = new System.Drawing.Size(120, 23);
            this.txt_Status.TabIndex = 21;
            // 
            // lbl_Status
            // 
            this.lbl_Status.AutoSize = true;
            this.lbl_Status.Location = new System.Drawing.Point(490, 481);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(62, 15);
            this.lbl_Status.TabIndex = 22;
            this.lbl_Status.Text = "Call Status";
            // 
            // GenericForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 583);
            this.Controls.Add(this.lbl_Status);
            this.Controls.Add(this.txt_Status);
            this.Controls.Add(this.lbl_CallFile);
            this.Controls.Add(this.cmb_CallFile);
            this.Controls.Add(this.btn_FolderCall);
            this.Controls.Add(this.txt_GETSave);
            this.Controls.Add(this.lbl_GETSave);
            this.Controls.Add(this.lbl_Headers);
            this.Controls.Add(this.lbl_Slash);
            this.Controls.Add(this.txt_BaseURL);
            this.Controls.Add(this.lbl_Body);
            this.Controls.Add(this.txt_Body);
            this.Controls.Add(this.lbl_BaseURL);
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
        private System.Windows.Forms.Label lbl_BaseURL;
        private System.Windows.Forms.TextBox txt_Body;
        private System.Windows.Forms.Label lbl_Body;
        private System.Windows.Forms.TextBox txt_BaseURL;
        private System.Windows.Forms.Label lbl_Slash;
        private System.Windows.Forms.Label lbl_Headers;
        private System.Windows.Forms.Label lbl_GETSave;
        private System.Windows.Forms.TextBox txt_GETSave;
        private System.Windows.Forms.Button btn_FolderCall;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ComboBox cmb_CallFile;
        private System.Windows.Forms.Label lbl_CallFile;
        private System.Windows.Forms.TextBox txt_Status;
        private System.Windows.Forms.Label lbl_Status;
    }
}