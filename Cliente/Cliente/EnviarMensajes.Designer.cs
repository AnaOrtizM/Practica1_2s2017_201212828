namespace Cliente
{
    partial class EnviarMensajes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnviarMensajes));
            this.button2 = new System.Windows.Forms.Button();
            this.btnXml = new System.Windows.Forms.Button();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMsj = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDest1 = new System.Windows.Forms.TextBox();
            this.txtDest2 = new System.Windows.Forms.TextBox();
            this.txtDest3 = new System.Windows.Forms.TextBox();
            this.txtDest4 = new System.Windows.Forms.TextBox();
            this.txtDest5 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button2.Image = global::Cliente.Properties.Resources.if_back_1931;
            this.button2.Location = new System.Drawing.Point(12, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(35, 33);
            this.button2.TabIndex = 3;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnXml
            // 
            this.btnXml.BackColor = System.Drawing.Color.MintCream;
            this.btnXml.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXml.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnXml.Location = new System.Drawing.Point(197, 12);
            this.btnXml.Name = "btnXml";
            this.btnXml.Size = new System.Drawing.Size(127, 33);
            this.btnXml.TabIndex = 4;
            this.btnXml.Text = "CARGAR XML";
            this.btnXml.UseVisualStyleBackColor = false;
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackColor = System.Drawing.Color.MintCream;
            this.btnEnviar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnEnviar.Location = new System.Drawing.Point(412, 70);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnEnviar.Size = new System.Drawing.Size(127, 33);
            this.btnEnviar.TabIndex = 5;
            this.btnEnviar.Text = "ENVIAR";
            this.btnEnviar.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(8, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mensaje a Enviar:";
            // 
            // txtMsj
            // 
            this.txtMsj.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMsj.Location = new System.Drawing.Point(12, 172);
            this.txtMsj.Name = "txtMsj";
            this.txtMsj.Size = new System.Drawing.Size(254, 205);
            this.txtMsj.TabIndex = 7;
            this.txtMsj.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(379, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "IP Destinatario(os):";
            // 
            // txtDest1
            // 
            this.txtDest1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDest1.Location = new System.Drawing.Point(383, 172);
            this.txtDest1.Name = "txtDest1";
            this.txtDest1.Size = new System.Drawing.Size(156, 27);
            this.txtDest1.TabIndex = 9;
            // 
            // txtDest2
            // 
            this.txtDest2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDest2.Location = new System.Drawing.Point(383, 218);
            this.txtDest2.Name = "txtDest2";
            this.txtDest2.Size = new System.Drawing.Size(156, 27);
            this.txtDest2.TabIndex = 10;
            // 
            // txtDest3
            // 
            this.txtDest3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDest3.Location = new System.Drawing.Point(383, 261);
            this.txtDest3.Name = "txtDest3";
            this.txtDest3.Size = new System.Drawing.Size(156, 27);
            this.txtDest3.TabIndex = 11;
            // 
            // txtDest4
            // 
            this.txtDest4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDest4.Location = new System.Drawing.Point(383, 308);
            this.txtDest4.Name = "txtDest4";
            this.txtDest4.Size = new System.Drawing.Size(156, 27);
            this.txtDest4.TabIndex = 12;
            // 
            // txtDest5
            // 
            this.txtDest5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDest5.Location = new System.Drawing.Point(383, 350);
            this.txtDest5.Name = "txtDest5";
            this.txtDest5.Size = new System.Drawing.Size(156, 27);
            this.txtDest5.TabIndex = 13;
            // 
            // EnviarMensajes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Cliente.Properties.Resources.Page_icon_blockchain_interactive_training;
            this.ClientSize = new System.Drawing.Size(551, 414);
            this.Controls.Add(this.txtDest5);
            this.Controls.Add(this.txtDest4);
            this.Controls.Add(this.txtDest3);
            this.Controls.Add(this.txtDest2);
            this.Controls.Add(this.txtDest1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMsj);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.btnXml);
            this.Controls.Add(this.button2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EnviarMensajes";
            this.Text = "Enviar Mensajes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnXml;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txtMsj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDest1;
        private System.Windows.Forms.TextBox txtDest2;
        private System.Windows.Forms.TextBox txtDest3;
        private System.Windows.Forms.TextBox txtDest4;
        private System.Windows.Forms.TextBox txtDest5;
    }
}