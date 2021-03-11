using System.Collections.Generic;
using System.Linq;

namespace NPC_Routine_NetCore
{
    static class Current
    {
        // List of all Characters
        public static Dictionary<CharacterID, ICharacter> characters = new Dictionary<CharacterID, ICharacter>();

        // All NPC Routines
        public static List<Schedule> ScheduleList = new List<Schedule>();


        // Tracks the current day and time
        public static Calendar calendar = new Calendar(1);
        public static Time time = new Time(6, 0, true);

        // Weather
        public static bool raining = false;
        public static CharacterID marriedWith = CharacterID.Empty;

        // Initialize the characters at the beginning of the game
        public static void SetCharacters()
        {
            characters.Add(CharacterID.Evelynn, new Character_Evelynn(CharacterID.Evelynn));
        }

        // Get Each Character's Routines at the beginning of the day, then sorts it by Time
        public static void SetRoutines()
        {
            // Empties the current list
            ScheduleList = new List<Schedule>();

            // add Routines to the list
            foreach (var character in Current.characters.Values)
            {
                ScheduleList.AddRange(character.GetRoutine());
            }

            // Sorts list
            ScheduleList.OrderBy(schedule => schedule.time.minutes).ToList();
        }

    }//End of Current
}
