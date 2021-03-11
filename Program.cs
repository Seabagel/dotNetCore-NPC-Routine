using System;

namespace NPC_Routine_NetCore
{
    class Program
    {
        static void Main(string[] args)
        {
            Current.SetCharacters();
            Current.SetRoutines();

            foreach (var character in Current.characters.Values)
            {
                //Console.WriteLine($"- {character.ID}");
            }

            foreach (var schedule in Current.ScheduleList)
            {
                Console.WriteLine($"- schedule: {schedule.time.Get12Hour()}, {schedule.characterID}, at {schedule.locationID}");
            }

            // Wait for input
            Console.WriteLine("\nEnd of Main");
            Console.ReadLine();
        }

        // End of Main
    }
}
