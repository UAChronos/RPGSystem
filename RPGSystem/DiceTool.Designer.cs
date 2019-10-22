namespace RPGSystem
{
    partial class DiceTool
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblHeading = new System.Windows.Forms.Label();
            this.btnThrewADice = new System.Windows.Forms.Button();
            this.lblThrowResult = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.lblHeading, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnThrewADice, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblThrowResult, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(314, 292);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblHeading
            // 
            this.lblHeading.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblHeading.Location = new System.Drawing.Point(3, 0);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(311, 36);
            this.lblHeading.TabIndex = 1;
            this.lblHeading.Text = "You threw away...";
            this.lblHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnThrewADice
            // 
            this.btnThrewADice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThrewADice.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnThrewADice.Location = new System.Drawing.Point(3, 202);
            this.btnThrewADice.Name = "btnThrewADice";
            this.btnThrewADice.Size = new System.Drawing.Size(311, 87);
            this.btnThrewADice.TabIndex = 3;
            this.btnThrewADice.Text = "Threw a dice";
            this.btnThrewADice.UseVisualStyleBackColor = true;
            this.btnThrewADice.Click += new System.EventHandler(this.BtnThrewADice_Click);
            // 
            // lblThrowResult
            // 
            this.lblThrowResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblThrowResult.AutoSize = true;
            this.lblThrowResult.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblThrowResult.Location = new System.Drawing.Point(3, 36);
            this.lblThrowResult.Name = "lblThrowResult";
            this.lblThrowResult.Size = new System.Drawing.Size(311, 57);
            this.lblThrowResult.TabIndex = 2;
            this.lblThrowResult.Text = "nothing yet";
            this.lblThrowResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DiceTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 292);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "DiceTool";
            this.Text = "Dice";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Button btnThrewADice;
        private System.Windows.Forms.Label lblThrowResult;
    }
}