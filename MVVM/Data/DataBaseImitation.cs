using MVVM.Models;
using System.IO;
using Newtonsoft.Json;
using Windows.ApplicationModel;


namespace MVVM.Data
{
    public class DataBaseImitation
    {
        public static Persons GetPeople() 
        {
            string path = Path.Combine(Package.Current.InstalledLocation.Path, "PersonsDB.json");
            using (StreamReader sr = File.OpenText(path))
            {
                string result = sr.ReadToEnd();
                return JsonConvert.DeserializeObject<Persons>(result);
            }
        }

        public static void Update(Persons ps)
        {
             //write to file code
        }
    }   
}
