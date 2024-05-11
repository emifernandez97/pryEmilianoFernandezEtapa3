using System.Windows.Forms;

namespace pryEmilianoFernandezEtapa2
{
    public partial class FrmCargaVehiculo : Form
    {
        clsVehiculo objetoVehiculo;

        public FrmCargaVehiculo()
        {
            InitializeComponent();
            objetoVehiculo = new clsVehiculo();
        }

        private void BtnCargar_Click(object sender, EventArgs e)
        {
            lblNombre.Text = "";
            lblTipo.Text = "";

            objetoVehiculo.CrearVehiculoABA(PctVehiculo, pryEmilianoFernandezEtapa3.Properties.Resources.Rayo_Mckuin);

            lblNombre.Text = "Rayo McQueen";
            lblTipo.Text = "Auto";
        }

        private void btnBarco_Click(object sender, EventArgs e)
        {
            lblNombre.Text = "";
            lblTipo.Text = "";

            objetoVehiculo.CrearVehiculoABA(PctVehiculo, pryEmilianoFernandezEtapa3.Properties.Resources.CAPTAIN_removebg_preview);

            lblNombre.Text = "El Capitán";
            lblTipo.Text = "Barco";
        }

        private void btnAvion_Click(object sender, EventArgs e)
        {
            lblNombre.Text = "";
            lblTipo.Text = "";

            objetoVehiculo.CrearVehiculoABA(PctVehiculo, pryEmilianoFernandezEtapa3.Properties.Resources.jay_jay_removebg_preview);

            lblNombre.Text = "Jay Jay";
            lblTipo.Text = "Avión";
        }
    }
}
