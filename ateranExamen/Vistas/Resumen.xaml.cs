using static System.Runtime.InteropServices.JavaScript.JSType;
using Windows.System;
using Windows.Devices.Lights.Effects;
namespace ateranExamen.Vistas;
public partial class Resumen : ContentPage
{
    public Resumen(string user, string nombre,  string apeliido,string edad, string fecha, string pais, string cuidad, string PI, string PM, string PT)
    {
		InitializeComponent();

        lblUser.Text =  user;
        lblNombre.Text = nombre;
        lblApellido.Text = apeliido;
        lblEdad.Text = edad;
        lblFecha.Text = fecha;
        lblPais.Text = pais;
        lblCiudad.Text = cuidad;
        lblPI.Text = PI;
        lblPM.Text = PM;
        lblPT.Text = PT;
    }
}