namespace Formulario
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            label1 = new Label();
            cbxCliente = new ComboBox();
            label2 = new Label();
            btnAlterar = new Button();
            btnNovo = new Button();
            label3 = new Label();
            txtCodigo = new TextBox();
            label4 = new Label();
            txtNome = new TextBox();
            label5 = new Label();
            txtCpf = new MaskedTextBox();
            dtpDataNascimento = new DateTimePicker();
            label6 = new Label();
            label7 = new Label();
            nudRendaMensal = new NumericUpDown();
            gbxEstadoCivil = new GroupBox();
            label8 = new Label();
            cbxNacionalidade = new ComboBox();
            mtbPlacaVeiculo = new MaskedTextBox();
            label9 = new Label();
            chkTemFilhos = new CheckBox();
            label10 = new Label();
            btnSalvar = new Button();
            btnCancelar = new Button();
            btnFechar = new Button();
            ((System.ComponentModel.ISupportInitialize)nudRendaMensal).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 0;
            label1.Text = "Clientes";
            // 
            // cbxCliente
            // 
            cbxCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxCliente.FormattingEnabled = true;
            cbxCliente.Location = new Point(12, 27);
            cbxCliente.Name = "cbxCliente";
            cbxCliente.Size = new Size(291, 23);
            cbxCliente.TabIndex = 0;
            // 
            // label2
            // 
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Location = new Point(11, 64);
            label2.Name = "label2";
            label2.Size = new Size(364, 1);
            label2.TabIndex = 2;
            // 
            // btnAlterar
            // 
            btnAlterar.Image = (Image)resources.GetObject("btnAlterar.Image");
            btnAlterar.Location = new Point(309, 27);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(27, 23);
            btnAlterar.TabIndex = 1;
            btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnNovo
            // 
            btnNovo.Image = (Image)resources.GetObject("btnNovo.Image");
            btnNovo.Location = new Point(345, 26);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(27, 24);
            btnNovo.TabIndex = 2;
            btnNovo.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 81);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 5;
            label3.Text = "Codigo";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(11, 99);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(61, 23);
            txtCodigo.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(82, 81);
            label4.Name = "label4";
            label4.Size = new Size(96, 15);
            label4.TabIndex = 7;
            label4.Text = "Nome Completo";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(84, 99);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(171, 23);
            txtNome.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(266, 81);
            label5.Name = "label5";
            label5.Size = new Size(28, 15);
            label5.TabIndex = 9;
            label5.Text = "CPF";
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(265, 99);
            txtCpf.Mask = "000,000,000-00";
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(107, 23);
            txtCpf.TabIndex = 5;
            txtCpf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // dtpDataNascimento
            // 
            dtpDataNascimento.Format = DateTimePickerFormat.Short;
            dtpDataNascimento.Location = new Point(12, 162);
            dtpDataNascimento.Name = "dtpDataNascimento";
            dtpDataNascimento.Size = new Size(111, 23);
            dtpDataNascimento.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(11, 144);
            label6.Name = "label6";
            label6.Size = new Size(112, 15);
            label6.TabIndex = 12;
            label6.Text = "Data de nascimento";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(135, 144);
            label7.Name = "label7";
            label7.Size = new Size(81, 15);
            label7.TabIndex = 13;
            label7.Text = "Renda Mensal";
            // 
            // nudRendaMensal
            // 
            nudRendaMensal.Increment = new decimal(new int[] { 500, 0, 0, 0 });
            nudRendaMensal.Location = new Point(135, 161);
            nudRendaMensal.Name = "nudRendaMensal";
            nudRendaMensal.Size = new Size(81, 23);
            nudRendaMensal.TabIndex = 7;
            // 
            // gbxEstadoCivil
            // 
            gbxEstadoCivil.Location = new Point(222, 144);
            gbxEstadoCivil.Name = "gbxEstadoCivil";
            gbxEstadoCivil.Size = new Size(150, 157);
            gbxEstadoCivil.TabIndex = 10;
            gbxEstadoCivil.TabStop = false;
            gbxEstadoCivil.Text = "Estado Civil";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 193);
            label8.Name = "label8";
            label8.Size = new Size(83, 15);
            label8.TabIndex = 16;
            label8.Text = "Nacionalidade";
            // 
            // cbxNacionalidade
            // 
            cbxNacionalidade.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxNacionalidade.FormattingEnabled = true;
            cbxNacionalidade.Location = new Point(12, 211);
            cbxNacionalidade.Name = "cbxNacionalidade";
            cbxNacionalidade.Size = new Size(111, 23);
            cbxNacionalidade.TabIndex = 8;
            // 
            // mtbPlacaVeiculo
            // 
            mtbPlacaVeiculo.Location = new Point(135, 211);
            mtbPlacaVeiculo.Mask = ">LLL|0>L|000";
            mtbPlacaVeiculo.Name = "mtbPlacaVeiculo";
            mtbPlacaVeiculo.Size = new Size(81, 23);
            mtbPlacaVeiculo.TabIndex = 9;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(135, 193);
            label9.Name = "label9";
            label9.Size = new Size(71, 15);
            label9.TabIndex = 19;
            label9.Text = "Placa do car";
            // 
            // chkTemFilhos
            // 
            chkTemFilhos.AutoSize = true;
            chkTemFilhos.Checked = true;
            chkTemFilhos.CheckState = CheckState.Indeterminate;
            chkTemFilhos.Location = new Point(11, 252);
            chkTemFilhos.Name = "chkTemFilhos";
            chkTemFilhos.Size = new Size(80, 19);
            chkTemFilhos.TabIndex = 11;
            chkTemFilhos.Text = "Tem filhos";
            chkTemFilhos.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.BorderStyle = BorderStyle.FixedSingle;
            label10.Location = new Point(12, 304);
            label10.Name = "label10";
            label10.Size = new Size(364, 1);
            label10.TabIndex = 21;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(11, 319);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 12;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(103, 319);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 13;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnFechar
            // 
            btnFechar.Location = new Point(297, 319);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(75, 23);
            btnFechar.TabIndex = 14;
            btnFechar.Text = "Fechar";
            btnFechar.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(388, 366);
            Controls.Add(btnFechar);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Controls.Add(label10);
            Controls.Add(chkTemFilhos);
            Controls.Add(label9);
            Controls.Add(mtbPlacaVeiculo);
            Controls.Add(cbxNacionalidade);
            Controls.Add(label8);
            Controls.Add(gbxEstadoCivil);
            Controls.Add(nudRendaMensal);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(dtpDataNascimento);
            Controls.Add(txtCpf);
            Controls.Add(label5);
            Controls.Add(txtNome);
            Controls.Add(label4);
            Controls.Add(txtCodigo);
            Controls.Add(label3);
            Controls.Add(btnNovo);
            Controls.Add(btnAlterar);
            Controls.Add(label2);
            Controls.Add(cbxCliente);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de clientes";
            ((System.ComponentModel.ISupportInitialize)nudRendaMensal).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cbxCliente;
        private Label label2;
        private Button btnAlterar;
        private Button btnNovo;
        private Label label3;
        private TextBox txtCodigo;
        private Label label4;
        private TextBox txtNome;
        private Label label5;
        private MaskedTextBox txtCpf;
        private DateTimePicker dtpDataNascimento;
        private Label label6;
        private Label label7;
        private NumericUpDown nudRendaMensal;
        private GroupBox gbxEstadoCivil;
        private Label label8;
        private ComboBox cbxNacionalidade;
        private MaskedTextBox mtbPlacaVeiculo;
        private Label label9;
        private CheckBox chkTemFilhos;
        private Label label10;
        private Button btnSalvar;
        private Button btnCancelar;
        private Button btnFechar;
    }
}