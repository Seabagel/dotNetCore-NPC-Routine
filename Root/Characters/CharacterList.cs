using System.Collections.Generic;

namespace NPC_Routine_NetCore
{
    struct CharacterList
    {
        // List of all Characters
        public static Dictionary<CharacterID, ICharacter> Characters = new Dictionary<CharacterID, ICharacter>();

        // Initialize the Characters at the beginning of the game
        public static void SetCharacters()
        {
            Characters.Add(CharacterID.Evelynn, new Character_Evelynn(CharacterID.Evelynn));
        }
    }
}