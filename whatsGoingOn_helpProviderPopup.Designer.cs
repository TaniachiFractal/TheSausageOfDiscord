namespace MaslovaT_task6_practice2024
{
    partial class whatsGoingOn_helpProviderPopup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(whatsGoingOn_helpProviderPopup));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.cat = new System.Windows.Forms.PictureBox();
            this.crow = new System.Windows.Forms.PictureBox();
            this.btOK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crow)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Gray;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(5, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(822, 96);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ты - Ворона, которой нужно победить кошку, чтобы получить колбасу. Используй атак" +
    "и, чтобы кошка испугалась и сбежала!";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::MaslovaT_task6_practice2024.Properties.Resources.sausage;
            this.pictureBox3.Location = new System.Drawing.Point(314, 271);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(103, 91);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // cat
            // 
            this.cat.Image = global::MaslovaT_task6_practice2024.Properties.Resources.cat;
            this.cat.Location = new System.Drawing.Point(468, 33);
            this.cat.Name = "cat";
            this.cat.Size = new System.Drawing.Size(360, 381);
            this.cat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cat.TabIndex = 3;
            this.cat.TabStop = false;
            // 
            // crow
            // 
            this.crow.Image = global::MaslovaT_task6_practice2024.Properties.Resources.crow;
            this.crow.Location = new System.Drawing.Point(12, 145);
            this.crow.Name = "crow";
            this.crow.Size = new System.Drawing.Size(256, 269);
            this.crow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.crow.TabIndex = 2;
            this.crow.TabStop = false;
            // 
            // btOK
            // 
            this.btOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btOK.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btOK.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btOK.Location = new System.Drawing.Point(323, 361);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(88, 55);
            this.btOK.TabIndex = 6;
            this.btOK.Text = "OK";
            this.btOK.UseVisualStyleBackColor = true;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // whatsGoingOn_helpProviderPopup
            // 
            this.AcceptButton = this.btOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(841, 426);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.crow);
            this.Controls.Add(this.cat);
            this.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.DarkGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "whatsGoingOn_helpProviderPopup";
            this.Text = "Что происходит в игре \"Колбаса Раздора\"?";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox crow;
        private System.Windows.Forms.PictureBox cat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btOK;
    }
}