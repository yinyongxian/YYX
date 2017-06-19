namespace YYX.Test
{
    partial class Form_ObjectConverter
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
            this.button_OK = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.groupBox_BeforeSerialization = new System.Windows.Forms.GroupBox();
            this.numericUpDown_BeforeSerializationAge = new System.Windows.Forms.NumericUpDown();
            this.label_BeforeSerializationAge = new System.Windows.Forms.Label();
            this.textBox_BeforeSerializationname = new System.Windows.Forms.TextBox();
            this.label_BeforeSerializationName = new System.Windows.Forms.Label();
            this.groupBox_AfterSerialization = new System.Windows.Forms.GroupBox();
            this.numericUpDown_AfterSerializationAge = new System.Windows.Forms.NumericUpDown();
            this.label_AfterSerializationAge = new System.Windows.Forms.Label();
            this.textBox_AfterSerializationName = new System.Windows.Forms.TextBox();
            this.label_AfterSerializationName = new System.Windows.Forms.Label();
            this.groupBox_BeforeSerialization.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_BeforeSerializationAge)).BeginInit();
            this.groupBox_AfterSerialization.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_AfterSerializationAge)).BeginInit();
            this.SuspendLayout();
            // 
            // button_OK
            // 
            this.button_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button_OK.Location = new System.Drawing.Point(216, 326);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(75, 23);
            this.button_OK.TabIndex = 0;
            this.button_OK.Text = "OK";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_Cancel.Location = new System.Drawing.Point(297, 326);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(75, 23);
            this.button_Cancel.TabIndex = 1;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // groupBox_BeforeSerialization
            // 
            this.groupBox_BeforeSerialization.Controls.Add(this.numericUpDown_BeforeSerializationAge);
            this.groupBox_BeforeSerialization.Controls.Add(this.label_BeforeSerializationAge);
            this.groupBox_BeforeSerialization.Controls.Add(this.textBox_BeforeSerializationname);
            this.groupBox_BeforeSerialization.Controls.Add(this.label_BeforeSerializationName);
            this.groupBox_BeforeSerialization.Location = new System.Drawing.Point(12, 12);
            this.groupBox_BeforeSerialization.Name = "groupBox_BeforeSerialization";
            this.groupBox_BeforeSerialization.Size = new System.Drawing.Size(360, 150);
            this.groupBox_BeforeSerialization.TabIndex = 2;
            this.groupBox_BeforeSerialization.TabStop = false;
            this.groupBox_BeforeSerialization.Text = "序列化之前";
            // 
            // numericUpDown_BeforeSerializationAge
            // 
            this.numericUpDown_BeforeSerializationAge.Location = new System.Drawing.Point(48, 86);
            this.numericUpDown_BeforeSerializationAge.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.numericUpDown_BeforeSerializationAge.Name = "numericUpDown_BeforeSerializationAge";
            this.numericUpDown_BeforeSerializationAge.Size = new System.Drawing.Size(100, 21);
            this.numericUpDown_BeforeSerializationAge.TabIndex = 4;
            this.numericUpDown_BeforeSerializationAge.Value = new decimal(new int[] {
            90,
            0,
            0,
            0});
            // 
            // label_BeforeSerializationAge
            // 
            this.label_BeforeSerializationAge.AutoSize = true;
            this.label_BeforeSerializationAge.Location = new System.Drawing.Point(13, 89);
            this.label_BeforeSerializationAge.Name = "label_BeforeSerializationAge";
            this.label_BeforeSerializationAge.Size = new System.Drawing.Size(29, 12);
            this.label_BeforeSerializationAge.TabIndex = 2;
            this.label_BeforeSerializationAge.Text = "年龄";
            // 
            // textBox_BeforeSerializationname
            // 
            this.textBox_BeforeSerializationname.Location = new System.Drawing.Point(48, 44);
            this.textBox_BeforeSerializationname.Name = "textBox_BeforeSerializationname";
            this.textBox_BeforeSerializationname.Size = new System.Drawing.Size(100, 21);
            this.textBox_BeforeSerializationname.TabIndex = 1;
            this.textBox_BeforeSerializationname.Text = "拿破仑";
            // 
            // label_BeforeSerializationName
            // 
            this.label_BeforeSerializationName.AutoSize = true;
            this.label_BeforeSerializationName.Location = new System.Drawing.Point(13, 47);
            this.label_BeforeSerializationName.Name = "label_BeforeSerializationName";
            this.label_BeforeSerializationName.Size = new System.Drawing.Size(29, 12);
            this.label_BeforeSerializationName.TabIndex = 0;
            this.label_BeforeSerializationName.Text = "名字";
            // 
            // groupBox_AfterSerialization
            // 
            this.groupBox_AfterSerialization.Controls.Add(this.numericUpDown_AfterSerializationAge);
            this.groupBox_AfterSerialization.Controls.Add(this.label_AfterSerializationAge);
            this.groupBox_AfterSerialization.Controls.Add(this.textBox_AfterSerializationName);
            this.groupBox_AfterSerialization.Controls.Add(this.label_AfterSerializationName);
            this.groupBox_AfterSerialization.Location = new System.Drawing.Point(12, 170);
            this.groupBox_AfterSerialization.Name = "groupBox_AfterSerialization";
            this.groupBox_AfterSerialization.Size = new System.Drawing.Size(360, 150);
            this.groupBox_AfterSerialization.TabIndex = 4;
            this.groupBox_AfterSerialization.TabStop = false;
            this.groupBox_AfterSerialization.Text = "序列化之后";
            // 
            // numericUpDown_AfterSerializationAge
            // 
            this.numericUpDown_AfterSerializationAge.Location = new System.Drawing.Point(48, 87);
            this.numericUpDown_AfterSerializationAge.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.numericUpDown_AfterSerializationAge.Name = "numericUpDown_AfterSerializationAge";
            this.numericUpDown_AfterSerializationAge.Size = new System.Drawing.Size(100, 21);
            this.numericUpDown_AfterSerializationAge.TabIndex = 5;
            // 
            // label_AfterSerializationAge
            // 
            this.label_AfterSerializationAge.AutoSize = true;
            this.label_AfterSerializationAge.Location = new System.Drawing.Point(13, 89);
            this.label_AfterSerializationAge.Name = "label_AfterSerializationAge";
            this.label_AfterSerializationAge.Size = new System.Drawing.Size(29, 12);
            this.label_AfterSerializationAge.TabIndex = 2;
            this.label_AfterSerializationAge.Text = "年龄";
            // 
            // textBox_AfterSerializationName
            // 
            this.textBox_AfterSerializationName.Location = new System.Drawing.Point(48, 44);
            this.textBox_AfterSerializationName.Name = "textBox_AfterSerializationName";
            this.textBox_AfterSerializationName.Size = new System.Drawing.Size(100, 21);
            this.textBox_AfterSerializationName.TabIndex = 1;
            // 
            // label_AfterSerializationName
            // 
            this.label_AfterSerializationName.AutoSize = true;
            this.label_AfterSerializationName.Location = new System.Drawing.Point(13, 47);
            this.label_AfterSerializationName.Name = "label_AfterSerializationName";
            this.label_AfterSerializationName.Size = new System.Drawing.Size(29, 12);
            this.label_AfterSerializationName.TabIndex = 0;
            this.label_AfterSerializationName.Text = "名字";
            // 
            // Form_ObjectConverter
            // 
            this.AcceptButton = this.button_OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.groupBox_AfterSerialization);
            this.Controls.Add(this.groupBox_BeforeSerialization);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_OK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form_ObjectConverter";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_ObjectConverter";
            this.groupBox_BeforeSerialization.ResumeLayout(false);
            this.groupBox_BeforeSerialization.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_BeforeSerializationAge)).EndInit();
            this.groupBox_AfterSerialization.ResumeLayout(false);
            this.groupBox_AfterSerialization.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_AfterSerializationAge)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.GroupBox groupBox_BeforeSerialization;
        private System.Windows.Forms.Label label_BeforeSerializationAge;
        private System.Windows.Forms.TextBox textBox_BeforeSerializationname;
        private System.Windows.Forms.Label label_BeforeSerializationName;
        private System.Windows.Forms.GroupBox groupBox_AfterSerialization;
        private System.Windows.Forms.Label label_AfterSerializationAge;
        private System.Windows.Forms.TextBox textBox_AfterSerializationName;
        private System.Windows.Forms.Label label_AfterSerializationName;
        private System.Windows.Forms.NumericUpDown numericUpDown_BeforeSerializationAge;
        private System.Windows.Forms.NumericUpDown numericUpDown_AfterSerializationAge;
    }
}