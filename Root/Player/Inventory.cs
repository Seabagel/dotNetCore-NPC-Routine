using System.Collections.Generic;

namespace NPC_Routine_NetCore
{
    struct Inventory
    {
        List<Iitem> Items = new List<Iitem>();

        void AddItem(Iitem item) {
            Items.Add(item);
        }

        void RemoveItem(Iitem item) {
            Items.Remove(item);
        }
    }
}