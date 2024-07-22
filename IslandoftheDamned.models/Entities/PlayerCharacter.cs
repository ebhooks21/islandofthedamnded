namespace IslandoftheDamned.models.Entities;

public class PlayerCharacter : IBaseEntity
{
	//Variable for the player's name'
	private string name;

	/**
	 * Main constructor for the player character.
	 */
	public PlayerCharacter(string Name)
	{
		this.name = Name;
    }

	/**
	 * Method to set the name of the player.
	 */
	 public string Name
	 {
		get 
		{ 
			return name; 
		}

		set
		{
			name = value;
		}
	}
}
