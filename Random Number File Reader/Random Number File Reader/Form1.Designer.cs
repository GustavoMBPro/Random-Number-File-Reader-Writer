
namespace Random_Number_File_Reader
{
    partial class FormRandomNumberFileReader
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRandomNumberFileReader));
            this.labelRandom = new System.Windows.Forms.Label();
            this.listBoxRandomDisplay = new System.Windows.Forms.ListBox();
            this.labelRandomQuantity = new System.Windows.Forms.Label();
            this.labelRandomDisplay = new System.Windows.Forms.Label();
            this.buttonGetValues = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // labelRandom
            // 
            this.labelRandom.AutoSize = true;
            this.labelRandom.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelRandom.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRandom.ForeColor = System.Drawing.Color.White;
            this.labelRandom.Location = new System.Drawing.Point(123, 18);
            this.labelRandom.Name = "labelRandom";
            this.labelRandom.Size = new System.Drawing.Size(312, 31);
            this.labelRandom.TabIndex = 0;
            this.labelRandom.Text = "NUMBERS IN THE FILE";
            // 
            // listBoxRandomDisplay
            // 
            this.listBoxRandomDisplay.FormattingEnabled = true;
            this.listBoxRandomDisplay.Location = new System.Drawing.Point(129, 70);
            this.listBoxRandomDisplay.Name = "listBoxRandomDisplay";
            this.listBoxRandomDisplay.Size = new System.Drawing.Size(306, 108);
            this.listBoxRandomDisplay.TabIndex = 1;
            // 
            // labelRandomQuantity
            // 
            this.labelRandomQuantity.AutoSize = true;
            this.labelRandomQuantity.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelRandomQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRandomQuantity.ForeColor = System.Drawing.Color.White;
            this.labelRandomQuantity.Location = new System.Drawing.Point(123, 198);
            this.labelRandomQuantity.Name = "labelRandomQuantity";
            this.labelRandomQuantity.Size = new System.Drawing.Size(124, 16);
            this.labelRandomQuantity.TabIndex = 2;
            this.labelRandomQuantity.Text = "Number of integers:";
            // 
            // labelRandomDisplay
            // 
            this.labelRandomDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelRandomDisplay.Location = new System.Drawing.Point(253, 198);
            this.labelRandomDisplay.Name = "labelRandomDisplay";
            this.labelRandomDisplay.Size = new System.Drawing.Size(182, 23);
            this.labelRandomDisplay.TabIndex = 3;
            // 
            // buttonGetValues
            // 
            this.buttonGetValues.BackColor = System.Drawing.Color.White;
            this.buttonGetValues.Location = new System.Drawing.Point(142, 240);
            this.buttonGetValues.Name = "buttonGetValues";
            this.buttonGetValues.Size = new System.Drawing.Size(75, 23);
            this.buttonGetValues.TabIndex = 4;
            this.buttonGetValues.Text = "Get Values";
            this.buttonGetValues.UseVisualStyleBackColor = false;
            this.buttonGetValues.Click += new System.EventHandler(this.buttonGetValues_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.White;
            this.buttonClear.Location = new System.Drawing.Point(240, 240);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 5;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.White;
            this.buttonExit.Location = new System.Drawing.Point(341, 240);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 6;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // FormRandomNumberFileReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(563, 293);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonGetValues);
            this.Controls.Add(this.labelRandomDisplay);
            this.Controls.Add(this.labelRandomQuantity);
            this.Controls.Add(this.listBoxRandomDisplay);
            this.Controls.Add(this.labelRandom);
            this.Name = "FormRandomNumberFileReader";
            this.Text = "Random Number File Reader";
            this.Load += new System.EventHandler(this.FormRandomNumberFileReader_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelRandom;
        private System.Windows.Forms.ListBox listBoxRandomDisplay;
        private System.Windows.Forms.Label labelRandomQuantity;
        private System.Windows.Forms.Label labelRandomDisplay;
        private System.Windows.Forms.Button buttonGetValues;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

