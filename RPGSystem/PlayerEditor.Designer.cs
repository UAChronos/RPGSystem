namespace RPGSystem
{
    partial class PlayerEditor
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
            this.txtPlayersClass = new System.Windows.Forms.TextBox();
            this.lblPlayersName = new System.Windows.Forms.Label();
            this.txtPlayersSkills = new System.Windows.Forms.TextBox();
            this.txtPlayersName = new System.Windows.Forms.TextBox();
            this.txtPlayersItems = new System.Windows.Forms.TextBox();
            this.lblPlayersItems = new System.Windows.Forms.Label();
            this.lblPlayersClass = new System.Windows.Forms.Label();
            this.lblPlayersSkills = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.52439F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.47561F));
            this.tableLayoutPanel1.Controls.Add(this.txtPlayersClass, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblPlayersName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtPlayersSkills, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtPlayersName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtPlayersItems, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblPlayersItems, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblPlayersClass, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblPlayersSkills, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(328, 450);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // txtPlayersClass
            // 
            this.txtPlayersClass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPlayersClass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPlayersClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPlayersClass.Location = new System.Drawing.Point(89, 104);
            this.txtPlayersClass.Multiline = true;
            this.txtPlayersClass.Name = "txtPlayersClass";
            this.txtPlayersClass.Size = new System.Drawing.Size(236, 95);
            this.txtPlayersClass.TabIndex = 1;
            this.txtPlayersClass.Text = "Pickpocketing";
            // 
            // lblPlayersName
            // 
            this.lblPlayersName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPlayersName.AutoSize = true;
            this.lblPlayersName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblPlayersName.Location = new System.Drawing.Point(3, 0);
            this.lblPlayersName.Name = "lblPlayersName";
            this.lblPlayersName.Size = new System.Drawing.Size(80, 25);
            this.lblPlayersName.TabIndex = 7;
            this.lblPlayersName.Text = "Name:";
            // 
            // txtPlayersSkills
            // 
            this.txtPlayersSkills.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPlayersSkills.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPlayersSkills.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPlayersSkills.Location = new System.Drawing.Point(89, 205);
            this.txtPlayersSkills.Multiline = true;
            this.txtPlayersSkills.Name = "txtPlayersSkills";
            this.txtPlayersSkills.Size = new System.Drawing.Size(236, 95);
            this.txtPlayersSkills.TabIndex = 2;
            this.txtPlayersSkills.Text = "Thief";
            // 
            // txtPlayersName
            // 
            this.txtPlayersName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPlayersName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPlayersName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPlayersName.Location = new System.Drawing.Point(89, 3);
            this.txtPlayersName.Multiline = true;
            this.txtPlayersName.Name = "txtPlayersName";
            this.txtPlayersName.Size = new System.Drawing.Size(236, 95);
            this.txtPlayersName.TabIndex = 0;
            this.txtPlayersName.Text = "Thief";
            // 
            // txtPlayersItems
            // 
            this.txtPlayersItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPlayersItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPlayersItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPlayersItems.Location = new System.Drawing.Point(89, 306);
            this.txtPlayersItems.Multiline = true;
            this.txtPlayersItems.Name = "txtPlayersItems";
            this.txtPlayersItems.Size = new System.Drawing.Size(236, 95);
            this.txtPlayersItems.TabIndex = 3;
            this.txtPlayersItems.Text = "Thief";
            // 
            // lblPlayersItems
            // 
            this.lblPlayersItems.AutoSize = true;
            this.lblPlayersItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblPlayersItems.Location = new System.Drawing.Point(3, 303);
            this.lblPlayersItems.Name = "lblPlayersItems";
            this.lblPlayersItems.Size = new System.Drawing.Size(75, 25);
            this.lblPlayersItems.TabIndex = 9;
            this.lblPlayersItems.Text = "Items:";
            // 
            // lblPlayersClass
            // 
            this.lblPlayersClass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPlayersClass.AutoSize = true;
            this.lblPlayersClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblPlayersClass.Location = new System.Drawing.Point(3, 101);
            this.lblPlayersClass.Name = "lblPlayersClass";
            this.lblPlayersClass.Size = new System.Drawing.Size(80, 25);
            this.lblPlayersClass.TabIndex = 17;
            this.lblPlayersClass.Text = "Class:";
            // 
            // lblPlayersSkills
            // 
            this.lblPlayersSkills.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPlayersSkills.AutoSize = true;
            this.lblPlayersSkills.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblPlayersSkills.Location = new System.Drawing.Point(3, 202);
            this.lblPlayersSkills.Name = "lblPlayersSkills";
            this.lblPlayersSkills.Size = new System.Drawing.Size(80, 25);
            this.lblPlayersSkills.TabIndex = 8;
            this.lblPlayersSkills.Text = "Skills:";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btnSubmit, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnCancel, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 405);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(328, 45);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSubmit.Location = new System.Drawing.Point(3, 3);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(158, 39);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancel.Location = new System.Drawing.Point(167, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(158, 39);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // PlayerEditor
            // 
            this.AcceptButton = this.btnSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(328, 450);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "PlayerEditor";
            this.Text = "PlayerEditor";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblPlayersItems;
        private System.Windows.Forms.Label lblPlayersSkills;
        private System.Windows.Forms.Label lblPlayersName;
        private System.Windows.Forms.Label lblPlayersClass;
        private System.Windows.Forms.TextBox txtPlayersName;
        private System.Windows.Forms.TextBox txtPlayersItems;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtPlayersClass;
        private System.Windows.Forms.TextBox txtPlayersSkills;
    }
}