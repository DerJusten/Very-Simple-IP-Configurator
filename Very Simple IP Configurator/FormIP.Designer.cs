
namespace Very_Simple_IP_Configurator
{
    partial class FormIP
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormIP));
            this.textBoxIpSettingCidr = new System.Windows.Forms.TextBox();
            this.textBoxStaticGateway = new System.Windows.Forms.TextBox();
            this.textBoxStaticSubnet = new System.Windows.Forms.TextBox();
            this.textBoxStaticIp = new System.Windows.Forms.TextBox();
            this.textBoxDns2 = new System.Windows.Forms.TextBox();
            this.textBoxDns1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.buttonCancel = new System.Windows.Forms.Button();
            this.customLabel4 = new Very_Simple_IP_Configurator.CustomLabel();
            this.customLabel3 = new Very_Simple_IP_Configurator.CustomLabel();
            this.customLabel2 = new Very_Simple_IP_Configurator.CustomLabel();
            this.customLabel1 = new Very_Simple_IP_Configurator.CustomLabel();
            this.customLabel5 = new Very_Simple_IP_Configurator.CustomLabel();
            this.customLabel6 = new Very_Simple_IP_Configurator.CustomLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxIpSettingCidr
            // 
            this.textBoxIpSettingCidr.Location = new System.Drawing.Point(278, 38);
            this.textBoxIpSettingCidr.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBoxIpSettingCidr.MaxLength = 2;
            this.textBoxIpSettingCidr.Name = "textBoxIpSettingCidr";
            this.textBoxIpSettingCidr.Size = new System.Drawing.Size(43, 24);
            this.textBoxIpSettingCidr.TabIndex = 2;
            this.textBoxIpSettingCidr.TextChanged += new System.EventHandler(this.textBoxIpSettingCidr_TextChanged);
            // 
            // textBoxStaticGateway
            // 
            this.textBoxStaticGateway.Location = new System.Drawing.Point(21, 132);
            this.textBoxStaticGateway.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBoxStaticGateway.MaxLength = 15;
            this.textBoxStaticGateway.Name = "textBoxStaticGateway";
            this.textBoxStaticGateway.Size = new System.Drawing.Size(234, 24);
            this.textBoxStaticGateway.TabIndex = 4;
            this.textBoxStaticGateway.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxStaticIp_KeyPress);
            // 
            // textBoxStaticSubnet
            // 
            this.textBoxStaticSubnet.Location = new System.Drawing.Point(21, 85);
            this.textBoxStaticSubnet.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBoxStaticSubnet.MaxLength = 15;
            this.textBoxStaticSubnet.Name = "textBoxStaticSubnet";
            this.textBoxStaticSubnet.Size = new System.Drawing.Size(234, 24);
            this.textBoxStaticSubnet.TabIndex = 3;
            this.textBoxStaticSubnet.TextChanged += new System.EventHandler(this.textBoxStaticSubnet_TextChanged);
            // 
            // textBoxStaticIp
            // 
            this.textBoxStaticIp.Location = new System.Drawing.Point(21, 38);
            this.textBoxStaticIp.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBoxStaticIp.MaxLength = 15;
            this.textBoxStaticIp.Name = "textBoxStaticIp";
            this.textBoxStaticIp.Size = new System.Drawing.Size(234, 24);
            this.textBoxStaticIp.TabIndex = 1;
            this.textBoxStaticIp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxStaticIp_KeyPress);
            // 
            // textBoxDns2
            // 
            this.textBoxDns2.Location = new System.Drawing.Point(20, 88);
            this.textBoxDns2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBoxDns2.MaxLength = 15;
            this.textBoxDns2.Name = "textBoxDns2";
            this.textBoxDns2.Size = new System.Drawing.Size(234, 24);
            this.textBoxDns2.TabIndex = 6;
            this.textBoxDns2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxStaticIp_KeyPress);
            // 
            // textBoxDns1
            // 
            this.textBoxDns1.Location = new System.Drawing.Point(20, 41);
            this.textBoxDns1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBoxDns1.MaxLength = 15;
            this.textBoxDns1.Name = "textBoxDns1";
            this.textBoxDns1.Size = new System.Drawing.Size(234, 24);
            this.textBoxDns1.TabIndex = 5;
            this.textBoxDns1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxStaticIp_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.customLabel5);
            this.groupBox1.Controls.Add(this.customLabel6);
            this.groupBox1.Controls.Add(this.textBoxDns2);
            this.groupBox1.Controls.Add(this.textBoxDns1);
            this.groupBox1.Location = new System.Drawing.Point(12, 179);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(343, 130);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.customLabel4);
            this.groupBox2.Controls.Add(this.customLabel3);
            this.groupBox2.Controls.Add(this.customLabel2);
            this.groupBox2.Controls.Add(this.customLabel1);
            this.groupBox2.Controls.Add(this.textBoxIpSettingCidr);
            this.groupBox2.Controls.Add(this.textBoxStaticGateway);
            this.groupBox2.Controls.Add(this.textBoxStaticSubnet);
            this.groupBox2.Controls.Add(this.textBoxStaticIp);
            this.groupBox2.Location = new System.Drawing.Point(12, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(343, 172);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(261, 326);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(94, 34);
            this.buttonSubmit.TabIndex = 8;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(14, 326);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(94, 34);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // customLabel4
            // 
            this.customLabel4.AutoSize = true;
            this.customLabel4.Location = new System.Drawing.Point(260, 41);
            this.customLabel4.Name = "customLabel4";
            this.customLabel4.Size = new System.Drawing.Size(13, 17);
            this.customLabel4.TabIndex = 16;
            this.customLabel4.Text = "/";
            // 
            // customLabel3
            // 
            this.customLabel3.AutoSize = true;
            this.customLabel3.Location = new System.Drawing.Point(18, 112);
            this.customLabel3.Name = "customLabel3";
            this.customLabel3.Size = new System.Drawing.Size(57, 17);
            this.customLabel3.TabIndex = 15;
            this.customLabel3.Text = "Gateway";
            // 
            // customLabel2
            // 
            this.customLabel2.AutoSize = true;
            this.customLabel2.Location = new System.Drawing.Point(18, 65);
            this.customLabel2.Name = "customLabel2";
            this.customLabel2.Size = new System.Drawing.Size(78, 17);
            this.customLabel2.TabIndex = 14;
            this.customLabel2.Text = "Subnetmask";
            // 
            // customLabel1
            // 
            this.customLabel1.AutoSize = true;
            this.customLabel1.Location = new System.Drawing.Point(18, 18);
            this.customLabel1.Name = "customLabel1";
            this.customLabel1.Size = new System.Drawing.Size(71, 17);
            this.customLabel1.TabIndex = 13;
            this.customLabel1.Text = "IP-Address";
            // 
            // customLabel5
            // 
            this.customLabel5.AutoSize = true;
            this.customLabel5.Location = new System.Drawing.Point(17, 68);
            this.customLabel5.Name = "customLabel5";
            this.customLabel5.Size = new System.Drawing.Size(140, 17);
            this.customLabel5.TabIndex = 20;
            this.customLabel5.Text = "Secondary DNS Server";
            // 
            // customLabel6
            // 
            this.customLabel6.AutoSize = true;
            this.customLabel6.Location = new System.Drawing.Point(17, 21);
            this.customLabel6.Name = "customLabel6";
            this.customLabel6.Size = new System.Drawing.Size(123, 17);
            this.customLabel6.TabIndex = 19;
            this.customLabel6.Text = "Primary DNS Server";
            // 
            // FormIP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(371, 365);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormIP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "IP-Address";
            this.Load += new System.EventHandler(this.FormIP_Load);
            this.Shown += new System.EventHandler(this.FormIP_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormIP_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxIpSettingCidr;
        private System.Windows.Forms.TextBox textBoxStaticGateway;
        private System.Windows.Forms.TextBox textBoxStaticSubnet;
        private System.Windows.Forms.TextBox textBoxStaticIp;
        private CustomLabel customLabel1;
        private CustomLabel customLabel2;
        private CustomLabel customLabel3;
        private CustomLabel customLabel4;
        private CustomLabel customLabel5;
        private CustomLabel customLabel6;
        private System.Windows.Forms.TextBox textBoxDns2;
        private System.Windows.Forms.TextBox textBoxDns1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button buttonCancel;
    }
}