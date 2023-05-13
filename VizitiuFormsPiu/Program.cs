using VizitiuFormsPiu.Agenda;

namespace VizitiuFormsPiu
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var agendApp = new Agend();

            /*
            agendApp.AddPersonToAgend(new Person("Vizitiu", "Valentin", "0733351698", Person.ContactGroup.Schoolmates, "test@gmail.com", DateTime.Now));
            agendApp.AddPersonToAgend(new Person("Elena", "Zghibarta", "0733351698", Person.ContactGroup.Friends, "test@gmail.com", DateTime.Now));
            agendApp.AddPersonToAgend(new Person("Andra", "Lobiuc", "0733351698", Person.ContactGroup.Friends, "test@gmail.com", DateTime.Now));
            agendApp.AddPersonToAgend(new Person("Mihau", "test", "0733351698", Person.ContactGroup.Family, "test@gmail.com", DateTime.Now));     
            agendApp.AddPersonToAgend(new Person("Mihau", "test", "0733351698", Person.ContactGroup.Family, "test@gmail.com", DateTime.Now));     
            agendApp.AddPersonToAgend(new Person("Mihau", "test", "0733351698", Person.ContactGroup.Family, "test@gmail.com", DateTime.Now));     
            agendApp.AddPersonToAgend(new Person("Mihau", "test", "0733351698", Person.ContactGroup.Family, "test@gmail.com", DateTime.Now));     
            */
            
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1(agendApp));
        }
    }
}