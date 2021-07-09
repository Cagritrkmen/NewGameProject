using System;
using System.Collections.Generic;
using System.Text;

namespace NewGameProject
{
    interface IUserValidationService
    {
        bool Validate(Gamer gamer);
    }
}
