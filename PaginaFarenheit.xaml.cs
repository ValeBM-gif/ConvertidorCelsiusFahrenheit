namespace TDMPW_412_1P_PR02;

public partial class PaginaFarenheit : ContentPage
{
	public PaginaFarenheit()
	{
		InitializeComponent();
		
	}

    void kelvinToFarenheitBtn_Clicked(System.Object sender, System.EventArgs e)
    {
        double gradosKelvin = 0;
		double gradosFarenheit = 0;

        if (this.farenheitEntry.Text != null) {
			gradosKelvin = double.Parse(this.farenheitEntry.Text);
			gradosFarenheit = Math.Round((1.8 * (gradosKelvin) + 32),2);
			this.lblF.Text = gradosFarenheit.ToString();
		}
		else
		{
			this.lblF.Text = "Ingresa un valor válido";
		}
    }
}
