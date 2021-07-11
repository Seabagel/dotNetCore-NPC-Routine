namespace NPC_Routine_NetCore
{
    struct Dialog_Evelynn : IDialog
    {
        public string GetDialog()
        {
            if (Current.marriedWith.Equals())
            {
                // returns text
                return "Hello";
            }
            else
            {
                return "Hello";
            }
        }
    }
}