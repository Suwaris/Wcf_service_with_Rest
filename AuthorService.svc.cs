using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace DemoWcfSoapService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class AuthorService : IAuthorService
    {

        private readonly Random _random = new Random();
        public List<string> GetAuthorNames()
        {
            List<string> lstAuthors = new List<string>();
            lstAuthors.Add("Joydip Kanjilal");
            lstAuthors.Add("Steve Smith");
            lstAuthors.Add("Michael Stevens");
            return lstAuthors;
        }

        public int GetRandomNumber()
        {
            // Generate and return a random number
            int randomNumber = _random.Next(1, 100); // Modify the range as needed
            return randomNumber;
        }
    }
}
