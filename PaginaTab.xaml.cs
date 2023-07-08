namespace TDMPW_412_1P_PR02;

public partial class PaginaTab : TabbedPage
{
	public PaginaTab()
	{
		InitializeComponent();
	}

    void kelvinBtn_Clicked(System.Object sender, System.EventArgs e)
    {
        Navigation.PushAsync(new PaginaKelvin());
    }

    void farenheitBtn_Clicked(System.Object sender, System.EventArgs e)
    {
        Navigation.PushAsync(new PaginaFarenheit());
    }

    void comenzarBtn_Clicked(System.Object sender, System.EventArgs e)
    {
        
    }
}
