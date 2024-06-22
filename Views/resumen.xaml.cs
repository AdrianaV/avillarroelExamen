namespace avillarroelExamen.Views;

public partial class resumen : ContentPage
{
	public resumen(string user, string nombre, string apellido, string edad, string fecha, string? pais, string? ciudad, string montoInicial, string pagoMensual, string montoTotal)
    {
        InitializeComponent();
        lblUsuario.Text = user;
        lblNombre.Text = nombre;
        lblApellido.Text = apellido;
        lblEdad.Text = edad;
        lblFecha.Text = fecha;
        lblPais.Text = pais;
        lblCiudad.Text = ciudad;
        lblMontoInicial.Text = montoInicial;
        lblPagoMensual.Text = pagoMensual;
        lblPagoTotal.Text = montoTotal;
    }
}