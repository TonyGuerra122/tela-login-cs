namespace TesteLoginGUI {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void sendData_Click(object sender, EventArgs e) {
            LoginControl login = new LoginControl("Anthony", email.Text, password.Text);
            if(login.GetLogado() == true) {
                MessageBox.Show("Usuário "+ login.GetName() + " se conectou", "Sucesso", MessageBoxButtons.OK ,MessageBoxIcon.Information);
            }
            else {
                MessageBox.Show("E-mail ou Senha incorretos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}