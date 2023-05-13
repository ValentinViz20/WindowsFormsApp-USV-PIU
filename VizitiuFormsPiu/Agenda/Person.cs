using System;
using System.Globalization;



namespace VizitiuFormsPiu.Agenda
{
    
    /// <summary>
    /// Represents a person in the agend
    /// </summary>
    public class Person
    {
        /// <summary>
        /// Caracterul ce separa datele salvate in fisier
        /// </summary>
        readonly static char SEPARATOR_DATE = '$';

        /// <summary>
        /// The gruoups a contact can be in
        /// </summary>
        public enum ContactGroup
        {
            Friends,
            Family,
            WorkColleagues,
            Schoolmates,
            Neighbors,
            BusinessPartners,
            Acquaintances,
            SportsTeammates,
            SocialClubMembers,
            VolunteerGroupMembers
        }
        /// <summary>
        /// The ID used for creating new objects. This should be incremeneted at each new call of the constructor.
        /// </summary>
        public static int currentId = 0;

        public int Id { get; set; }
        public string Name { get; set; }
        public string Prenume { get; set; }
        public string PhoneNumber { get; set; }
        public ContactGroup Group { get; set; }
        public string Email { get; set; }
        public DateTime BithDate { get; set; }
        public int Rating { get; set; } = 11;
        public string ProfilePicturePath { get; set; } = "NONE";

        public List<string> GetPersonInfoList()
        {
            return new List<string>()
            {
                Name,
                Prenume,
                PhoneNumber,                       
                Group.ToString(),
                Email,
                BithDate.ToString(),
                Rating > 5 ? "N/A" : Rating.ToString() + " ⭐"
            };
        }

        /// <summary>
        /// This doesnt take a an Id, and instead increments the internal one directly. <br></br>
        /// Constructor that created a new person object. You need to specify all the fields separately.
        /// </summary>
        /// <param name="name"> The first name of the person </param>
        /// <param name="prenume"> The last name of the person </param>
        /// <param name="phoneNumber"> The phone number of the person </param>
        /// <param name="group"> The group they are part from, ex: 'friends', 'collegues'. </param>
        /// <param name="email"> The email of the person </param>
        /// <param name="birthDate"> The date of birth of the person </param>
        public Person(string name, string prenume, string phoneNumber, ContactGroup group, string email, DateTime birthDate) {

            this.Id = currentId++;
            this.Name = name;  
            this.Prenume = prenume;  
            this.PhoneNumber = phoneNumber;
            this.Group = group;
            this.Email = email;
            this.BithDate = birthDate;
        }

        /// <summary>
        /// This also required you to specify the person ID. <br></br>
        /// Constructor that created a new person object. You need to specify all the fields separately.
        /// </summary>
        /// <param name="Id"> The ID of the person </param>
        /// <param name="name"> The first name of the person </param>
        /// <param name="prenume"> The last name of the person </param>
        /// <param name="phoneNumber"> The phone number of the person </param>
        /// <param name="group"> The group they are part from, ex: 'friends', 'collegues'. </param>
        /// <param name="email"> The email of the person </param>
        /// <param name="birthDate"> The date of birth of the person </param>
        public Person(int Id, string name, string prenume, string phoneNumber, ContactGroup group, string email, DateTime birthDate) {

            this.Id = Id;
            this.Name = name;  
            this.Prenume = prenume;  
            this.PhoneNumber = phoneNumber;
            this.Group = group;
            this.Email = email;
            this.BithDate = birthDate;
        }

        /// <summary>
        /// Constructor that created a new person object by extracting the data from a string.
        /// </summary>
        /// <param name="stringSavedPerson"> The string containing values separated by the specified file separator. </param>
        public Person(string stringSavedPerson)
        {
            string[] splits = stringSavedPerson.Split(SEPARATOR_DATE);

            this.Id = currentId++;
            this.Name = splits[0];
            this.Prenume = splits[1];
            this.PhoneNumber = splits[2];

            Enum.TryParse(splits[3], out ContactGroup group);

            this.Group = group;

            this.Email = splits[4];
            this.BithDate = DateTime.ParseExact(splits[5], "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Rating = int.Parse(splits[6]);
            ProfilePicturePath = splits[7];
        }
        
        /// <summary>
        /// Converts a person object to a string that can be saved in a file
        /// </summary>
        /// <returns> The serialised person object. </returns>
        public string ConvertPersonDateToString()
        {


            string stringData = $"{this.Name}{SEPARATOR_DATE}" +
                                $"{this.Prenume}{SEPARATOR_DATE}" +
                                $"{this.PhoneNumber}{SEPARATOR_DATE}" +
                                $"{this.Group}{SEPARATOR_DATE}" +
                                $"{this.Email}{SEPARATOR_DATE}" +
                                $"{BithDate.Day:D2}/{this.BithDate.Month:D2}/{this.BithDate.Year:D4}{SEPARATOR_DATE}" +
                                $"{Rating}{SEPARATOR_DATE}" +
                                $"{ProfilePicturePath}\n";

            return stringData;
                                
        }

        /// <summary>
        /// Returns a string with the persons info in a pretty form.
        /// </summary>
        /// <returns> The string with the persons's info </returns>
        public string GetPrettyPersonInfo() {
            return $"Nume: {this.Name}\n" +
                $"Prenume: {this.Prenume}\n" +
                $"Nr. Telefon: {this.PhoneNumber}\n" +
                $"Grup: {this.Group}\n" +
                $"Email: {this.Email}\n" +
                $"Birthday: {this.BithDate}\n";
        }
    }
}
