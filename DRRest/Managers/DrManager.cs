using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DRClasssLib;

namespace DRRest.Managers
{
    public class DrManager
    {
        private static int _nextId = 1;

        private static readonly List<DRClass> Data = new List<DRClass>
        {
            new DRClass {UserId = 1, Id = _nextId++, Artist = "Duran Duran", Title = "Man eater",  Duration = 4.27, PublicationYear = 1986  },
            new DRClass {UserId = 1, Id = _nextId++, Artist = "Kanye West", Title = "God",  Duration = 4.27, PublicationYear = 2021}
        };

        public List<DRClass> GetAll()
        {
            return new List<DRClass>(Data);
        }



    }
}
