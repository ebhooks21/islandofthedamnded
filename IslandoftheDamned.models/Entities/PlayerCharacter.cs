namespace IslandoftheDamned.models.Entities;

public class PlayerCharacter : IBaseEntity
{
	//Variable for the player's name'
	private string name;

	//Variable for the player's level
	private int level;

	/**
	 * Main constructor for the player character.
	 */
	public PlayerCharacter(string Name) {
		this.name = Name;
		this.level = 1;
    }

	/**
	 * Method to set the name of the player.
	 */
	 public string Name {
		get { 
			return name; 
		}

		set {
			name = value;
		}
	}

	/**
	 * Method for getting and setting the level of the player.
	 */
	 public int Level {
         get {
			return level;
         }

        set {
            level = value;
        }
    }
}
