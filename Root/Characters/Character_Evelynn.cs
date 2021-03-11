using System.Collections.Generic;

namespace NPC_Routine_NetCore
{
    struct Character_Evelynn : ICharacter
    {
        // Initialize the characterID
        public CharacterID ID { get; }
        public Character_Evelynn(CharacterID iD)
        {
            ID = iD;
        }

        // remember each dialog also has a picture
        public string GetDialog()
        {
            if (Current.marriedWith.Equals(ID))
            {
                // returns text
                return "Hello";
            }
            else
            {
                return "Hello";
            }
        }

        public List<Schedule> GetRoutine()
        {
            // Make a new empty list
            List<Schedule> ScheduleList = new List<Schedule>();

            if (Current.marriedWith.Equals(ID))
            {
                // Schedule if married
            }
            else
            {
                // Fill it with these schedules
                switch (Current.calendar.GetDayOfWeek())
                {
                    // Add the whole schedule of the day
                    case DayID.Tuesday:
                        ScheduleList.Add(new Schedule(
                            new Time(8, 30, true),
                            LocationID.Church,
                            ID)
                        );
                        break;
                    default:
                        ScheduleList.Add(new Schedule(
                            new Time(8, 30, true),
                            LocationID.Church,
                            ID)
                        );
                        break;
                }
            }

            //Console.WriteLine(ScheduleList.Count);
            return ScheduleList;
        }
    }
}