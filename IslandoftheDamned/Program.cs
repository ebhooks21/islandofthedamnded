namespace IslandoftheDamned.console;

public class IslandoftheDamned
{
	public static void Main(string[] args)
	{
		PlayerCharacter player = new PlayerCharacter("Eric Hooks");

		Console.WriteLine("Hello, World!");
		Console.WriteLine(player.Name);
	}
}
