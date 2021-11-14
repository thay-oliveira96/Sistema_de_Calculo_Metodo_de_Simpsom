
namespace M2_Projeto_Thaynan_Vinicius
{
    partial class TelaCalculoSimpsom
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtN = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colunaI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaFX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaImpar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaPar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblResultado = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblResultE = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblResultImpar = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblResultPar = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Honeydew;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.txtN);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(368, 64);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Este Programa aceita apenas o valor 20, Por favor digite o valor:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.Location = new System.Drawing.Point(251, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(13, 32);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(235, 23);
            this.txtN.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colunaI,
            this.colunaX,
            this.colunaFX,
            this.colunaE,
            this.colunaImpar,
            this.colunaPar});
            this.dataGridView1.Location = new System.Drawing.Point(45, 82);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(662, 295);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_2);
            // 
            // colunaI
            // 
            this.colunaI.HeaderText = "I";
            this.colunaI.Name = "colunaI";
            // 
            // colunaX
            // 
            this.colunaX.HeaderText = "X";
            this.colunaX.Name = "colunaX";
            // 
            // colunaFX
            // 
            this.colunaFX.HeaderText = "f(x)";
            this.colunaFX.Name = "colunaFX";
            // 
            // colunaE
            // 
            this.colunaE.HeaderText = "E";
            this.colunaE.Name = "colunaE";
            // 
            // colunaImpar
            // 
            this.colunaImpar.HeaderText = "Imp";
            this.colunaImpar.Name = "colunaImpar";
            // 
            // colunaPar
            // 
            this.colunaPar.HeaderText = "Par";
            this.colunaPar.Name = "colunaPar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(514, 496);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Resultado:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Info;
            this.panel2.Controls.Add(this.lblResultado);
            this.panel2.Location = new System.Drawing.Point(610, 488);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(126, 37);
            this.panel2.TabIndex = 3;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblResultado.ForeColor = System.Drawing.Color.Green;
            this.lblResultado.Location = new System.Drawing.Point(13, 2);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(40, 30);
            this.lblResultado.TabIndex = 0;
            this.lblResultado.Text = "???";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Info;
            this.panel3.Controls.Add(this.lblResultE);
            this.panel3.Location = new System.Drawing.Point(97, 435);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(96, 22);
            this.panel3.TabIndex = 5;
            // 
            // lblResultE
            // 
            this.lblResultE.AutoSize = true;
            this.lblResultE.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblResultE.Location = new System.Drawing.Point(14, 0);
            this.lblResultE.Name = "lblResultE";
            this.lblResultE.Size = new System.Drawing.Size(31, 21);
            this.lblResultE.TabIndex = 0;
            this.lblResultE.Text = "???";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(66, 436);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "E:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(122, 399);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 21);
            this.label5.TabIndex = 6;
            this.label5.Text = "∑";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Info;
            this.panel4.Controls.Add(this.lblResultImpar);
            this.panel4.Location = new System.Drawing.Point(97, 464);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(96, 22);
            this.panel4.TabIndex = 7;
            // 
            // lblResultImpar
            // 
            this.lblResultImpar.AutoSize = true;
            this.lblResultImpar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblResultImpar.Location = new System.Drawing.Point(14, 0);
            this.lblResultImpar.Name = "lblResultImpar";
            this.lblResultImpar.Size = new System.Drawing.Size(31, 21);
            this.lblResultImpar.TabIndex = 0;
            this.lblResultImpar.Text = "???";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(30, 464);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 21);
            this.label7.TabIndex = 6;
            this.label7.Text = "IMPAR:";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Info;
            this.panel5.Controls.Add(this.lblResultPar);
            this.panel5.Location = new System.Drawing.Point(97, 492);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(96, 22);
            this.panel5.TabIndex = 9;
            // 
            // lblResultPar
            // 
            this.lblResultPar.AutoSize = true;
            this.lblResultPar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblResultPar.Location = new System.Drawing.Point(14, 0);
            this.lblResultPar.Name = "lblResultPar";
            this.lblResultPar.Size = new System.Drawing.Size(31, 21);
            this.lblResultPar.TabIndex = 0;
            this.lblResultPar.Text = "???";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(44, 493);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 21);
            this.label9.TabIndex = 8;
            this.label9.Text = "PAR:";
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel6.Location = new System.Drawing.Point(23, 411);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(215, 112);
            this.panel6.TabIndex = 10;
            // 
            // TelaCalculoSimpsom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(748, 532);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel6);
            this.MaximizeBox = false;
            this.Name = "TelaCalculoSimpsom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculo de Simpsom";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaI;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaX;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaFX;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaE;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaImpar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaPar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblResultE;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblResultImpar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblResultPar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel6;
    }
}