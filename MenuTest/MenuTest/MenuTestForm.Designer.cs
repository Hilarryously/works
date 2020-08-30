namespace MenuTest
{
   partial class MenuTestForm
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose( bool disposing )
      {
         if ( disposing && ( components != null ) )
         {
            components.Dispose();
         }
         base.Dispose( disposing );
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.greenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.courierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dashToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.boldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.italicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayLabel = new System.Windows.Forms.Label();
            this.extremeYellowToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.extremeYellowToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.eventLog2 = new System.Diagnostics.EventLog();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.formatToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(380, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // formatToolStripMenuItem
            // 
            this.formatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorToolStripMenuItem,
            this.fontToolStripMenuItem});
            this.formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            this.formatToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.formatToolStripMenuItem.Text = "Format";
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.blackToolStripMenuItem,
            this.blueToolStripMenuItem,
            this.redToolStripMenuItem,
            this.greenToolStripMenuItem,
            this.extremeYellowToolStripMenuItem,
            this.extremeYellowToolStripMenuItem1});
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.colorToolStripMenuItem.Text = "Color";
            // 
            // blackToolStripMenuItem
            // 
            this.blackToolStripMenuItem.Checked = true;
            this.blackToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.blackToolStripMenuItem.Name = "blackToolStripMenuItem";
            this.blackToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.blackToolStripMenuItem.Text = "Black";
            this.blackToolStripMenuItem.Click += new System.EventHandler(this.blackToolStripMenuItem_Click);
            // 
            // blueToolStripMenuItem
            // 
            this.blueToolStripMenuItem.Name = "blueToolStripMenuItem";
            this.blueToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.blueToolStripMenuItem.Text = "Blue";
            this.blueToolStripMenuItem.Click += new System.EventHandler(this.blueToolStripMenuItem_Click);
            // 
            // redToolStripMenuItem
            // 
            this.redToolStripMenuItem.Name = "redToolStripMenuItem";
            this.redToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.redToolStripMenuItem.Text = "Red";
            this.redToolStripMenuItem.Click += new System.EventHandler(this.redToolStripMenuItem_Click);
            // 
            // greenToolStripMenuItem
            // 
            this.greenToolStripMenuItem.Name = "greenToolStripMenuItem";
            this.greenToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.greenToolStripMenuItem.Text = "Green";
            this.greenToolStripMenuItem.Click += new System.EventHandler(this.greenToolStripMenuItem_Click);
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.timesToolStripMenuItem,
            this.courierToolStripMenuItem,
            this.comicToolStripMenuItem,
            this.dashToolStripMenuItem,
            this.boldToolStripMenuItem,
            this.italicToolStripMenuItem});
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.fontToolStripMenuItem.Text = "Font";
            // 
            // timesToolStripMenuItem
            // 
            this.timesToolStripMenuItem.Checked = true;
            this.timesToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.timesToolStripMenuItem.Name = "timesToolStripMenuItem";
            this.timesToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.timesToolStripMenuItem.Text = "Times New Roman";
            this.timesToolStripMenuItem.Click += new System.EventHandler(this.timesToolStripMenuItem_Click);
            // 
            // courierToolStripMenuItem
            // 
            this.courierToolStripMenuItem.Name = "courierToolStripMenuItem";
            this.courierToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.courierToolStripMenuItem.Text = "Courier";
            this.courierToolStripMenuItem.Click += new System.EventHandler(this.courierToolStripMenuItem_Click);
            // 
            // comicToolStripMenuItem
            // 
            this.comicToolStripMenuItem.Name = "comicToolStripMenuItem";
            this.comicToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.comicToolStripMenuItem.Text = "Comic Sans";
            this.comicToolStripMenuItem.Click += new System.EventHandler(this.comicToolStripMenuItem_Click);
            // 
            // dashToolStripMenuItem
            // 
            this.dashToolStripMenuItem.Name = "dashToolStripMenuItem";
            this.dashToolStripMenuItem.Size = new System.Drawing.Size(171, 6);
            // 
            // boldToolStripMenuItem
            // 
            this.boldToolStripMenuItem.Name = "boldToolStripMenuItem";
            this.boldToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.boldToolStripMenuItem.Text = "Bold";
            this.boldToolStripMenuItem.Click += new System.EventHandler(this.boldToolStripMenuItem_Click);
            // 
            // italicToolStripMenuItem
            // 
            this.italicToolStripMenuItem.Name = "italicToolStripMenuItem";
            this.italicToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.italicToolStripMenuItem.Text = "Italic";
            this.italicToolStripMenuItem.Click += new System.EventHandler(this.italicToolStripMenuItem_Click);
            // 
            // displayLabel
            // 
            this.displayLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayLabel.Location = new System.Drawing.Point(12, 82);
            this.displayLabel.Name = "displayLabel";
            this.displayLabel.Size = new System.Drawing.Size(293, 89);
            this.displayLabel.TabIndex = 12;
            this.displayLabel.Text = "Use the Format menu to change the appearance of this text.";
            // 
            // extremeYellowToolStripMenuItem
            // 
            this.extremeYellowToolStripMenuItem.Name = "extremeYellowToolStripMenuItem";
            this.extremeYellowToolStripMenuItem.Size = new System.Drawing.Size(187, 6);
            // 
            // extremeYellowToolStripMenuItem1
            // 
            this.extremeYellowToolStripMenuItem1.Name = "extremeYellowToolStripMenuItem1";
            this.extremeYellowToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Y)));
            this.extremeYellowToolStripMenuItem1.Size = new System.Drawing.Size(190, 22);
            this.extremeYellowToolStripMenuItem1.Text = "Extreme &Yellow";
            this.extremeYellowToolStripMenuItem1.Click += new System.EventHandler(this.extremeYellowToolStripMenuItem1_Click);
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // eventLog2
            // 
            this.eventLog2.SynchronizingObject = this;
            // 
            // MenuTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 195);
            this.Controls.Add(this.displayLabel);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MenuTestForm";
            this.Text = "Menu Test";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.MenuStrip menuStrip1;
      private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem formatToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem blackToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem blueToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem redToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem greenToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem timesToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem courierToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem comicToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem boldToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem italicToolStripMenuItem;
      private System.Windows.Forms.ToolStripSeparator dashToolStripMenuItem;
      internal System.Windows.Forms.Label displayLabel;
        private System.Windows.Forms.ToolStripSeparator extremeYellowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem extremeYellowToolStripMenuItem1;
        private System.Diagnostics.EventLog eventLog1;
        private System.Diagnostics.EventLog eventLog2;
    }
}
