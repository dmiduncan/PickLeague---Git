namespace PickLeague {
    partial class PLSplash {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private string getSelectedPLLoadOptionOn() {
            return loadOptionComboBox.SelectedItem.ToString();
        }

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.loadOptionComboBox = new System.Windows.Forms.ComboBox();
            this.seasonLoadEnter = new System.Windows.Forms.Button();
            this.plClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loadOptionComboBox
            // 
            this.loadOptionComboBox.FormattingEnabled = true;
            this.loadOptionComboBox.Items.AddRange(new object[] {
            "Start New Season",
            "Load Existing Season"});
            this.loadOptionComboBox.Location = new System.Drawing.Point(12, 12);
            this.loadOptionComboBox.Name = "loadOptionComboBox";
            this.loadOptionComboBox.Size = new System.Drawing.Size(200, 21);
            this.loadOptionComboBox.TabIndex = 1;
            this.loadOptionComboBox.Text = "Select an option to open a season...";
            // 
            // seasonLoadEnter
            // 
            this.seasonLoadEnter.Location = new System.Drawing.Point(12, 51);
            this.seasonLoadEnter.Name = "seasonLoadEnter";
            this.seasonLoadEnter.Size = new System.Drawing.Size(95, 23);
            this.seasonLoadEnter.TabIndex = 2;
            this.seasonLoadEnter.Text = "Enter";
            this.seasonLoadEnter.UseVisualStyleBackColor = true;
            this.seasonLoadEnter.Click += new System.EventHandler(this.PLSplash_Enter);
            // 
            // plClose
            // 
            this.plClose.Location = new System.Drawing.Point(117, 51);
            this.plClose.Name = "plClose";
            this.plClose.Size = new System.Drawing.Size(95, 23);
            this.plClose.TabIndex = 3;
            this.plClose.Text = "Close";
            this.plClose.UseVisualStyleBackColor = true;
            this.plClose.Click += new System.EventHandler(this.PLSplash_Close);
            // 
            // PLSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 85);
            this.Controls.Add(this.plClose);
            this.Controls.Add(this.seasonLoadEnter);
            this.Controls.Add(this.loadOptionComboBox);
            this.Name = "PLSplash";
            this.Text = "PickLeague";
            this.Load += new System.EventHandler(this.PLSplash_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox loadOptionComboBox;
        private System.Windows.Forms.Button seasonLoadEnter;
        private System.Windows.Forms.Button plClose;
    }
}