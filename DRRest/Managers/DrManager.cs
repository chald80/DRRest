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
            new DRClass { Id = _nextId++, Artist = "Duran Duran", Title = "Man eater",  Duration = 4.27, PublicationYear = 1986  },
            new DRClass { Id = _nextId++, Artist = "Kanye West", Title = "God",  Duration = 4.27, PublicationYear = 2021}
            
        };

        public List<DRClass> GetAll()
        {
            return new List<DRClass>(Data);
        }

        public List<DRClass> GetByTitle(string title)
        {
            return Data.FindAll(d => d.Title == title);
        }

        public DRClass GetByUserId(int id)
        {
            return Data.Find(d => d.Id == id);
        }




    }
}
