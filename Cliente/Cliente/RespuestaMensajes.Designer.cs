namespace Cliente
{
    partial class RespuestaMensajes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RespuestaMensajes));
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Carnet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Inorden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Postorden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Resultado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnMostrarAntiguos = new System.Windows.Forms.Button();
            this.btnMostrarRecientes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button2.Image = global::Cliente.Properties.Resources.if_back_1931;
            this.button2.Location = new System.Drawing.Point(12, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(35, 33);
            this.button2.TabIndex = 5;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Carnet,
            this.IP,
            this.Inorden,
            this.Postorden,
            this.Resultado});
            this.dataGridView1.Location = new System.Drawing.Point(12, 73);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(578, 398);
            this.dataGridView1.TabIndex = 6;
            // 
            // Carnet
            // 
            this.Carnet.HeaderText = "Carnet que Operó";
            this.Carnet.Name = "Carnet";
            // 
            // IP
            // 
            this.IP.HeaderText = "IP que Operó";
            this.IP.Name = "IP";
            // 
            // Inorden
            // 
            this.Inorden.HeaderText = "Inorden";
            this.Inorden.Name = "Inorden";
            // 
            // Postorden
            // 
            this.Postorden.HeaderText = "Postorden";
            this.Postorden.Name = "Postorden";
            // 
            // Resultado
            // 
            this.Resultado.HeaderText = "Resultado";
            this.Resultado.Name = "Resultado";
            // 
            // btnMostrarAntiguos
            // 
            this.btnMostrarAntiguos.BackColor = System.Drawing.Color.MintCream;
            this.btnMostrarAntiguos.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarAntiguos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnMostrarAntiguos.Location = new System.Drawing.Point(107, 491);
            this.btnMostrarAntiguos.Name = "btnMostrarAntiguos";
            this.btnMostrarAntiguos.Size = new System.Drawing.Size(370, 33);
            this.btnMostrarAntiguos.TabIndex = 10;
            this.btnMostrarAntiguos.Text = "MOSTRAR EMPEZANDO POR LOS MAS ANTIGUOS";
            this.btnMostrarAntiguos.UseVisualStyleBackColor = false;
            // 
            // btnMostrarRecientes
            // 
            this.btnMostrarRecientes.BackColor = System.Drawing.Color.MintCream;
            this.btnMostrarRecientes.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarRecientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnMostrarRecientes.Location = new System.Drawing.Point(107, 541);
            this.btnMostrarRecientes.Name = "btnMostrarRecientes";
            this.btnMostrarRecientes.Size = new System.Drawing.Size(370, 33);
            this.btnMostrarRecientes.TabIndex = 11;
            this.btnMostrarRecientes.Text = "MOSTRAR EMPEZANDO POR LOS MAS RECIENTES";
            this.btnMostrarRecientes.UseVisualStyleBackColor = false;
            // 
            // RespuestaMensajes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Cliente.Properties.Resources.blockchain_5_128;
            this.ClientSize = new System.Drawing.Size(602, 601);
            this.Controls.Add(this.btnMostrarRecientes);
            this.Controls.Add(this.btnMostrarAntiguos);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RespuestaMensajes";
            this.Text = "Respuesta de Mensajes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Carnet;
        private System.Windows.Forms.DataGridViewTextBoxColumn IP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Inorden;
        private System.Windows.Forms.DataGridViewTextBoxColumn Postorden;
        private System.Windows.Forms.DataGridViewTextBoxColumn Resultado;
        private System.Windows.Forms.Button btnMostrarAntiguos;
        private System.Windows.Forms.Button btnMostrarRecientes;
    }
}