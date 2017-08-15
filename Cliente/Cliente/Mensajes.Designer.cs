namespace Cliente
{
    partial class Mensajes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mensajes));
            this.button2 = new System.Windows.Forms.Button();
            this.btnRespuestaMsj = new System.Windows.Forms.Button();
            this.btnColaMsjs = new System.Windows.Forms.Button();
            this.btnEnviarMsjs = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button2.Image = global::Cliente.Properties.Resources.if_back_1931;
            this.button2.Location = new System.Drawing.Point(12, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(35, 33);
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnRespuestaMsj
            // 
            this.btnRespuestaMsj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnRespuestaMsj.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRespuestaMsj.Location = new System.Drawing.Point(144, 348);
            this.btnRespuestaMsj.Name = "btnRespuestaMsj";
            this.btnRespuestaMsj.Size = new System.Drawing.Size(220, 61);
            this.btnRespuestaMsj.TabIndex = 5;
            this.btnRespuestaMsj.Text = "VER RESPUESTA DE MENSAJES";
            this.btnRespuestaMsj.UseVisualStyleBackColor = false;
            this.btnRespuestaMsj.Click += new System.EventHandler(this.btnRespuestaMsj_Click);
            // 
            // btnColaMsjs
            // 
            this.btnColaMsjs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnColaMsjs.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColaMsjs.Location = new System.Drawing.Point(144, 218);
            this.btnColaMsjs.Name = "btnColaMsjs";
            this.btnColaMsjs.Size = new System.Drawing.Size(220, 61);
            this.btnColaMsjs.TabIndex = 4;
            this.btnColaMsjs.Text = "VER COLA DE MENSAJES";
            this.btnColaMsjs.UseVisualStyleBackColor = false;
            this.btnColaMsjs.Click += new System.EventHandler(this.btnColaMsjs_Click);
            // 
            // btnEnviarMsjs
            // 
            this.btnEnviarMsjs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnEnviarMsjs.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviarMsjs.Location = new System.Drawing.Point(144, 91);
            this.btnEnviarMsjs.Name = "btnEnviarMsjs";
            this.btnEnviarMsjs.Size = new System.Drawing.Size(220, 61);
            this.btnEnviarMsjs.TabIndex = 3;
            this.btnEnviarMsjs.Text = "ENVIAR MENSAJES";
            this.btnEnviarMsjs.UseVisualStyleBackColor = false;
            this.btnEnviarMsjs.Click += new System.EventHandler(this.btnEnviarMsjs_Click);
            // 
            // Mensajes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Cliente.Properties.Resources.blockchain_3_128;
            this.ClientSize = new System.Drawing.Size(508, 498);
            this.Controls.Add(this.btnRespuestaMsj);
            this.Controls.Add(this.btnColaMsjs);
            this.Controls.Add(this.btnEnviarMsjs);
            this.Controls.Add(this.button2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Mensajes";
            this.Text = "Administración de Mensajes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnRespuestaMsj;
        private System.Windows.Forms.Button btnColaMsjs;
        private System.Windows.Forms.Button btnEnviarMsjs;
    }
}