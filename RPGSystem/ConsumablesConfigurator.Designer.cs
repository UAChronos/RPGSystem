namespace RPGSystem
{
    partial class ConsumablesConfigurator
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
            this.lblCraftingPieces = new System.Windows.Forms.Label();
            this.lblGold = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.numAmmountOfCraftingPieces = new System.Windows.Forms.NumericUpDown();
            this.numAmmountOfGold = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAmmountOfCraftingPieces)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAmmountOfGold)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.numAmmountOfGold, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblCraftingPieces, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblGold, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnSubmit, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.numAmmountOfCraftingPieces, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(363, 98);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblCraftingPieces
            // 
            this.lblCraftingPieces.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCraftingPieces.AutoSize = true;
            this.lblCraftingPieces.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCraftingPieces.Location = new System.Drawing.Point(3, 4);
            this.lblCraftingPieces.Name = "lblCraftingPieces";
            this.lblCraftingPieces.Size = new System.Drawing.Size(112, 18);
            this.lblCraftingPieces.TabIndex = 30;
            this.lblCraftingPieces.Text = "Crafting Pieces:";
            // 
            // lblGold
            // 
            this.lblGold.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGold.AutoSize = true;
            this.lblGold.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblGold.Location = new System.Drawing.Point(3, 31);
            this.lblGold.Name = "lblGold";
            this.lblGold.Size = new System.Drawing.Size(112, 18);
            this.lblGold.TabIndex = 31;
            this.lblGold.Text = "Gold:";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.btnSubmit, 2);
            this.btnSubmit.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSubmit.Location = new System.Drawing.Point(3, 57);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(357, 38);
            this.btnSubmit.TabIndex = 34;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // numAmmountOfCraftingPieces
            // 
            this.numAmmountOfCraftingPieces.AllowDrop = true;
            this.numAmmountOfCraftingPieces.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numAmmountOfCraftingPieces.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numAmmountOfCraftingPieces.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numAmmountOfCraftingPieces.Location = new System.Drawing.Point(121, 3);
            this.numAmmountOfCraftingPieces.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numAmmountOfCraftingPieces.Minimum = new decimal(new int[] {
            2147483647,
            0,
            0,
            -2147483648});
            this.numAmmountOfCraftingPieces.Name = "numAmmountOfCraftingPieces";
            this.numAmmountOfCraftingPieces.Size = new System.Drawing.Size(239, 21);
            this.numAmmountOfCraftingPieces.TabIndex = 35;
            // 
            // numAmmountOfGold
            // 
            this.numAmmountOfGold.AllowDrop = true;
            this.numAmmountOfGold.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numAmmountOfGold.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numAmmountOfGold.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numAmmountOfGold.Location = new System.Drawing.Point(121, 30);
            this.numAmmountOfGold.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numAmmountOfGold.Minimum = new decimal(new int[] {
            2147483647,
            0,
            0,
            -2147483648});
            this.numAmmountOfGold.Name = "numAmmountOfGold";
            this.numAmmountOfGold.Size = new System.Drawing.Size(239, 21);
            this.numAmmountOfGold.TabIndex = 36;
            // 
            // ConsumablesConfigurator
            // 
            this.AcceptButton = this.btnSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 98);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.Name = "ConsumablesConfigurator";
            this.Text = "ConsumablesConfigurator";
            this.Load += new System.EventHandler(this.ConsumablesConfigurator_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAmmountOfCraftingPieces)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAmmountOfGold)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblCraftingPieces;
        private System.Windows.Forms.Label lblGold;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.NumericUpDown numAmmountOfGold;
        private System.Windows.Forms.NumericUpDown numAmmountOfCraftingPieces;
    }
}