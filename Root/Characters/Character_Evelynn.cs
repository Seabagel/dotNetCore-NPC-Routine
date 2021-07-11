using System.Collections.Generic;

namespace NPC_Routine_NetCore
{
    struct Character_Evelynn : ICharacter
    {
        public CharacterID ID { get; }

        // Initialize the characterID
        public IDialog Dialog { get; } = Dialog_Evelynn;
        public ISchedule Schedule { get; } = Schedule_Evelynn;
        public ICustomization Customization { get; } = Customization_Evelynn;

        public Character_Evelynn()
        {
            ID = CharacterID.Evelynn;
        }
    }
}