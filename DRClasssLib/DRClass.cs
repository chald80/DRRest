using System;

namespace DRClasssLib
{
    public class DRClass
    {
        private int _userId;
        private int _id;
        private string _title;
        private string _artist;
        private double _duration;
        private int _publicationYear;

        public DRClass(int id, string title, string artist, double duration, int publicationYear, int userId)
        {
            UserId = userId;
            Id = id;
            Title = title;
            Artist = artist;
            Duration = duration;
            PublicationYear = publicationYear;
        }
        public DRClass()
        {

        }

        public int UserId
        {
            get => _userId;
            set => _userId = value;
        }


        public int Id
        {
            get => _id;
            set => _id = value;
        }

        public string Title
        {
            get => _title;
            set
            {
                if (value == null) throw new ArgumentNullException("Title", "Title is null");
                if (value.Length < 2) throw new ArgumentException("Title length must be at least 2 characters");
                _title = value;

            }
        }

        public string Artist
        {
            get => _artist;
            set
            {
                if (value == null) throw new ArgumentNullException("Artist", "Artist is null");
                if (value.Length < 2) throw new ArgumentException("Artist length must be at least 2 characters");
                _artist = value;

            }
        }
        public double Duration 
        { 
            get => _duration;
            set
            {
                if (value > 0) _duration = value;
                else throw new ArgumentOutOfRangeException("Duration", value, "Illegal");
            }

        }

        public int PublicationYear
        {
            get => _publicationYear;
            set
            {
                if (value >= 1900 && value <= 2021) _publicationYear = value;
                else throw new ArgumentOutOfRangeException("PublicationYear", value, "Illegal");
            }
        }






    }
}
