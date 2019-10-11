namespace RPGSystem
{
    partial class PlayerStats
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtPlayersItems = new TextBoxBorderColor.MyTextBox();
            this.txtPlayersSkills = new TextBoxBorderColor.MyTextBox();
            this.lblPlayersItems = new System.Windows.Forms.Label();
            this.lblPlayersSkills = new System.Windows.Forms.Label();
            this.lblPlayersClass = new System.Windows.Forms.Label();
            this.txtPlayersClass = new TextBoxBorderColor.MyTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.lockToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(100, 48);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // lockToolStripMenuItem
            // 
            this.lockToolStripMenuItem.Name = "lockToolStripMenuItem";
            this.lockToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.lockToolStripMenuItem.Text = "Lock";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.txtPlayersItems, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtPlayersSkills, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblPlayersItems, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblPlayersSkills, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblPlayersClass, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtPlayersClass, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(241, 354);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // txtPlayersItems
            // 
            this.txtPlayersItems.AllowDrop = true;
            this.txtPlayersItems.BorderColor = System.Drawing.Color.Blue;
            this.txtPlayersItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPlayersItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPlayersItems.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txtPlayersItems.Location = new System.Drawing.Point(74, 211);
            this.txtPlayersItems.Multiline = true;
            this.txtPlayersItems.Name = "txtPlayersItems";
            this.txtPlayersItems.ReadOnly = true;
            this.txtPlayersItems.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPlayersItems.Size = new System.Drawing.Size(164, 140);
            this.txtPlayersItems.TabIndex = 12;
            this.txtPlayersItems.Text = "Knife, bow, armor";
            this.txtPlayersItems.DoubleClick += new System.EventHandler(this.TxtPlayersItems_DoubleClick);
            this.txtPlayersItems.MouseLeave += new System.EventHandler(this.TxtPlayersItems_MouseLeave);
            // 
            // txtPlayersSkills
            // 
            this.txtPlayersSkills.AllowDrop = true;
            this.txtPlayersSkills.BorderColor = System.Drawing.Color.Blue;
            this.txtPlayersSkills.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPlayersSkills.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPlayersSkills.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txtPlayersSkills.Location = new System.Drawing.Point(74, 81);
            this.txtPlayersSkills.Multiline = true;
            this.txtPlayersSkills.Name = "txtPlayersSkills";
            this.txtPlayersSkills.ReadOnly = true;
            this.txtPlayersSkills.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPlayersSkills.Size = new System.Drawing.Size(164, 124);
            this.txtPlayersSkills.TabIndex = 11;
            this.txtPlayersSkills.Text = "Pickpocketing, backstab";
            this.txtPlayersSkills.DoubleClick += new System.EventHandler(this.TxtPlayersSkills_DoubleClick);
            this.txtPlayersSkills.MouseLeave += new System.EventHandler(this.TxtPlayersSkills_MouseLeave);
            // 
            // lblPlayersItems
            // 
            this.lblPlayersItems.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPlayersItems.AutoSize = true;
            this.lblPlayersItems.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblPlayersItems.Location = new System.Drawing.Point(3, 208);
            this.lblPlayersItems.Name = "lblPlayersItems";
            this.lblPlayersItems.Size = new System.Drawing.Size(65, 25);
            this.lblPlayersItems.TabIndex = 9;
            this.lblPlayersItems.Text = "Skills:";
            // 
            // lblPlayersSkills
            // 
            this.lblPlayersSkills.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPlayersSkills.AutoSize = true;
            this.lblPlayersSkills.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblPlayersSkills.Location = new System.Drawing.Point(3, 78);
            this.lblPlayersSkills.Name = "lblPlayersSkills";
            this.lblPlayersSkills.Size = new System.Drawing.Size(65, 25);
            this.lblPlayersSkills.TabIndex = 8;
            this.lblPlayersSkills.Text = "Skills:";
            // 
            // lblPlayersClass
            // 
            this.lblPlayersClass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPlayersClass.AutoSize = true;
            this.lblPlayersClass.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblPlayersClass.Location = new System.Drawing.Point(3, 43);
            this.lblPlayersClass.Name = "lblPlayersClass";
            this.lblPlayersClass.Size = new System.Drawing.Size(65, 25);
            this.lblPlayersClass.TabIndex = 7;
            this.lblPlayersClass.Text = "Class:";
            // 
            // txtPlayersClass
            // 
            this.txtPlayersClass.AllowDrop = true;
            this.txtPlayersClass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPlayersClass.BorderColor = System.Drawing.Color.Blue;
            this.txtPlayersClass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPlayersClass.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txtPlayersClass.Location = new System.Drawing.Point(74, 46);
            this.txtPlayersClass.Multiline = true;
            this.txtPlayersClass.Name = "txtPlayersClass";
            this.txtPlayersClass.ReadOnly = true;
            this.txtPlayersClass.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPlayersClass.Size = new System.Drawing.Size(164, 29);
            this.txtPlayersClass.TabIndex = 10;
            this.txtPlayersClass.Text = "Thief";
            this.txtPlayersClass.DoubleClick += new System.EventHandler(this.TxtPlayersClass_DoubleClick);
            this.txtPlayersClass.MouseLeave += new System.EventHandler(this.TxtPlayersClass_MouseLeave);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 2);
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 43);
            this.label1.TabIndex = 13;
            this.label1.Text = "Chronos";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PlayerStats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "PlayerStats";
            this.Size = new System.Drawing.Size(241, 354);
            this.contextMenuStrip1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lockToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblPlayersClass;
        private System.Windows.Forms.Label lblPlayersItems;
        private System.Windows.Forms.Label lblPlayersSkills;
        private TextBoxBorderColor.MyTextBox txtPlayersClass;
        private TextBoxBorderColor.MyTextBox txtPlayersSkills;
        private TextBoxBorderColor.MyTextBox txtPlayersItems;
        private System.Windows.Forms.Label label1;
    }
}
