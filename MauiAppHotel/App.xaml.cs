using MauiAppHotel.Models;

namespace MauiAppHotel
{
    public partial class App : Application
    {
        public List<Quarto> lista_quartos = new List<Quarto>
        {
            new Quarto()
            {
                Descricao = "Aurora Hall",
                ValorDiariaAdulto = 110.0,
            },
            new Quarto()
            {
                Descricao = "Casa Harmonia",
                ValorDiariaAdulto = 80.0,
            },
            new Quarto()
            {
                Descricao = "Espaço Versatile",
                ValorDiariaAdulto = 50,
            },
            new Quarto()
            {
                Descricao = "Salão Estelar",
                ValorDiariaAdulto = 25,
            }
        };

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Views.ContratacaoHospedagem());
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = base.CreateWindow(activationState);

            window.Width = 400;
            window.Height = 600;

            return window;
        }
    }
}
