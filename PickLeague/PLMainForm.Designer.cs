namespace PickLeague
{
    partial class PLMainForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Games = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlayerOne = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlayerTwo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weekSelector = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.weekConfirm = new System.Windows.Forms.Button();
            this.seasonSaveButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Games,
            this.PlayerOne,
            this.PlayerTwo});
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(598, 385);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Games
            // 
            this.Games.HeaderText = "Games";
            this.Games.Name = "Games";
            this.Games.ReadOnly = true;
            // 
            // PlayerOne
            // 
            this.PlayerOne.HeaderText = "Player 1";
            this.PlayerOne.Name = "PlayerOne";
            this.PlayerOne.ReadOnly = true;
            // 
            // PlayerTwo
            // 
            this.PlayerTwo.HeaderText = "Player 2";
            this.PlayerTwo.Name = "PlayerTwo";
            this.PlayerTwo.ReadOnly = true;
            // 
            // weekSelector
            // 
            this.weekSelector.FormattingEnabled = true;
            this.weekSelector.Location = new System.Drawing.Point(87, 397);
            this.weekSelector.Name = "weekSelector";
            this.weekSelector.Size = new System.Drawing.Size(276, 21);
            this.weekSelector.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 400);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Week Select";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // weekConfirm
            // 
            this.weekConfirm.Location = new System.Drawing.Point(369, 398);
            this.weekConfirm.Name = "weekConfirm";
            this.weekConfirm.Size = new System.Drawing.Size(130, 20);
            this.weekConfirm.TabIndex = 3;
            this.weekConfirm.Text = "Select Week";
            this.weekConfirm.UseVisualStyleBackColor = true;
            // 
            // seasonSaveButton
            // 
            this.seasonSaveButton.Location = new System.Drawing.Point(363, 436);
            this.seasonSaveButton.Name = "seasonSaveButton";
            this.seasonSaveButton.Size = new System.Drawing.Size(75, 23);
            this.seasonSaveButton.TabIndex = 4;
            this.seasonSaveButton.Text = "Save";
            this.seasonSaveButton.UseVisualStyleBackColor = true;
            this.seasonSaveButton.Click += new System.EventHandler(this.PLMainForm_SaveClick);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(444, 436);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 5;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.PLMainForm_Close);
            // 
            // PLMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 471);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.seasonSaveButton);
            this.Controls.Add(this.weekConfirm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.weekSelector);
            this.Controls.Add(this.dataGridView1);
            this.Name = "PLMainForm";
            this.Text = "PickLeague";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Games;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlayerOne;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlayerTwo;
        private System.Windows.Forms.ComboBox weekSelector;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button weekConfirm;
        private System.Windows.Forms.Button seasonSaveButton;
        private System.Windows.Forms.Button closeButton;
    }
}

