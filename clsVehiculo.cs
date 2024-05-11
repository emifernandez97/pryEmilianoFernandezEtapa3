using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pryEmilianoFernandezEtapa2
{
    internal class clsVehiculo
    {
        //Propiedades
        public string nombre { get; set; }
        public string tipo { get; set; }
        public Image Imagen { get; set; }

        //Constructor


        //Metodos

        public void crearVehiculo(PictureBox Vehiculo) //pct del formulario
        {

            PictureBox ImagenVehiculo = new PictureBox(); //instancio en memora imagen
            Random rnd = new Random(); //creo random
            switch (rnd.Next(1,4))  //para cada caso un random
            {
                case 1:
                    Imagen = pryEmilianoFernandezEtapa3.Properties.Resources.Rayo_Mckuin;
                    break;
                case 2:
                    Imagen = pryEmilianoFernandezEtapa3.Properties.Resources.CAPTAIN_removebg_preview;
                    break;
                case 3:
                    Imagen = pryEmilianoFernandezEtapa3.Properties.Resources.jay_jay_removebg_preview;
                    break;
            }

            ImagenVehiculo.Image = Imagen;
            ImagenVehiculo.SizeMode = PictureBoxSizeMode.StretchImage;
            ImagenVehiculo.Location = Vehiculo.Location;
            ImagenVehiculo.Size = Vehiculo.Size;
            Vehiculo.Parent.Controls.Add(ImagenVehiculo);

            ImagenVehiculo.BringToFront();          
        }

        //cargar una imagen en una PictureBox por boton sin random
        public void CrearVehiculoABA(PictureBox vehiculoPictureBox, Image imagen)
        {
            // Crear una nueva PictureBox para la imagen del vehículo
            PictureBox imagenVehiculo = new PictureBox();

            // Asignar la imagen a la PictureBox del vehículo
            imagenVehiculo.Image = imagen;

            // Establecer el modo de ajuste de la imagen
            imagenVehiculo.SizeMode = PictureBoxSizeMode.StretchImage;

            // Establecer la ubicación y el tamaño de la PictureBox del vehículo
            imagenVehiculo.Location = vehiculoPictureBox.Location;
            imagenVehiculo.Size = vehiculoPictureBox.Size;

            // Agregar la PictureBox del vehículo al formulario
            vehiculoPictureBox.Parent.Controls.Add(imagenVehiculo);

            // Traer la PictureBox del vehículo al frente
            imagenVehiculo.BringToFront();
        }
    }
}
