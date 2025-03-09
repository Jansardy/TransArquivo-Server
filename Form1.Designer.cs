namespace TransArquivo_Server
{
    partial class frmServidor
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Conexao = new System.Windows.Forms.Button();
            this.txtPorta = new System.Windows.Forms.NumericUpDown();
            this.txtBox_IP = new System.Windows.Forms.TextBox();
            this.btn_StopConection = new System.Windows.Forms.Button();
            this.lblLink_Pasta = new System.Windows.Forms.LinkLabel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtPorta)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(54, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Servidor para Compartilhar Arquivo";
            // 
            // btn_Conexao
            // 
            this.btn_Conexao.Location = new System.Drawing.Point(30, 117);
            this.btn_Conexao.Name = "btn_Conexao";
            this.btn_Conexao.Size = new System.Drawing.Size(168, 30);
            this.btn_Conexao.TabIndex = 1;
            this.btn_Conexao.Text = "Estabelecer Conexão";
            this.btn_Conexao.UseVisualStyleBackColor = true;
            this.btn_Conexao.Click += new System.EventHandler(this.btn_Conexao_Click);
            // 
            // txtPorta
            // 
            this.txtPorta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtPorta.Location = new System.Drawing.Point(204, 88);
            this.txtPorta.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.txtPorta.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txtPorta.Name = "txtPorta";
            this.txtPorta.Size = new System.Drawing.Size(58, 23);
            this.txtPorta.TabIndex = 2;
            this.txtPorta.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // txtBox_IP
            // 
            this.txtBox_IP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtBox_IP.Location = new System.Drawing.Point(30, 88);
            this.txtBox_IP.Name = "txtBox_IP";
            this.txtBox_IP.Size = new System.Drawing.Size(168, 23);
            this.txtBox_IP.TabIndex = 3;
            this.txtBox_IP.Text = "127.0.0.1";
            // 
            // btn_StopConection
            // 
            this.btn_StopConection.Location = new System.Drawing.Point(204, 117);
            this.btn_StopConection.Name = "btn_StopConection";
            this.btn_StopConection.Size = new System.Drawing.Size(141, 30);
            this.btn_StopConection.TabIndex = 4;
            this.btn_StopConection.Text = "Parar Servidor";
            this.btn_StopConection.UseVisualStyleBackColor = true;
            this.btn_StopConection.Click += new System.EventHandler(this.btn_StopConection_Click);
            // 
            // lblLink_Pasta
            // 
            this.lblLink_Pasta.AutoSize = true;
            this.lblLink_Pasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblLink_Pasta.Location = new System.Drawing.Point(27, 155);
            this.lblLink_Pasta.Name = "lblLink_Pasta";
            this.lblLink_Pasta.Size = new System.Drawing.Size(212, 17);
            this.lblLink_Pasta.TabIndex = 5;
            this.lblLink_Pasta.TabStop = true;
            this.lblLink_Pasta.Text = "Clique para selecionar a pasta...";
            this.lblLink_Pasta.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblLink_Pasta_LinkClicked);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.Info;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 190);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(400, 108);
            this.listBox1.TabIndex = 6;
            // 
            // frmServidor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 302);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lblLink_Pasta);
            this.Controls.Add(this.btn_StopConection);
            this.Controls.Add(this.txtBox_IP);
            this.Controls.Add(this.txtPorta);
            this.Controls.Add(this.btn_Conexao);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmServidor";
            this.ShowIcon = false;
            this.Text = "Servido";
            this.Load += new System.EventHandler(this.frmServidor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtPorta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Conexao;
        private System.Windows.Forms.NumericUpDown txtPorta;
        private System.Windows.Forms.TextBox txtBox_IP;
        private System.Windows.Forms.Button btn_StopConection;
        private System.Windows.Forms.LinkLabel lblLink_Pasta;
        private System.Windows.Forms.ListBox listBox1;
    }
}

