namespace ateranExamen.Vistas;

public partial class Login : ContentPage
{
	public Login()
	{
		InitializeComponent();
	}

    private void btn_ingresar_Clicked(object sender, EventArgs e)
    {
        string[,] userArray = new string[,]
            {
                {"estudiante", "moviles"},
                {"uisrael", "2024"}
            };

        string usuario = txtUsuario.Text;
        string clave = txtContrasena.Text;

        bool autenticacion = false;

        // Recorre la matriz para verificar la autenticación
        for (int i = 0; i < userArray.GetLength(0); i++)
        {
            string storedUser = userArray[i, 0];
            string storedClave = userArray[i, 1];

            if (usuario == storedUser && clave == storedClave)
            {
                autenticacion = true;
                break;
            }
        }

        if (autenticacion)
        {
            DisplayAlert("Autenticacion", "Inicio de sesión correcto", "ok");
            Navigation.PushAsync(new Regristro(txtUsuario.Text));
        }
        else
        {
            DisplayAlert("Alerta", "Error en el usuario o contraseña", "cerrar");
        }
    }
}