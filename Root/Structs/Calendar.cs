namespace NPC_Routine_NetCore
{
    struct Calendar
    {
        // A single Day of Week
        public int day; // 112 days (4 weeks/month * 4 months)

        public Calendar(int dayNumber)
        {
            day = dayNumber;
        }

        public Calendar(DayID dayID)
        {
            day = (int)dayID;
        }

        public DayID GetDayOfWeek()
        {
            int x;
            if (day % 7 == 0) x = 6; // SUNDAY
            else x = day % 7 - 1;
            return (DayID)x;
        }

        public SeasonID GetSeason()
        {
            return (SeasonID)(day / 7);
        }

        public bool HasDayofWeek(params DayID[] daysArr)
        {
            // Loop for everything in the list,
            // If found, return true,
            // If not found, run the loop again
            foreach (var day in daysArr)
            {
                if (Current.calendar.GetDayOfWeek().Equals(day)) { return true; }
                else { continue; }
            }
            return false;
        }
    }
}
