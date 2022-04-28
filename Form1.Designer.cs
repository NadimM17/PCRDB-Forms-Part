namespace Princess_Connect_Unit_Viewer
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.charList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.atkTypeTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.posTB = new System.Windows.Forms.TextBox();
            this.iconPb = new System.Windows.Forms.PictureBox();
            this.fullCard = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showEventUnitsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.summerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.halloweenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.holidayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newYearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.valentineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ooedoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addUnitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editUnitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteUnitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.iconPb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullCard)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // charList
            // 
            this.charList.FormattingEnabled = true;
            this.charList.Location = new System.Drawing.Point(12, 27);
            this.charList.Name = "charList";
            this.charList.Size = new System.Drawing.Size(207, 21);
            this.charList.TabIndex = 0;
            this.charList.SelectedValueChanged += new System.EventHandler(this.charList_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(245, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Attack Type";
            // 
            // atkTypeTB
            // 
            this.atkTypeTB.BackColor = System.Drawing.Color.White;
            this.atkTypeTB.Location = new System.Drawing.Point(316, 47);
            this.atkTypeTB.Name = "atkTypeTB";
            this.atkTypeTB.ReadOnly = true;
            this.atkTypeTB.Size = new System.Drawing.Size(100, 20);
            this.atkTypeTB.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(266, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Position";
            // 
            // posTB
            // 
            this.posTB.BackColor = System.Drawing.Color.White;
            this.posTB.Location = new System.Drawing.Point(316, 83);
            this.posTB.Name = "posTB";
            this.posTB.ReadOnly = true;
            this.posTB.Size = new System.Drawing.Size(100, 20);
            this.posTB.TabIndex = 4;
            // 
            // iconPb
            // 
            this.iconPb.InitialImage = null;
            this.iconPb.Location = new System.Drawing.Point(601, 27);
            this.iconPb.Name = "iconPb";
            this.iconPb.Size = new System.Drawing.Size(128, 128);
            this.iconPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconPb.TabIndex = 5;
            this.iconPb.TabStop = false;
            // 
            // fullCard
            // 
            this.fullCard.InitialImage = null;
            this.fullCard.Location = new System.Drawing.Point(12, 140);
            this.fullCard.Name = "fullCard";
            this.fullCard.Size = new System.Drawing.Size(583, 370);
            this.fullCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.fullCard.TabIndex = 6;
            this.fullCard.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.dToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(741, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addUnitToolStripMenuItem,
            this.editUnitToolStripMenuItem,
            this.deleteUnitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.fileToolStripMenuItem.Text = "Database";
            // 
            // dToolStripMenuItem
            // 
            this.dToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showEventUnitsToolStripMenuItem});
            this.dToolStripMenuItem.Name = "dToolStripMenuItem";
            this.dToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.dToolStripMenuItem.Text = "Filter...";
            // 
            // showEventUnitsToolStripMenuItem
            // 
            this.showEventUnitsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.summerToolStripMenuItem,
            this.halloweenToolStripMenuItem,
            this.holidayToolStripMenuItem,
            this.newYearToolStripMenuItem,
            this.valentineToolStripMenuItem,
            this.ooedoToolStripMenuItem});
            this.showEventUnitsToolStripMenuItem.Name = "showEventUnitsToolStripMenuItem";
            this.showEventUnitsToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.showEventUnitsToolStripMenuItem.Text = "Show Event Units";
            // 
            // summerToolStripMenuItem
            // 
            this.summerToolStripMenuItem.Name = "summerToolStripMenuItem";
            this.summerToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.summerToolStripMenuItem.Text = "Summer";
            this.summerToolStripMenuItem.Click += new System.EventHandler(this.summerToolStripMenuItem_Click);
            // 
            // halloweenToolStripMenuItem
            // 
            this.halloweenToolStripMenuItem.Name = "halloweenToolStripMenuItem";
            this.halloweenToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.halloweenToolStripMenuItem.Text = "Halloween";
            this.halloweenToolStripMenuItem.Click += new System.EventHandler(this.halloweenToolStripMenuItem_Click);
            // 
            // holidayToolStripMenuItem
            // 
            this.holidayToolStripMenuItem.Name = "holidayToolStripMenuItem";
            this.holidayToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.holidayToolStripMenuItem.Text = "Holiday";
            this.holidayToolStripMenuItem.Click += new System.EventHandler(this.holidayToolStripMenuItem_Click);
            // 
            // newYearToolStripMenuItem
            // 
            this.newYearToolStripMenuItem.Name = "newYearToolStripMenuItem";
            this.newYearToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.newYearToolStripMenuItem.Text = "New Year";
            this.newYearToolStripMenuItem.Click += new System.EventHandler(this.newYearToolStripMenuItem_Click);
            // 
            // valentineToolStripMenuItem
            // 
            this.valentineToolStripMenuItem.Name = "valentineToolStripMenuItem";
            this.valentineToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.valentineToolStripMenuItem.Text = "Valentine";
            this.valentineToolStripMenuItem.Click += new System.EventHandler(this.valentineToolStripMenuItem_Click);
            // 
            // ooedoToolStripMenuItem
            // 
            this.ooedoToolStripMenuItem.Name = "ooedoToolStripMenuItem";
            this.ooedoToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.ooedoToolStripMenuItem.Text = "Oedo";
            this.ooedoToolStripMenuItem.Click += new System.EventHandler(this.ooedoToolStripMenuItem_Click);
            // 
            // addUnitToolStripMenuItem
            // 
            this.addUnitToolStripMenuItem.Name = "addUnitToolStripMenuItem";
            this.addUnitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addUnitToolStripMenuItem.Text = "Add Unit";
            this.addUnitToolStripMenuItem.Click += new System.EventHandler(this.addUnitToolStripMenuItem_Click);
            // 
            // editUnitToolStripMenuItem
            // 
            this.editUnitToolStripMenuItem.Name = "editUnitToolStripMenuItem";
            this.editUnitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editUnitToolStripMenuItem.Text = "Edit Unit";
            // 
            // deleteUnitToolStripMenuItem
            // 
            this.deleteUnitToolStripMenuItem.Name = "deleteUnitToolStripMenuItem";
            this.deleteUnitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteUnitToolStripMenuItem.Text = "Delete Unit";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 522);
            this.Controls.Add(this.fullCard);
            this.Controls.Add(this.iconPb);
            this.Controls.Add(this.posTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.atkTypeTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.charList);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Princess Connect Unit Viewer";
            ((System.ComponentModel.ISupportInitialize)(this.iconPb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullCard)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox charList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox atkTypeTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox posTB;
        private System.Windows.Forms.PictureBox iconPb;
        private System.Windows.Forms.PictureBox fullCard;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showEventUnitsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem summerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem holidayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newYearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ooedoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem halloweenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem valentineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addUnitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editUnitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteUnitToolStripMenuItem;
    }
}

