namespace Nail_It
{
    partial class NailItForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NailItForm));
            this.inputBrowseButton = new System.Windows.Forms.Button();
            this.outputBrowseButton = new System.Windows.Forms.Button();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.executeButton = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.maxWidthNumeric = new System.Windows.Forms.NumericUpDown();
            this.maxHeightNumeric = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.maxWidthNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxHeightNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // inputBrowseButton
            // 
            this.inputBrowseButton.Location = new System.Drawing.Point(13, 8);
            this.inputBrowseButton.Name = "inputBrowseButton";
            this.inputBrowseButton.Size = new System.Drawing.Size(75, 23);
            this.inputBrowseButton.TabIndex = 0;
            this.inputBrowseButton.Text = "Browse";
            this.inputBrowseButton.UseVisualStyleBackColor = true;
            this.inputBrowseButton.Click += new System.EventHandler(this.inputBrowseButton_Click);
            // 
            // outputBrowseButton
            // 
            this.outputBrowseButton.Location = new System.Drawing.Point(13, 38);
            this.outputBrowseButton.Name = "outputBrowseButton";
            this.outputBrowseButton.Size = new System.Drawing.Size(75, 23);
            this.outputBrowseButton.TabIndex = 1;
            this.outputBrowseButton.Text = "Browse";
            this.outputBrowseButton.UseVisualStyleBackColor = true;
            this.outputBrowseButton.Click += new System.EventHandler(this.outputBrowseButton_Click);
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(94, 11);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(251, 20);
            this.inputTextBox.TabIndex = 2;
            this.inputTextBox.Text = "Input Directory";
            // 
            // outputTextBox
            // 
            this.outputTextBox.Location = new System.Drawing.Point(94, 40);
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.Size = new System.Drawing.Size(251, 20);
            this.outputTextBox.TabIndex = 3;
            this.outputTextBox.Text = "Output Directory";
            // 
            // executeButton
            // 
            this.executeButton.Location = new System.Drawing.Point(13, 67);
            this.executeButton.Name = "executeButton";
            this.executeButton.Size = new System.Drawing.Size(75, 23);
            this.executeButton.TabIndex = 7;
            this.executeButton.Text = "Execute";
            this.executeButton.UseVisualStyleBackColor = true;
            this.executeButton.Click += new System.EventHandler(this.executeButton_Click);
            // 
            // maxWidthNumeric
            // 
            this.maxWidthNumeric.Location = new System.Drawing.Point(137, 67);
            this.maxWidthNumeric.Maximum = new decimal(new int[] {
            512,
            0,
            0,
            0});
            this.maxWidthNumeric.Name = "maxWidthNumeric";
            this.maxWidthNumeric.Size = new System.Drawing.Size(78, 20);
            this.maxWidthNumeric.TabIndex = 8;
            this.maxWidthNumeric.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            // 
            // maxHeightNumeric
            // 
            this.maxHeightNumeric.Location = new System.Drawing.Point(262, 67);
            this.maxHeightNumeric.Maximum = new decimal(new int[] {
            512,
            0,
            0,
            0});
            this.maxHeightNumeric.Name = "maxHeightNumeric";
            this.maxHeightNumeric.Size = new System.Drawing.Size(83, 20);
            this.maxHeightNumeric.TabIndex = 9;
            this.maxHeightNumeric.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Width";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(221, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Height";
            // 
            // NailItForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 97);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maxHeightNumeric);
            this.Controls.Add(this.maxWidthNumeric);
            this.Controls.Add(this.executeButton);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.outputBrowseButton);
            this.Controls.Add(this.inputBrowseButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NailItForm";
            this.Text = "Nail it: Thumnail Resizing Tool";
            ((System.ComponentModel.ISupportInitialize)(this.maxWidthNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxHeightNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button inputBrowseButton;
        private System.Windows.Forms.Button outputBrowseButton;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.TextBox outputTextBox;
        private System.Windows.Forms.Button executeButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.NumericUpDown maxWidthNumeric;
        private System.Windows.Forms.NumericUpDown maxHeightNumeric;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;

    }
}

