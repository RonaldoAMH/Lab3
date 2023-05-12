using Lab3.BL;

namespace Lab3.UI
{
    public partial class Form1 : Form
    {
        public Metodos prenda;
        public int count;
        public Form1()
        {
            count = 1;
            prenda = new Metodos();
            InitializeComponent();
        }

        private void botonRegistrar_Click(object sender, EventArgs e)
        {
            
            dataInfo.DataSource = "";
            string nombre = nombreTxt.Text;
            string talla = tallaTxt.Text;
            string marca = marcaTxt.Text;
            string descri = descriTxt.Text;
            prenda.SeRegistraPrenda(count,nombre, marca, talla, descri);
            dataInfo.DataSource = prenda.SeMuestraListado();
            nombreTxt.Text = "";
            marcaTxt.Text = "";
            tallaTxt.Text = "";
            descriTxt.Text = "";
            count++;

        }

        private void botonBuscar_Click(object sender, EventArgs e)
        {
            
            int idX = int.Parse(idTxt.Text);
            dataInfo.DataSource = prenda.SeMuestranDetalles(idX);
            idTxt.Text = "";
        }

        private void botonMostrar_Click(object sender, EventArgs e)
        {
            dataInfo.DataSource = "";
            dataInfo.DataSource = prenda.SeMuestraListado();
        }
    }
}