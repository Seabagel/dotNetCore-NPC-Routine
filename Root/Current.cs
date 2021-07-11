using System.Collections.Generic;
using System.Linq;

namespace NPC_Routine_NetCore
{
    static class Current
    {
        // All NPC Schedules
        public static List<Schedule> ScheduleList = new List<Schedule>();
        // Get Each Character's Schedules at the beginning of the day, then sorts it by Time
        public static void SetSchedules()
        {
            // Empties the current list
            ScheduleList = new List<Schedule>();

            // add Schedules to the list
            foreach (var character in Current.characters.Values)
            {
                ScheduleList.AddRange(character.GetRoutine());
            }

            // Sorts list
            ScheduleList.OrderBy(schedule => schedule.time.minutes).ToList();
        }

        // Tracks the current day and time
        public static Calendar calendar = new Calendar(1);
        public static Time time = new Time(6, 0, true);

        // Weather
        public static bool raining = false;

        // Who your character is married with
        public static CharacterID marriedWith = CharacterID.Empty;



    }//End of Current
}
