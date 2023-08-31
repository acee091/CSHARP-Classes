using System;

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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculaArea_Click(object sender, EventArgs e)
        {
            Retangulo rt = new Retangulo();
            Triangulo tri = new Triangulo();

            rt.baseRet = Convert.ToDouble(txtBaseRetangulo.Text);
            rt.alturaRet = Convert.ToDouble(txtAltRetangulo.Text);

            tri.alturaTrian = Convert.ToDouble(txtAltTriangulo.Text);
            tri.baseTrian = Convert.ToDouble(txtBaseTriangulo.Text);

            double AreaRet = rt.AreaRet();

            double AreaTri = tri.AreaTrian();

            string AreaRes = ("A área do retângulo é de " + AreaRet.ToString()+ "cm³\n" + 
            "A área do triângulo é de " + AreaTri.ToString() + "cm³");
            lblAreaRes.Text = AreaRes;
        }

        private void lblAreaRes_Click(object sender, EventArgs e)
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

    class Retangulo
    {
        public double baseRet;
        public double alturaRet;
        public double AreaRet()
        {
            double volret = baseRet* alturaRet;
            return volret;
        }
    }
    class Triangulo
    {
        public double baseTrian;
        public double alturaTrian;
        public double AreaTrian()
        {
            double voltri = (baseTrian * alturaTrian) / 2;
            return voltri;
        }
    }
}
