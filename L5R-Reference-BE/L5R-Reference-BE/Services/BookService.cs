using L5R_Reference_BE.Enums;

namespace L5R_Reference_BE.Services
{
    public class BookService
    {
        private readonly Dictionary<int, string> _books;
        public BookService()
        {
            _books = new Dictionary<int, string>()
            {
                {(int)Book.Core, "Core Rulebook" },
                {(int)Book.PoW, "Path of Waves" },
                {(int)Book.SL, "Shadowlands" },
                {(int)Book.CoS, "Courts of Stone" },
                {(int)Book.CR, "Celestial Realms" },
                {(int)Book.FoV, "Fields of Victory" }
            };
        }

        public Dictionary<int,string> GetBooks()
        {
            return _books;
        }

        public string GetBook(int book)
        {
            if (!Enum.IsDefined(typeof(Book), book))
            {
                throw new ArgumentException("Invalid book value");
            }
            return _books[book];
        }

        public string GetBook(Book book)
        {
            return GetBook((int)book);
        }
    }
}
