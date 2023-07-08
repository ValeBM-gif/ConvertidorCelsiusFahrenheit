namespace TDMPW_412_1P_PR02;

public partial class PaginaKelvin : ContentPage
{
	public PaginaKelvin()
	{
		InitializeComponent();
	}

    void farenheitToKelvinBtn_Clicked(System.Object sender, System.EventArgs e)
    {
        double gradosKelvin = 0;
        double gradosFarenheit = 0;

        if (this.kelvinEntry.Text != null)
        {
            gradosFarenheit = double.Parse(this.kelvinEntry.Text);
            //this.lblK.Text = gradosFarenheit.ToString();
            gradosKelvin = Math.Round((gradosFarenheit + 273.15),2);
            this.lblK.Text = gradosKelvin.ToString();
        }
        else
        {
            this.lblK.Text = "Ingresa un valor válido";
        }
    }
}
