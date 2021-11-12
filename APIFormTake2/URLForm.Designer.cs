
namespace APIFormTake2
{
    partial class URLForm
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
            this.txt_URL = new System.Windows.Forms.TextBox();
            this.lbl_URL = new System.Windows.Forms.Label();
            this.lbl_APIKey = new System.Windows.Forms.Label();
            this.txt_APIKey = new System.Windows.Forms.TextBox();
            this.btn_APICall = new System.Windows.Forms.Button();
            this.txt_AbsoluteURI = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_URL
            // 
            this.txt_URL.Location = new System.Drawing.Point(34, 51);
            this.txt_URL.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_URL.Name = "txt_URL";
            this.txt_URL.Size = new System.Drawing.Size(280, 23);
            this.txt_URL.TabIndex = 0;
            // 
            // lbl_URL
            // 
            this.lbl_URL.AutoSize = true;
            this.lbl_URL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_URL.Location = new System.Drawing.Point(121, 27);
            this.lbl_URL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_URL.Name = "lbl_URL";
            this.lbl_URL.Size = new System.Drawing.Size(76, 18);
            this.lbl_URL.TabIndex = 1;
            this.lbl_URL.Text = "Base URL";
            this.lbl_URL.Click += new System.EventHandler(this.lbl_URL_Click);
            // 
            // lbl_APIKey
            // 
            this.lbl_APIKey.AutoSize = true;
            this.lbl_APIKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_APIKey.Location = new System.Drawing.Point(427, 27);
            this.lbl_APIKey.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_APIKey.Name = "lbl_APIKey";
            this.lbl_APIKey.Size = new System.Drawing.Size(59, 18);
            this.lbl_APIKey.TabIndex = 2;
            this.lbl_APIKey.Text = "API Key";
            // 
            // txt_APIKey
            // 
            this.txt_APIKey.Location = new System.Drawing.Point(330, 51);
            this.txt_APIKey.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_APIKey.Name = "txt_APIKey";
            this.txt_APIKey.PasswordChar = '*';
            this.txt_APIKey.Size = new System.Drawing.Size(280, 23);
            this.txt_APIKey.TabIndex = 3;
            // 
            // btn_APICall
            // 
            this.btn_APICall.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_APICall.Location = new System.Drawing.Point(668, 40);
            this.btn_APICall.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_APICall.Name = "btn_APICall";
            this.btn_APICall.Size = new System.Drawing.Size(188, 40);
            this.btn_APICall.TabIndex = 4;
            this.btn_APICall.Text = "Commit API Call";
            this.btn_APICall.UseVisualStyleBackColor = true;
            this.btn_APICall.Click += new System.EventHandler(this.btn_APICall_Click);
            // 
            // txt_AbsoluteURI
            // 
            this.txt_AbsoluteURI.Location = new System.Drawing.Point(523, 143);
            this.txt_AbsoluteURI.Name = "txt_AbsoluteURI";
            this.txt_AbsoluteURI.Size = new System.Drawing.Size(332, 23);
            this.txt_AbsoluteURI.TabIndex = 8;
            // 
            // URLForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.txt_AbsoluteURI);
            this.Controls.Add(this.btn_APICall);
            this.Controls.Add(this.txt_APIKey);
            this.Controls.Add(this.lbl_APIKey);
            this.Controls.Add(this.lbl_URL);
            this.Controls.Add(this.txt_URL);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "URLForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_URL;
        private System.Windows.Forms.Label lbl_URL;
        private System.Windows.Forms.Label lbl_APIKey;
        private System.Windows.Forms.TextBox txt_APIKey;
        private System.Windows.Forms.Button btn_APICall;
        private System.Windows.Forms.TextBox txt_AbsoluteURI;
    }
}

