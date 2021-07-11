
using System.Collections.Generic;

namespace NPC_Routine_NetCore
{
    interface ICustomization
    // Every character is made up of this Customization, it's what dictates what their models look like
    {
        // 3d models
        int Shirt { get; }
        int Pants { get; }
        int Skin { get; }
        int Hair { get; }

        // RGB Value. Default texture of shirt is grayscale, will be built using Image Filter
        int ShirtColor { get; }
        int PantsColor { get; }
        int HairColor { get; }
    }

}