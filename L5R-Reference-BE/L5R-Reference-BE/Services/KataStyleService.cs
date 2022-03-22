using L5R_Reference_BE.Enums;

namespace L5R_Reference_BE.Services
{
    public class KataStyleService
    {
        private readonly Dictionary<int, string> _kataStyles;

        public KataStyleService()
        {
            _kataStyles = new Dictionary<int, string>()
            {
                {(int)KataStyle.General, "General" },
                {(int)KataStyle.CloseCombat, "Close Combat" },
                {(int)KataStyle.Ranged, "Ranged" },
            };
        }

        public Dictionary<int, string> GetKataStyles()
        {
            return _kataStyles;
        }

        public string GetKataStyle(int kataStyle)
        {
            if (!Enum.IsDefined(typeof(KataStyle), kataStyle))
            {
                throw new ArgumentException("Invalid kata style value");
            }
            return _kataStyles[kataStyle];
        }

        public string GetKataStyle(KataStyle kataStyle)
        {
            return GetKataStyle((int)kataStyle);
        }
    }
}
