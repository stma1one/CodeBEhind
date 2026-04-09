namespace CodeBEhind
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
            InitializeComponent();
        }

		private void Button_Clicked(object sender, EventArgs e)
		{
            Button btn = (Button)sender;
            if (btn == sababa_btn)
            {
                achla_btn.Text = "סבבה";
                title_lbl.TextColor = Colors.Blue;

            }

            else if (btn == achla_btn)
                sababa_btn.Text = "אחלה";
        }

		
	}
}
