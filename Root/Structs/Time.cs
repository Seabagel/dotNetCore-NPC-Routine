namespace NPC_Routine_NetCore
{
    struct Time
    {
        // There's 1439 minutes in one day
        public int minutes;

        public Time(int hour, int min, bool AMPM)
        {
            minutes = AMPM ? hour * 60 + min : hour * 60 + 720 + min;
        }

        // Separately, Returns Hour and remainder for 24 hour format
        public int Get24Hour() => minutes / 60;
        public int GetRemainder() => minutes % 60;

        public string Get12Hour()
        // Returns 12 hour format
        {
            int hour = Get24Hour();
            int min = GetRemainder();

            if (hour > 12) return $"{hour - 12:00}:{min:00} PM";
            if (hour == 12) return $"12:{min:00} PM";
            if (hour == 0) return $"12:{min:00} AM";
            else return $"{hour:00}:{min:00} AM";
        }

        public string GetTimeofDay()
        // Returns Time of Day
        {
            int hour = Get24Hour();
            if (Between(hour, 0, 4)) return TimeOfDayID.Night.ToString();
            if (Between(hour, 5, 11)) return TimeOfDayID.Morning.ToString();
            if (Between(hour, 12, 15)) return TimeOfDayID.Afternoon.ToString();
            if (Between(hour, 16, 19)) return TimeOfDayID.Evening.ToString();
            if (Between(hour, 20, 23)) return TimeOfDayID.Night.ToString();
            else throw new System.ArgumentException("Hour < 0 AM || hour > 24");
        }

        private bool Between(int hr, int min, int max)
        {
            return hr >= min && hr <= max;
        }
    }
}
