Application.Init();

try
{
	Application.Run(new GameView());
}
finally
{
	Application.Shutdown();
}