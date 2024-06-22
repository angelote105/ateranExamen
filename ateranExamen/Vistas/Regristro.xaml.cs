namespace ateranExamen.Vistas;

public partial class Regristro : ContentPage
{
	public Regristro(string usuario)
	{
        InitializeComponent();
        lblNombre.Text = "Usuario Conectado : " + usuario;
    }

    private void btnMinicial_Clicked(object sender, EventArgs e)
    {

       
            double PI = double.Parse(txtMinicial.Text);

        if (PI > 0 && PI < 1501)
        {
            double cuotaI = (1500 - PI) / 4;

            if (cuotaI > 0) {
                double CM = 1500 * 0.04;

                double vC = cuotaI + CM;

                txtPagoMensual.Text = vC.ToString("F2");
            }
            else
            {
                var vA = "0";
                txtPagoMensual.Text = vA;
            }

            

        }
        else
        {
            DisplayAlert("Alerta", "Monto no permitido", "cerrar");
        }

    }

    private void btn_resumen_Clicked(object sender, EventArgs e)
    {


        string user = lblNombre.Text;

        string nombre  = txtNombre.Text;
        string apeliido = txtApellido.Text;
        string edad = txtEdad.Text;
        string fecha = dpFecha.Date.ToString();

        var pais = pkPaises.Items[pkPaises.SelectedIndex];
        var cuidad = pkCiudades.Items[pkCiudades.SelectedIndex];

        double PI = double.Parse(txtMinicial.Text);
        double PM = double.Parse(txtPagoMensual.Text);

        if (PI > 0 && PM >= 0)
        {

            double PT = PI + (PM * 4);

            DisplayAlert("Autenticacion", "Resumen Generado", "ok");
            Navigation.PushAsync(new Resumen(user, nombre, apeliido, edad, fecha, pais, cuidad, PI.ToString(), PM.ToString(), PT.ToString()));

        }
        else {
            DisplayAlert("Autenticacion", "Ingrese los datos", "ok");
        }


    }
}