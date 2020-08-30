//
//
namespace ComboBox
{
    partial class Form1
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
            this.States = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // States
            // 
            this.States.FormattingEnabled = true;
            this.States.Items.AddRange(new object[] {
            "Arizona",
            "California",
            "Nevada",
            "Las Vegas",
            "Texas",
            "Idaho",
            "Washington",
            "New York",
            "New Jersey",
            "Alabama",
            "Florida",
            "Virginia",
            "Maryland",
            "Missouri",
            "Mississippi"});
            this.States.Location = new System.Drawing.Point(38, 12);
            this.States.Name = "States";
            this.States.Size = new System.Drawing.Size(199, 21);
            this.States.TabIndex = 0;
            this.States.SelectedIndexChanged += new System.EventHandler(this.States_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.States);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox States;
    }
}

