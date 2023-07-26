namespace aula013atividade
{
    public partial class Form1 : Form
    {
        List<Pessoa> pessoas = new List<Pessoa>();
        
        Utilidade utilidades = new Utilidade();

        public Form1()
        {
            InitializeComponent();
        }
        void adicionaproduto()
        {
            
        }
        public void atualizatela()
        {
            for (int i = 0; i < pessoas.Count; i++)
            {
                listanomes.Items.Add(pessoas[i].name);
                listanomes.Items.Add(pessoas[i].cidade);
                
                listanomes.Items.Add(pessoas[i].rua);

            }
            pessoas.Clear();
        }

        private void BTNsalvar_Click(object sender, EventArgs e)
        {
            string nome = txtnome.Text;
            string cidade = txtcidade.Text;
            string rua = txtrua.Text;
            int idade = int.Parse(txtcidade.Text);

            Pessoa p = new Pessoa(nome, idade, cidade, rua);
            pessoas.Add(p);
            atualizatela();
        }
    }
}