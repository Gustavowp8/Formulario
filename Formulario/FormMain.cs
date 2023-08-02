namespace Formulario
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            AtualizarComboBoxPaises();
            CriarControleEstadosCivis();
            DesabilitarCampos();
        }

        private void Informar(string mensagem)
        {
            MessageBox.Show(mensagem, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private bool Confirmar(string pergunta)
        {
            return MessageBox.Show(pergunta, "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        }

        private void AtualizarComboBoxPaises()
        {
            cbxNacionalidade.DataSource = Pais.Listagem;
            cbxNacionalidade.DisplayMember = "";
            cbxNacionalidade.DisplayMember = "Nome";
            cbxNacionalidade.ValueMember = "Sigla";
            cbxNacionalidade.SelectedIndex = -1;
        }

        private void AtualizarComboBoxClientes()
        {
            cbxCliente.DataSource = Cliente.Listagem;
            cbxCliente.DisplayMember = "";
            cbxCliente.DisplayMember = "Nome";
            cbxCliente.ValueMember = "Codigo";
        }

        private void CorrigirTabStop(object sender, EventArgs e)
        {
            ((RadioButton)sender).TabStop = true;
        }

        private void CriarControleEstadosCivis()
        {
            int iRB = 0;
            var estadosCivis = Enum.GetValues(typeof(EnumEstadoCivil));
            foreach (var ec in estadosCivis)
            {
                RadioButton rb = new RadioButton()
                {
                    Text = ec.ToString(),
                    Location = new Point(10, (iRB + 1) * 27),
                    Width = 85,
                    TabStop = true,
                    TabIndex = iRB,
                    Tag = ec
                };
                rb.TabStopChanged += new EventHandler(CorrigirTabStop);
                gbxEstadoCivil.Controls.Add(rb);
                iRB++;
            }
        }

        private EnumEstadoCivil? LerEstadoCivil()
        {
            foreach (var control in gbxEstadoCivil.Controls)
            {
                RadioButton rb = control as RadioButton;
                if (rb.Checked)
                {
                    return (EnumEstadoCivil)(rb.Tag);
                }
            }
            return null;
        }

        private void MarcarEstadoCivil(EnumEstadoCivil estadoCivil)
        {
            foreach (var control in gbxEstadoCivil.Controls)
            {
                RadioButton rb = control as RadioButton;
                if ((EnumEstadoCivil)(rb.Tag) == estadoCivil)
                    rb.Checked = true;
            }
        }

        private void LimparCampos()
        {
            txtCodigo.Clear();
            txtNome.Clear();
            txtCpf.Clear();

            dtpDataNascimento.Value = DateTime.Now.Date;
            nudRendaMensal.Value = 0;

            foreach (var control in gbxEstadoCivil.Controls)
            {
                (control as RadioButton).Checked = false;
            }

            cbxNacionalidade.SelectedIndex = -1;
            mtbPlacaVeiculo.Clear();
            chkTemFilhos.CheckState = CheckState.Indeterminate;
        }

        private void PreencherCamposComCliente(Cliente cliente)
        {
            txtCodigo.Text = cliente.Codigo.ToString();
            txtNome.Text = cliente.Nome;
            txtCpf.Text = cliente.CPF.ToString();
            dtpDataNascimento.Value = cliente.DataNascimento;
            nudRendaMensal.Value = cliente.RendaMensal;
            MarcarEstadoCivil(cliente.EstadoCivil);
            cbxNacionalidade.SelectedValue = cliente.Nacionalidade;
            mtbPlacaVeiculo.Text = cliente.PlacaVeiculo;
            chkTemFilhos.Checked = cliente.TemFilhos;
        }

        private void PreencherClienteComCampos(Cliente cliente)
        {
            cliente.Nome = txtNome.Text;
            cliente.CPF = Convert.ToInt64(txtCpf.Text);
            cliente.DataNascimento = dtpDataNascimento.Value.Date;
            cliente.RendaMensal = nudRendaMensal.Value;
            cliente.EstadoCivil = LerEstadoCivil().Value;
            cliente.TemFilhos = chkTemFilhos.Checked;
            cliente.Nacionalidade = cbxNacionalidade.SelectedValue.ToString();
            cliente.PlacaVeiculo = mtbPlacaVeiculo.Text;
        }

        private bool PrencheuTodosOsCampos()
        {
            if (String.IsNullOrWhiteSpace(txtNome.Text)) return false;
            if (String.IsNullOrWhiteSpace(txtCpf.Text)) return false;
            if (dtpDataNascimento.Value.Date == DateTime.Now.Date) return false;
            if (nudRendaMensal.Value == 0) return false;
            if (LerEstadoCivil() == null) return false;
            if (cbxNacionalidade.SelectedIndex < 0) return false;
            if (String.IsNullOrWhiteSpace(mtbPlacaVeiculo.Text)) return false;
            if (chkTemFilhos.CheckState == CheckState.Indeterminate) return false;

            return true;
        }

        private bool PossuiValoresNaoSalvos()
        {
            if (cbxCliente.SelectedIndex < 0)
            {
                if (!String.IsNullOrWhiteSpace(txtNome.Text)) return true;
                if (!String.IsNullOrWhiteSpace(txtCpf.Text)) return true;
                if (dtpDataNascimento.Value.Date != DateTime.Now.Date) return true;
                if (nudRendaMensal.Value > 0) return true;
                if (LerEstadoCivil() != null) return true;
                if (cbxNacionalidade.SelectedIndex >= 0) return true;
                if (!String.IsNullOrWhiteSpace(mtbPlacaVeiculo.Text)) return true;
                if (chkTemFilhos.CheckState != CheckState.Indeterminate) return true;
            }
            else
            {
                Cliente cliente = cbxCliente.SelectedItem as Cliente;
                if (txtNome.Text.Trim() != cliente.Nome) return true;
                if (txtCpf.Text != cliente.CPF.ToString()) return true;
                if (dtpDataNascimento.Value.Date != cliente.DataNascimento) return true;
                if (nudRendaMensal.Value != cliente.RendaMensal) return true;
                if (LerEstadoCivil() != cliente.EstadoCivil) return true;
                if (cbxNacionalidade.SelectedValue.ToString() != cliente.Nacionalidade) return true;
                if (mtbPlacaVeiculo.Text != cliente.PlacaVeiculo) return true;
                if (chkTemFilhos.Checked != cliente.TemFilhos) return true;
            }
            return false;
        }

        private void AlterarEstadosCampos(bool estado)
        {
            txtNome.Enabled = estado;
            txtCpf.Enabled = estado;
            dtpDataNascimento.Enabled = estado;
            nudRendaMensal.Enabled = estado;
            gbxEstadoCivil.Enabled = estado;
            cbxNacionalidade.Enabled = estado;
            mtbPlacaVeiculo.Enabled = estado;
            chkTemFilhos.Enabled = estado;
            btnSalvar.Enabled = estado;
            btnCancelar.Enabled = estado;
        }

        private void HabilitarCampos()
        {
            AlterarEstadosCampos(true);
        }
        private void DesabilitarCampos()
        {
            AlterarEstadosCampos(false);
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            cbxCliente.SelectedIndex = -1;
            LimparCampos();
            HabilitarCampos();
            txtNome.Select();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (PrencheuTodosOsCampos())
            {
                Cliente cliente = cbxCliente.SelectedIndex < 0 ? new Cliente() : cbxCliente.SelectedItem as Cliente;

                PreencherClienteComCampos(cliente);
                DesabilitarCampos();

                if (cbxCliente.SelectedIndex < 0)
                {
                    cliente = Cliente.Inserir(cliente);
                    AtualizarComboBoxClientes();
                    Informar("Cliente cadastrado com sucesso!");
                }
                else
                {
                    AtualizarComboBoxClientes();
                    Informar("Cliente alterado com sucesso!");
                }
            }
            else
            {
                Informar("É preciso precher todos os campos. Salvamento cancelado!");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (PossuiValoresNaoSalvos())
            {
                if (Confirmar("Há alterações não salvas. Deseja realmente cancelar ?"))
                {
                    cbxCliente.SelectedIndex = -1;
                    LimparCampos();
                    cbxCliente.Select();
                    DesabilitarCampos();
                }
            }
            else
            {
                cbxCliente.SelectedIndex = -1;
                LimparCampos();
                cbxCliente.Select();
                DesabilitarCampos();
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (PossuiValoresNaoSalvos())
            {
                e.Cancel = !Confirmar("Há alterações não salvas. Deseja realmente sair ?");
            }
            else
            {
                e.Cancel = !Confirmar("Deseja realmente sair ?");
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
            PreencherCamposComCliente(cbxCliente.SelectedItem as Cliente);
            txtNome.Select();
        }

        private void cbxCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxCliente.SelectedIndex < 0)
            {
                btnAlterar.Enabled = false;
            }
            else
            {
                PreencherCamposComCliente(cbxCliente.SelectedItem as Cliente);
                btnAlterar.Enabled = true;
            }
        }
    }
}