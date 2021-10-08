
namespace Aula19Projetofinal_6320048
{
    partial class CadastroQuartos
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
            this.btnCadastrarQuarto = new System.Windows.Forms.Button();
            this.txtNQuarto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTipoQuarto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rtxtDescricao = new System.Windows.Forms.RichTextBox();
            this.btnAtualizarQuarto = new System.Windows.Forms.Button();
            this.btnExcluirQuarto = new System.Windows.Forms.Button();
            this.btnVoltarQuarto = new System.Windows.Forms.Button();
            this.dtaGridQuarto = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtaGridQuarto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCadastrarQuarto
            // 
            this.btnCadastrarQuarto.Location = new System.Drawing.Point(12, 312);
            this.btnCadastrarQuarto.Name = "btnCadastrarQuarto";
            this.btnCadastrarQuarto.Size = new System.Drawing.Size(234, 65);
            this.btnCadastrarQuarto.TabIndex = 0;
            this.btnCadastrarQuarto.Text = "Cadastrar";
            this.btnCadastrarQuarto.UseVisualStyleBackColor = true;
            this.btnCadastrarQuarto.Click += new System.EventHandler(this.btnCadastrarQuarto_Click);
            // 
            // txtNQuarto
            // 
            this.txtNQuarto.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNQuarto.Location = new System.Drawing.Point(160, 44);
            this.txtNQuarto.Name = "txtNQuarto";
            this.txtNQuarto.Size = new System.Drawing.Size(47, 34);
            this.txtNQuarto.TabIndex = 4;
            this.txtNQuarto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNQuarto_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "N° do quarto: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(133, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Matheus Jhonatan dos Santos - 6320048";
            // 
            // txtTipoQuarto
            // 
            this.txtTipoQuarto.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipoQuarto.Location = new System.Drawing.Point(392, 44);
            this.txtTipoQuarto.Name = "txtTipoQuarto";
            this.txtTipoQuarto.Size = new System.Drawing.Size(129, 34);
            this.txtTipoQuarto.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(208, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tipo de quarto: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 29);
            this.label4.TabIndex = 8;
            this.label4.Text = "Descrição:";
            // 
            // rtxtDescricao
            // 
            this.rtxtDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtDescricao.Location = new System.Drawing.Point(145, 99);
            this.rtxtDescricao.Name = "rtxtDescricao";
            this.rtxtDescricao.Size = new System.Drawing.Size(369, 106);
            this.rtxtDescricao.TabIndex = 10;
            this.rtxtDescricao.Text = "";
            // 
            // btnAtualizarQuarto
            // 
            this.btnAtualizarQuarto.Location = new System.Drawing.Point(282, 226);
            this.btnAtualizarQuarto.Name = "btnAtualizarQuarto";
            this.btnAtualizarQuarto.Size = new System.Drawing.Size(239, 65);
            this.btnAtualizarQuarto.TabIndex = 11;
            this.btnAtualizarQuarto.Text = "Atualizar";
            this.btnAtualizarQuarto.UseVisualStyleBackColor = true;
            this.btnAtualizarQuarto.Click += new System.EventHandler(this.btnAtualizarQuarto_Click);
            // 
            // btnExcluirQuarto
            // 
            this.btnExcluirQuarto.Location = new System.Drawing.Point(12, 226);
            this.btnExcluirQuarto.Name = "btnExcluirQuarto";
            this.btnExcluirQuarto.Size = new System.Drawing.Size(234, 65);
            this.btnExcluirQuarto.TabIndex = 13;
            this.btnExcluirQuarto.Text = "Excluir registro";
            this.btnExcluirQuarto.UseVisualStyleBackColor = true;
            this.btnExcluirQuarto.Click += new System.EventHandler(this.btnExcluirQuarto_Click);
            // 
            // btnVoltarQuarto
            // 
            this.btnVoltarQuarto.Location = new System.Drawing.Point(282, 312);
            this.btnVoltarQuarto.Name = "btnVoltarQuarto";
            this.btnVoltarQuarto.Size = new System.Drawing.Size(239, 65);
            this.btnVoltarQuarto.TabIndex = 14;
            this.btnVoltarQuarto.Text = "Voltar";
            this.btnVoltarQuarto.UseVisualStyleBackColor = true;
            this.btnVoltarQuarto.Click += new System.EventHandler(this.btnVoltarQuarto_Click);
            // 
            // dtaGridQuarto
            // 
            this.dtaGridQuarto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtaGridQuarto.Location = new System.Drawing.Point(12, 406);
            this.dtaGridQuarto.Name = "dtaGridQuarto";
            this.dtaGridQuarto.RowHeadersWidth = 51;
            this.dtaGridQuarto.RowTemplate.Height = 24;
            this.dtaGridQuarto.Size = new System.Drawing.Size(509, 150);
            this.dtaGridQuarto.TabIndex = 15;
            this.dtaGridQuarto.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtaGridQuarto_CellDoubleClick);
            // 
            // CadastroQuartos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 567);
            this.Controls.Add(this.dtaGridQuarto);
            this.Controls.Add(this.btnVoltarQuarto);
            this.Controls.Add(this.btnExcluirQuarto);
            this.Controls.Add(this.btnAtualizarQuarto);
            this.Controls.Add(this.rtxtDescricao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTipoQuarto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNQuarto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCadastrarQuarto);
            this.Name = "CadastroQuartos";
            this.Text = "Cadastro quartos - POUSADA DORME AGORA";
            this.Load += new System.EventHandler(this.CadastroQuartos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtaGridQuarto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrarQuarto;
        private System.Windows.Forms.TextBox txtNQuarto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTipoQuarto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox rtxtDescricao;
        private System.Windows.Forms.Button btnAtualizarQuarto;
        private System.Windows.Forms.Button btnExcluirQuarto;
        private System.Windows.Forms.Button btnVoltarQuarto;
        private System.Windows.Forms.DataGridView dtaGridQuarto;
    }
}