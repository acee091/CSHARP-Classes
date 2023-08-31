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
            cx.altura = Convert.ToDouble(txtAltura.Text);
            cx.largura = Convert.ToDouble(txtLargura.Text);
            cx.profundidade = Convert.ToDouble(txtProfundidade.Text);

            //Invocar metódo Volume() para calcular o retornar o volume da caixa
            double volume = cx.Volume();

            //Montar resposta e exibir resultado no label
            string res = "O volume da caixa é: " + volume.ToString() + "cm³";
            lblVolume.Text = res;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }

    class Caixa
    {
        public double largura;
        public double altura;
        public double profundidade;
        public double Volume()
        {
            double vol = altura * largura * profundidade;
            return vol;
        }
    }
}
