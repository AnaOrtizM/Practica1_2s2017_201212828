namespace Cliente
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.btnVerDashboard = new System.Windows.Forms.Button();
            this.btnAdminMsj = new System.Windows.Forms.Button();
            this.btnReportes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVerDashboard
            // 
            this.btnVerDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnVerDashboard.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerDashboard.Location = new System.Drawing.Point(220, 45);
            this.btnVerDashboard.Name = "btnVerDashboard";
            this.btnVerDashboard.Size = new System.Drawing.Size(220, 61);
            this.btnVerDashboard.TabIndex = 0;
            this.btnVerDashboard.Text = "VER DASHBOARD";
            this.btnVerDashboard.UseVisualStyleBackColor = false;
            this.btnVerDashboard.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAdminMsj
            // 
            this.btnAdminMsj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnAdminMsj.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminMsj.Location = new System.Drawing.Point(220, 172);
            this.btnAdminMsj.Name = "btnAdminMsj";
            this.btnAdminMsj.Size = new System.Drawing.Size(220, 61);
            this.btnAdminMsj.TabIndex = 1;
            this.btnAdminMsj.Text = "ADMINISTRAR MENSAJES";
            this.btnAdminMsj.UseVisualStyleBackColor = false;
            this.btnAdminMsj.Click += new System.EventHandler(this.btnAdminMsj_Click);
            // 
            // btnReportes
            // 
            this.btnReportes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnReportes.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportes.Location = new System.Drawing.Point(220, 302);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(220, 61);
            this.btnReportes.TabIndex = 2;
            this.btnReportes.Text = "VER REPORTES";
            this.btnReportes.UseVisualStyleBackColor = false;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Cliente.Properties.Resources.bitcoin1;
            this.ClientSize = new System.Drawing.Size(651, 411);
            this.Controls.Add(this.btnReportes);
            this.Controls.Add(this.btnAdminMsj);
            this.Controls.Add(this.btnVerDashboard);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Principal";
            this.Text = "Menú Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVerDashboard;
        private System.Windows.Forms.Button btnAdminMsj;
        private System.Windows.Forms.Button btnReportes;
    }
}

