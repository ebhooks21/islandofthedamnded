namespace IslandoftheDamned.models.Entities;

public class CharacterClasses : IBaseEntity {
    //Variable for the character class name
    public string name;

    /**
     * Constructor for teh CharacterClasses class.
     */
    public CharacterClasses(string name) {

    }

    public string Name {
        get {
            return name;
        }

        set {
            name = value;
        }
    }
}
