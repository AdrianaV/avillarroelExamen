namespace avillarroelExamen.Views;

public partial class registro : ContentPage
{
	public registro(string user)
	{
		InitializeComponent();

        DisplayAlert("Bienvenido", user, "Cerrar");
        lblUsuario.Text = "Usuario conectado " + user;
    }

    private void btnCalcular_Clicked(object sender, EventArgs e)
    {
        if (!double.TryParse(txtMontoInicial.Text, out double montoInicial))
        {
            DisplayAlert("Error", "Por favor ingrese un monto inicial válido.", "OK");
            return;
        }
        if (montoInicial > 1500)
        {
            DisplayAlert("Error", "El monto inicial no puede ser mayor a 1500.", "OK");
        }
        else if (montoInicial < 0)
        {
            DisplayAlert("Error", "El monto inicial no puede ser negativo.", "OK");
        }
        else
        {

            double montoRestante = 1500 - montoInicial;
            double montoPorCuota = montoRestante / 4;
            double interese = 1500 * 0.04;
            double montoConInteres = montoPorCuota + interese;
            double montoTotal = montoConInteres + montoInicial;

            txtPagoMensual.Text = montoConInteres.ToString("C");
        }
    }

    private void btnResumen_Clicked(object sender, EventArgs e)
    {
        string user = lblUsuario.Text;
        string nombre = txtNombre.Text;
        string apellido = txtApellido.Text;
        string edad = txtEdad.Text;
        string fecha = datePicker.Date.ToString("dd/MM/yyyy");
        string pais = pickerPais.SelectedItem?.ToString();
        string ciudad = pickerCiudad.SelectedItem?.ToString();
        string montoInicial = txtMontoInicial.Text;
        string pagoMensual = txtPagoMensual.Text;
        string montoTotal = txtmontoTotal.Text;



        resumen vistaResumen = new resumen(user, nombre, apellido, edad, fecha, pais, ciudad, montoInicial, pagoMensual, montoTotal);
        Navigation.PushAsync(vistaResumen);
    }
}