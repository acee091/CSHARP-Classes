namespace Classes___Aula01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculaVolume_Click(object sender, EventArgs e)
        {
            //Instanciação da classe: Criar objeto
    //nomeClasse nomeObjeto = new MetodoCOnstrutor() -- o metodoconstrutor tem que ter o mesmo nome da classe
            Caixa cx = new Caixa(); //aloca na memoria 

            //Gravar valor do lado da caixa no atributo 'lado' do objeto
            cx.lado = Convert.ToDouble(txtLado.Text);

            //Invocar metódo Volume() para calcular o retornar o volume da caixa
            double volume = cx.Volume();

            //Montar resposta e exibir resultado no label
            string res = "O volume da caixa é: " + volume.ToString();
            lblVolume.Text = res;
        }
    }

    class Caixa
    {
        public double lado;
        public double Volume()
        {
            return lado * lado * lado;
        }
    }
}