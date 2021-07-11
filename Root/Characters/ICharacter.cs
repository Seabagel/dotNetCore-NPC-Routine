
using System.Collections.Generic;

namespace NPC_Routine_NetCore
{
    interface ICharacter
    {
        CharacterID ID { get; }

        // Initialize the characterID
        IDialog Dialog { get; }
        ISchedule Schedule { get; }
        ICustomization Customization { get; }
    }

}

