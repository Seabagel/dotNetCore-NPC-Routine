namespace NPC_Routine_NetCore
{
    interface IDialog
    {
        // Returns a string based on current day and location
        // remember each dialog also has a picture
        string GetDialog();
        
    }
}