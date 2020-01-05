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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayerStats));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtPlayersItems = new System.Windows.Forms.TextBox();
            this.lblPlayersItems = new System.Windows.Forms.Label();
            this.lblPlayersSkills = new System.Windows.Forms.Label();
            this.lblPlayersClass = new System.Windows.Forms.Label();
            this.lblPlayersName = new System.Windows.Forms.Label();
            this.btnEditPlayer = new System.Windows.Forms.Button();
            this.txtPlayersSkills = new System.Windows.Forms.TextBox();
            this.txtPlayersClass = new System.Windows.Forms.TextBox();
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
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.Controls.Add(this.txtPlayersItems, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblPlayersItems, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblPlayersSkills, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblPlayersClass, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblPlayersName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnEditPlayer, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtPlayersSkills, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtPlayersClass, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(351, 471);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // txtPlayersItems
            // 
            this.txtPlayersItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPlayersItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableLayoutPanel1.SetColumnSpan(this.txtPlayersItems, 2);
            this.txtPlayersItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPlayersItems.Location = new System.Drawing.Point(87, 218);
            this.txtPlayersItems.Multiline = true;
            this.txtPlayersItems.Name = "txtPlayersItems";
            this.txtPlayersItems.ReadOnly = true;
            this.txtPlayersItems.Size = new System.Drawing.Size(261, 250);
            this.txtPlayersItems.TabIndex = 16;
            this.txtPlayersItems.Text = "Knife";
            // 
            // lblPlayersItems
            // 
            this.lblPlayersItems.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPlayersItems.AutoSize = true;
            this.lblPlayersItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblPlayersItems.Location = new System.Drawing.Point(3, 215);
            this.lblPlayersItems.Name = "lblPlayersItems";
            this.lblPlayersItems.Size = new System.Drawing.Size(78, 25);
            this.lblPlayersItems.TabIndex = 9;
            this.lblPlayersItems.Text = "Items:";
            // 
            // lblPlayersSkills
            // 
            this.lblPlayersSkills.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPlayersSkills.AutoSize = true;
            this.lblPlayersSkills.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblPlayersSkills.Location = new System.Drawing.Point(3, 127);
            this.lblPlayersSkills.Name = "lblPlayersSkills";
            this.lblPlayersSkills.Size = new System.Drawing.Size(78, 25);
            this.lblPlayersSkills.TabIndex = 8;
            this.lblPlayersSkills.Text = "Skills:";
            // 
            // lblPlayersClass
            // 
            this.lblPlayersClass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPlayersClass.AutoSize = true;
            this.lblPlayersClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblPlayersClass.Location = new System.Drawing.Point(3, 39);
            this.lblPlayersClass.Name = "lblPlayersClass";
            this.lblPlayersClass.Size = new System.Drawing.Size(78, 25);
            this.lblPlayersClass.TabIndex = 7;
            this.lblPlayersClass.Text = "Class:";
            // 
            // lblPlayersName
            // 
            this.lblPlayersName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.lblPlayersName, 2);
            this.lblPlayersName.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblPlayersName.Location = new System.Drawing.Point(3, 0);
            this.lblPlayersName.Name = "lblPlayersName";
            this.lblPlayersName.Size = new System.Drawing.Size(310, 39);
            this.lblPlayersName.TabIndex = 13;
            this.lblPlayersName.Text = "Chronos";
            this.lblPlayersName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEditPlayer
            // 
            this.btnEditPlayer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditPlayer.Image = ((System.Drawing.Image)(resources.GetObject("btnEditPlayer.Image")));
            this.btnEditPlayer.Location = new System.Drawing.Point(319, 3);
            this.btnEditPlayer.Name = "btnEditPlayer";
            this.btnEditPlayer.Size = new System.Drawing.Size(29, 33);
            this.btnEditPlayer.TabIndex = 17;
            this.btnEditPlayer.UseVisualStyleBackColor = true;
            this.btnEditPlayer.Click += new System.EventHandler(this.btnEditPlayer_Click);
            // 
            // txtPlayersSkills
            // 
            this.txtPlayersSkills.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPlayersSkills.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableLayoutPanel1.SetColumnSpan(this.txtPlayersSkills, 2);
            this.txtPlayersSkills.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPlayersSkills.Location = new System.Drawing.Point(87, 130);
            this.txtPlayersSkills.Multiline = true;
            this.txtPlayersSkills.Name = "txtPlayersSkills";
            this.txtPlayersSkills.ReadOnly = true;
            this.txtPlayersSkills.Size = new System.Drawing.Size(261, 82);
            this.txtPlayersSkills.TabIndex = 15;
            this.txtPlayersSkills.Text = "Pickpocketing";
            // 
            // txtPlayersClass
            // 
            this.txtPlayersClass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPlayersClass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableLayoutPanel1.SetColumnSpan(this.txtPlayersClass, 2);
            this.txtPlayersClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPlayersClass.Location = new System.Drawing.Point(87, 42);
            this.txtPlayersClass.Multiline = true;
            this.txtPlayersClass.Name = "txtPlayersClass";
            this.txtPlayersClass.ReadOnly = true;
            this.txtPlayersClass.Size = new System.Drawing.Size(261, 82);
            this.txtPlayersClass.TabIndex = 14;
            this.txtPlayersClass.Text = "Thief";
            // 
            // PlayerStats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "PlayerStats";
            this.Size = new System.Drawing.Size(351, 471);
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
        private System.Windows.Forms.Label lblPlayersName;
        private System.Windows.Forms.TextBox txtPlayersClass;
        private System.Windows.Forms.TextBox txtPlayersItems;
        private System.Windows.Forms.TextBox txtPlayersSkills;
        private System.Windows.Forms.Button btnEditPlayer;
    }
}
