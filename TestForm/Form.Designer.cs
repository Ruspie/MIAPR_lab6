namespace TestForm
{
    partial class Form
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
            this.DistanceSettingsGroupBox = new System.Windows.Forms.GroupBox();
            this.DistanceDataGridView = new System.Windows.Forms.DataGridView();
            this.GenerateDistanceButton = new System.Windows.Forms.Button();
            this.CountObjectsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.CountObjectsLabel = new System.Windows.Forms.Label();
            this.HierarchicalTreeGroupBox = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DistanceSettingsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DistanceDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountObjectsNumericUpDown)).BeginInit();
            this.HierarchicalTreeGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DistanceSettingsGroupBox
            // 
            this.DistanceSettingsGroupBox.Controls.Add(this.DistanceDataGridView);
            this.DistanceSettingsGroupBox.Controls.Add(this.GenerateDistanceButton);
            this.DistanceSettingsGroupBox.Controls.Add(this.CountObjectsNumericUpDown);
            this.DistanceSettingsGroupBox.Controls.Add(this.CountObjectsLabel);
            this.DistanceSettingsGroupBox.Location = new System.Drawing.Point(12, 27);
            this.DistanceSettingsGroupBox.Name = "DistanceSettingsGroupBox";
            this.DistanceSettingsGroupBox.Size = new System.Drawing.Size(366, 349);
            this.DistanceSettingsGroupBox.TabIndex = 0;
            this.DistanceSettingsGroupBox.TabStop = false;
            this.DistanceSettingsGroupBox.Text = "Distance settings :";
            // 
            // DistanceDataGridView
            // 
            this.DistanceDataGridView.AllowUserToAddRows = false;
            this.DistanceDataGridView.AllowUserToDeleteRows = false;
            this.DistanceDataGridView.AllowUserToResizeColumns = false;
            this.DistanceDataGridView.AllowUserToResizeRows = false;
            this.DistanceDataGridView.ColumnHeadersHeight = 4;
            this.DistanceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DistanceDataGridView.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.DistanceDataGridView.Location = new System.Drawing.Point(6, 48);
            this.DistanceDataGridView.Name = "DistanceDataGridView";
            this.DistanceDataGridView.RowHeadersWidth = 4;
            this.DistanceDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DistanceDataGridView.Size = new System.Drawing.Size(354, 295);
            this.DistanceDataGridView.TabIndex = 3;
            this.DistanceDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DistanceDataGridView_CellValueChanged);
            // 
            // GenerateDistanceButton
            // 
            this.GenerateDistanceButton.Location = new System.Drawing.Point(210, 19);
            this.GenerateDistanceButton.Name = "GenerateDistanceButton";
            this.GenerateDistanceButton.Size = new System.Drawing.Size(150, 23);
            this.GenerateDistanceButton.TabIndex = 2;
            this.GenerateDistanceButton.Text = "Generate distance";
            this.GenerateDistanceButton.UseVisualStyleBackColor = true;
            this.GenerateDistanceButton.Click += new System.EventHandler(this.GenerateDistanceButton_Click);
            // 
            // CountObjectsNumericUpDown
            // 
            this.CountObjectsNumericUpDown.Location = new System.Drawing.Point(84, 22);
            this.CountObjectsNumericUpDown.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.CountObjectsNumericUpDown.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.CountObjectsNumericUpDown.Name = "CountObjectsNumericUpDown";
            this.CountObjectsNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.CountObjectsNumericUpDown.TabIndex = 1;
            this.CountObjectsNumericUpDown.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.CountObjectsNumericUpDown.ValueChanged += new System.EventHandler(this.CountObjectsNumericUpDown_ValueChanged);
            // 
            // CountObjectsLabel
            // 
            this.CountObjectsLabel.AutoSize = true;
            this.CountObjectsLabel.Location = new System.Drawing.Point(6, 24);
            this.CountObjectsLabel.Name = "CountObjectsLabel";
            this.CountObjectsLabel.Size = new System.Drawing.Size(72, 13);
            this.CountObjectsLabel.TabIndex = 0;
            this.CountObjectsLabel.Text = "Count objects";
            // 
            // HierarchicalTreeGroupBox
            // 
            this.HierarchicalTreeGroupBox.Controls.Add(this.pictureBox1);
            this.HierarchicalTreeGroupBox.Location = new System.Drawing.Point(384, 27);
            this.HierarchicalTreeGroupBox.Name = "HierarchicalTreeGroupBox";
            this.HierarchicalTreeGroupBox.Size = new System.Drawing.Size(403, 349);
            this.HierarchicalTreeGroupBox.TabIndex = 4;
            this.HierarchicalTreeGroupBox.TabStop = false;
            this.HierarchicalTreeGroupBox.Text = "Hierarchical tree :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(3, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(397, 330);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.runToolStripMenuItem,
            this.aboutProgramToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(799, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // runToolStripMenuItem
            // 
            this.runToolStripMenuItem.Name = "runToolStripMenuItem";
            this.runToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.runToolStripMenuItem.Text = "Run";
            this.runToolStripMenuItem.Click += new System.EventHandler(this.runToolStripMenuItem_Click);
            // 
            // aboutProgramToolStripMenuItem
            // 
            this.aboutProgramToolStripMenuItem.Name = "aboutProgramToolStripMenuItem";
            this.aboutProgramToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.aboutProgramToolStripMenuItem.Text = "About program";
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 388);
            this.Controls.Add(this.HierarchicalTreeGroupBox);
            this.Controls.Add(this.DistanceSettingsGroupBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form";
            this.Text = "Hierarchical gouper";
            this.DistanceSettingsGroupBox.ResumeLayout(false);
            this.DistanceSettingsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DistanceDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountObjectsNumericUpDown)).EndInit();
            this.HierarchicalTreeGroupBox.ResumeLayout(false);
            this.HierarchicalTreeGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox DistanceSettingsGroupBox;
        private System.Windows.Forms.DataGridView DistanceDataGridView;
        private System.Windows.Forms.Button GenerateDistanceButton;
        private System.Windows.Forms.NumericUpDown CountObjectsNumericUpDown;
        private System.Windows.Forms.Label CountObjectsLabel;
        private System.Windows.Forms.GroupBox HierarchicalTreeGroupBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutProgramToolStripMenuItem;
    }
}

