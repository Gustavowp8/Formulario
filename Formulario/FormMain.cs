namespace Formulario
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void Informar(string mensagem)
        {
            MessageBox.Show(mensagem, "Informa��o", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private bool Confirmar(string pergunta)
        {
            return MessageBox.Show(pergunta, "Confirma��o", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        } /*7:22*/

    }
}