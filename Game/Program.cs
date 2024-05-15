using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer
            {
                FirstName = "Eren",
                LastName = "Öz",
                BirthYear = 2001,
                IdentityNumber = 12345678910,
            });
        }
    }
}
