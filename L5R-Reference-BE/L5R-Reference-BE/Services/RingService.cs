using L5R_Reference_BE.Enums;

namespace L5R_Reference_BE.Services
{
    
    public class RingService
    {
        private readonly Dictionary<int, string> _rings;

        public RingService()
        {
            _rings = new Dictionary<int, string> {
                {(int)Ring.Fire, "Fire"},
                {(int)Ring.Water, "Water"},
                {(int)Ring.Earth, "Earth" },
                {(int)Ring.Air, "Air" },
                {(int)Ring.Void, "Void" }
            };
        }


        public Dictionary<int, string> GetRings()
        {
            return _rings;
        }

        public string GetRing(int ring)
        {
            if (!Enum.IsDefined(typeof(Ring), ring))
            {
                throw new ArgumentException("Invalid ring value");
            }
            return _rings[ring];
        }

        public string GetRing(Ring ring)
        {
            return GetRing((int)ring);
        }


    }
}
