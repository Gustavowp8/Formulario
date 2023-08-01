namespace Formulario
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            AtualizarComboBoxPaises();
            CriarControleEstadosCivis();
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

    }
}