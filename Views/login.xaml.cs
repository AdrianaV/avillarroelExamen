namespace avillarroelExamen.Views;

public partial class login : ContentPage
{

    string[,] usuariosContrase�as = {
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

        for (int i = 0; i < usuariosContrase�as.GetLength(0); i++)
        {
            if (usuariosContrase�as[i, 0] == user)
            {
                usuarioValido = true;
                if (usuariosContrase�as[i, 1] == pass)
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
            DisplayAlert("Error", "Usuario o contrase�a incorrecta", "Cerrar");
            txtUsuario.Text = "";
            txtContrasena.Text = "";
        }
    }
}