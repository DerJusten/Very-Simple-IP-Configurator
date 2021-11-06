
namespace Very_Simple_IP_Configurator
{
    partial class FormCmd
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonRoutePrint = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(57, 153);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(836, 464);
            this.textBox1.TabIndex = 0;
            // 
            // buttonRoutePrint
            // 
            this.buttonRoutePrint.Location = new System.Drawing.Point(57, 34);
            this.buttonRoutePrint.Name = "buttonRoutePrint";
            this.buttonRoutePrint.Size = new System.Drawing.Size(118, 56);
            this.buttonRoutePrint.TabIndex = 1;
            this.buttonRoutePrint.Text = "Route Print";
            this.buttonRoutePrint.UseVisualStyleBackColor = true;
            this.buttonRoutePrint.Click += new System.EventHandler(this.buttonRoutePrint_Click);
            // 
            // FormCmd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 655);
            this.Controls.Add(this.buttonRoutePrint);
            this.Controls.Add(this.textBox1);
            this.Name = "FormCmd";
            this.Text = "FormCmd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonRoutePrint;
    }
}