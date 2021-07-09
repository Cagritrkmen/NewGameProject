using System;
using System.Collections.Generic;
using System.Text;

namespace NewGameProject
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.NationalityId.Length==11)
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
