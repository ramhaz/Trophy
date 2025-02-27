using System;

namespace Trophy
{
    public class Trophy
    {
        private int id;
        private string competition;
        private int year;

        public int Id
        {
            get => id;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Id must be greater than or equal to 0");
                }
                id = value;
            }
        }

        public string Competition
        {
            get => competition;
            set
            {
                if (string.IsNullOrEmpty(value) || value.Length < 3)
                {
                    throw new ArgumentException("Competition must be at least 3 characters long and cannot be null");
                }
                competition = value;
            }
        }

        public int Year
        {
            get => year;
            set
            {
                if (value < 1970 || value > 2025)
                {
                    throw new ArgumentException("Year must be between 1970 and 2025");
                }
                year = value;
            }
        }

        public override string ToString()
        {
            return $"Id: {Id}, Competition: {Competition}, Year: {Year}";
        }
    }
}
