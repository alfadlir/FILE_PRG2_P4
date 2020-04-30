namespace PRG2_20192_P4_2_2_03
{
    partial class DigitalClock
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
            this.LocalTimeLabel = new System.Windows.Forms.Label();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // LocalTimeLabel
            // 
            this.LocalTimeLabel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.LocalTimeLabel.Location = new System.Drawing.Point(35, 34);
            this.LocalTimeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LocalTimeLabel.Name = "LocalTimeLabel";
            this.LocalTimeLabel.Size = new System.Drawing.Size(253, 48);
            this.LocalTimeLabel.TabIndex = 0;
            this.LocalTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Timer1
            // 
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // DigitalClock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LocalTimeLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DigitalClock";
            this.Size = new System.Drawing.Size(333, 116);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LocalTimeLabel;
        private System.Windows.Forms.Timer Timer1;
    }
}
