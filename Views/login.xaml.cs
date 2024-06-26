namespace avillarroelExamen.Views;

public partial class login : ContentPage
{

    string[,] usuariosContraseņas = {
            {"estudiante", "moviles"},
            {"uisrael", "2024"},
        };

    public login()
	{
		InitializeComponent();
	}

    private void btnIniciar_Clicked(object sender, EventArgs e)
    {
        string user = txtUsuario.Text;
        string pass = txtContrasena.Text;

        bool usuarioValido = false;
        bool contrasenaValida = false;

        for (int i = 0; i < usuariosContraseņas.GetLength(0); i++)
        {
            if (usuariosContraseņas[i, 0] == user)
            {
                usuarioValido = true;
                if (usuariosContraseņas[i, 1] == pass)
                {
                    contrasenaValida = true;
                    break;
                }
            }
        }

        if (usuarioValido && contrasenaValida)
        {
            Navigation.PushAsync(new registro(user));
        }
        else
        {
            DisplayAlert("Error", "Usuario o contraseņa incorrecta", "Cerrar");
            txtUsuario.Text = "";
            txtContrasena.Text = "";
        }
    }
}