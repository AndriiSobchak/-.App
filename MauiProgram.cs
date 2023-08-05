using Microsoft.Extensions.Logging;

namespace zhyha;

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
			});

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
enum Direction
{
	North = 1,
	South = 2,
	East = 4,
	West = 8
}
static void Main()
{
	Direction dir = Direction.North | Direction.East;
	Console.WriteLine(dir);
}