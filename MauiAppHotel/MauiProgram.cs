using Microsoft.Extensions.Logging;

namespace MauiAppHotel
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                    fonts.AddFont("Kalam-Bold.ttf", "KalamBold");
                    fonts.AddFont("Kalam-Light.ttf", "KalamLight");
                    fonts.AddFont("Kalam-Regular.ttf", "Kalam");
                    fonts.AddFont("AirbnbCereal_W_Bd.otf", "CerealBd");
                    fonts.AddFont("AirbnbCereal_W_Bk.otf", "CerealBk");
                    fonts.AddFont("AirbnbCereal_W_Blk.otf", "CerealBlk");
                    fonts.AddFont("AirbnbCereal_W_Lt.otf", "CerealLt");
                    fonts.AddFont("AirbnbCereal_W_Md.otf", "CerealMd");
                    fonts.AddFont("AirbnbCereal_W_XBd.otf", "CerealXBd");

                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
