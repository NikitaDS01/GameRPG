using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Characteristics;
using SkillSystem;
using SkillSystem.TypeSkillRequest;
using Characteristics.Parameter;
using Characteristics.TypeModificator;

namespace SkillSystem.TypeSkill
{
    public class Bomba : ISkill
    {
        public ParameterCollection ParametersSkills { get; private set; }

        public UnitParameter GetCooldown => ParametersSkills.GetValue(EnumParameter.COOLDOWN);

        public Bomba(int raduisValue, int damageValue, int energyValue)
        {
            ParametersSkills = new ParameterCollection();
            Raduis raduis = new Raduis(raduisValue);
            Damage damage = new Damage(damageValue);
            Cooldown cooldown = new Cooldown();
            ParametersSkills.Add(raduis);
            ParametersSkills.Add(damage);
            ParametersSkills.Add(cooldown);
        }

        public void cast()
        {
            GetCooldown.AddMods(new DecreaseCooldown("BombaCooldown", 5));
            double raduis = ParametersSkills.GetValue(EnumParameter.RADUIS).GetCurrentValue;
            double damage = ParametersSkills.GetValue(EnumParameter.ATTACH).GetCurrentValue;
            Console.WriteLine($"Произошёл взрыв радиусом:{raduis} и уроном {damage}");
        }
        public void Update()
        {
            ParametersSkills.Update();

        }

        public ISkillCastRequest request(ParameterCollection parametersUsers) 
            => new BombaRequest(this, parametersUsers, ParametersSkills);
    }
}
