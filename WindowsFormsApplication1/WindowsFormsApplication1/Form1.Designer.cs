namespace WindowsFormsApplication1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.loadFileButton = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.cleanButton = new System.Windows.Forms.Button();
            this.settingsButton = new System.Windows.Forms.Button();
            this.settingsPanel = new System.Windows.Forms.Panel();
            this.removeExpiredCheckBox = new System.Windows.Forms.CheckBox();
            this.addDateCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.settingsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // loadFileButton
            // 
            this.loadFileButton.AccessibleDescription = "";
            this.loadFileButton.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonMenu;
            this.loadFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.loadFileButton.Location = new System.Drawing.Point(12, 424);
            this.loadFileButton.Name = "loadFileButton";
            this.loadFileButton.Size = new System.Drawing.Size(75, 23);
            this.loadFileButton.TabIndex = 1;
            this.loadFileButton.Text = "Load";
            this.loadFileButton.UseVisualStyleBackColor = true;
            this.loadFileButton.Click += new System.EventHandler(this.selectFileButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(416, 404);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveButton.Location = new System.Drawing.Point(353, 424);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 3;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // cleanButton
            // 
            this.cleanButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cleanButton.Location = new System.Drawing.Point(190, 424);
            this.cleanButton.Name = "cleanButton";
            this.cleanButton.Size = new System.Drawing.Size(75, 23);
            this.cleanButton.TabIndex = 4;
            this.cleanButton.Text = "CLEAN!";
            this.cleanButton.UseVisualStyleBackColor = true;
            this.cleanButton.Click += new System.EventHandler(this.cleanButton_Click);
            // 
            // settingsButton
            // 
            this.settingsButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.settingsButton.Image = ((System.Drawing.Image)(resources.GetObject("settingsButton.Image")));
            this.settingsButton.Location = new System.Drawing.Point(271, 424);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(23, 23);
            this.settingsButton.TabIndex = 5;
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // settingsPanel
            // 
            this.settingsPanel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.settingsPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.settingsPanel.Controls.Add(this.addDateCheckBox);
            this.settingsPanel.Controls.Add(this.removeExpiredCheckBox);
            this.settingsPanel.Location = new System.Drawing.Point(12, 391);
            this.settingsPanel.Name = "settingsPanel";
            this.settingsPanel.Size = new System.Drawing.Size(416, 25);
            this.settingsPanel.TabIndex = 6;
            this.settingsPanel.Visible = false;
            // 
            // removeExpiredCheckBox
            // 
            this.removeExpiredCheckBox.AutoSize = true;
            this.removeExpiredCheckBox.Checked = true;
            this.removeExpiredCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.removeExpiredCheckBox.Location = new System.Drawing.Point(77, 3);
            this.removeExpiredCheckBox.Name = "removeExpiredCheckBox";
            this.removeExpiredCheckBox.Size = new System.Drawing.Size(135, 17);
            this.removeExpiredCheckBox.TabIndex = 1;
            this.removeExpiredCheckBox.Text = "Remove expiered bans";
            this.removeExpiredCheckBox.UseVisualStyleBackColor = true;
            this.removeExpiredCheckBox.CheckedChanged += new System.EventHandler(this.removeExpiredCheckBox_CheckedChanged);
            // 
            // addDateCheckBox
            // 
            this.addDateCheckBox.AutoSize = true;
            this.addDateCheckBox.Checked = true;
            this.addDateCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.addDateCheckBox.Location = new System.Drawing.Point(218, 3);
            this.addDateCheckBox.Name = "addDateCheckBox";
            this.addDateCheckBox.Size = new System.Drawing.Size(99, 17);
            this.addDateCheckBox.TabIndex = 2;
            this.addDateCheckBox.Text = "Add expiry date";
            this.addDateCheckBox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(440, 459);
            this.Controls.Add(this.settingsPanel);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.cleanButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.loadFileButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "SqBanClean";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            this.settingsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button loadFileButton;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button cleanButton;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Panel settingsPanel;
        private System.Windows.Forms.CheckBox addDateCheckBox;
        private System.Windows.Forms.CheckBox removeExpiredCheckBox;
    }
}

