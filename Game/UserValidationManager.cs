using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.FirstName == "Eren" && gamer.LastName == "Öz" &&
                gamer.BirthYear == 2001 && gamer.IdentityNumber == 12345678910)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
