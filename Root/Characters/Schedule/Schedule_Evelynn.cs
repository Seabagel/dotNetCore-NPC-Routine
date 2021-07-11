
using System.Collections.Generic;

namespace NPC_Routine_NetCore
{
    struct Schedule_Evelynn : ISchedule
    {
       public List<Schedule> GetSchedule()
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

