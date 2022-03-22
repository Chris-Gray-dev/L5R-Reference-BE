using L5R_Reference_BE.Enums;

namespace L5R_Reference_BE.Services
{
    public class TechniqueTypeService
    {

        private readonly Dictionary<int, string> _techniqueTypes;

        public TechniqueTypeService()
        {
            _techniqueTypes = new Dictionary<int, string>()
            {
                {(int)TechniqueType.Kata, "Kata" },
                {(int)TechniqueType.Kiho, "Kihō" },
                {(int)TechniqueType.Invocation, "Inovation" },
                {(int)TechniqueType.Ritual, "Ritual" },
                {(int)TechniqueType.Shuji, "Shūji" },
                {(int)TechniqueType.Maho, "Mahō" },
                {(int)TechniqueType.Ninjitsu, "Ninjitsu" },
            };
        }

        public Dictionary<int, string> GetTechniqueTypes()
        {
            return _techniqueTypes;
        }

        public string GetTechniqueType(int technique)
        {
            if (!Enum.IsDefined(typeof(TechniqueType), technique))
            {
                throw new ArgumentException("Invalid technique type value");
            }
            return _techniqueTypes[technique];
        }

        public string GetTechniqueType(TechniqueType technique)
        {
            return GetTechniqueType((int)technique);
        }
    }
}
