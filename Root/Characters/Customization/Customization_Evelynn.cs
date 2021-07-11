using System.Collections.Generic;

namespace NPC_Routine_NetCore
{
    struct Customization_Evelynn
    // Every character is made up of this Customization, it's what dictates what their models look like
    {
        // 3d models
        int Shirt;
        int Pants;
        int Skin;
        int Hair;

        // RGB Value. Default texture of shirt is grayscale, will be built using Image Filter
        int ShirtColor;
        int PantsColor;
        int HairColor;
    }

}