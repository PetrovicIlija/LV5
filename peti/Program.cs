using System;

namespace peti
{
    class Program
    {
        static void Main(string[] args)
        {
            ITheme myTheme = new HappyTheme();
            ReminderNote reminderNote = new ReminderNote("Look at me, I am happy woohoo!", myTheme);
            reminderNote.Show();
        }
    }
}
