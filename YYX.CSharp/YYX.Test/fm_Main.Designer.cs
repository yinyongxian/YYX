namespace YYX.Test
{
    partial class fm_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fm_Main));
            this.button_OK = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button_ObjectConverter = new System.Windows.Forms.Button();
            this.button_Email = new System.Windows.Forms.Button();
            this.button_Ping = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_OK
            // 
            resources.ApplyResources(this.button_OK, "button_OK");
            this.button_OK.Name = "button_OK";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // button_Cancel
            // 
            resources.ApplyResources(this.button_Cancel, "button_Cancel");
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.button_ObjectConverter);
            this.flowLayoutPanel1.Controls.Add(this.button_Email);
            this.flowLayoutPanel1.Controls.Add(this.button_Ping);
            resources.ApplyResources(this.flowLayoutPanel1, "flowLayoutPanel1");
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            // 
            // button_ObjectConverter
            // 
            resources.ApplyResources(this.button_ObjectConverter, "button_ObjectConverter");
            this.button_ObjectConverter.Name = "button_ObjectConverter";
            this.button_ObjectConverter.UseVisualStyleBackColor = true;
            this.button_ObjectConverter.Click += new System.EventHandler(this.button_ObjectConverter_Click);
            // 
            // button_Email
            // 
            resources.ApplyResources(this.button_Email, "button_Email");
            this.button_Email.Name = "button_Email";
            this.button_Email.UseVisualStyleBackColor = true;
            this.button_Email.Click += new System.EventHandler(this.button_Email_Click);
            // 
            // button_Ping
            // 
            resources.ApplyResources(this.button_Ping, "button_Ping");
            this.button_Ping.Name = "button_Ping";
            this.button_Ping.UseVisualStyleBackColor = true;
            this.button_Ping.Click += new System.EventHandler(this.button_Ping_Click);
            // 
            // fm_Main
            // 
            this.AcceptButton = this.button_OK;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_OK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "fm_Main";
            this.ShowIcon = false;
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button_ObjectConverter;
        private System.Windows.Forms.Button button_Email;
        private System.Windows.Forms.Button button_Ping;
    }
}

