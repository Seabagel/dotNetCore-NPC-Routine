namespace NPC_Routine_NetCore
{
    struct Schedule
    {
        // Time and day
        public Time time;
        // Location and character
        public LocationID locationID;
        public CharacterID characterID;

        public Schedule(Time time, LocationID locationID, CharacterID characterID)
        {
            this.time = time;
            this.locationID = locationID;
            this.characterID = characterID;
        }
    }
}