
using System.Collections.Generic;

namespace NPC_Routine_NetCore
{
    interface ICharacter
    {
        // The Character's ID
        CharacterID ID { get; }

        // Returns a string based on current day and location
        string GetDialog();

        // Returns this Character's Routines at the beginning of the day
        List<Schedule> GetRoutine();
    }

}