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
            new DRClass {id = _nextId++, artist = "Duran Duran", title = "Man eater",  duration = 4.27, publicationYear = 1986  },
            new DRClass {id = _nextId++, artist = "Kanye West", title = "God",  duration = 4.27, publicationYear = 2021}
        };



    }
}
