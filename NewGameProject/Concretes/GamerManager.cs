using System;
using System.Collections.Generic;
using System.Text;

namespace NewGameProject
{
    class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;
        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }
        
        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer) == true)
            {
                Console.WriteLine("Kayıt Yapıldı");
            }
            else
            {
                Console.WriteLine("Doğrulama hatalı. Kayıt başarısız");
            }
            
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Gamer silindi");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Gamer güncellendi");
        }
    }
}
