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
using GameRPG.Statuses;

namespace SkillSystem.TypeSkill
{
    public class Bomba : ISkill
    {
        private ParameterCollection users;
        public ParameterCollection ParametersSkills { get; private set; }

        public UnitParameter GetCooldown => ParametersSkills.GetValue(EnumParameter.COOLDOWN);
        public UnitParameter GetDamage => ParametersSkills.GetValue(EnumParameter.ATTACH);

        ISkillCastRequest ISkill.request => new BombaRequest(this, users, ParametersSkills);
        public string OutputText => $"Произошёл взрыв уроном {GetDamage.GetCurrentValue}";

        public Bomba(ParameterCollection parametersUsers, int damageValue)
        {
            users = parametersUsers;
            ParametersSkills = new ParameterCollection();
            Damage damage = new Damage(damageValue);
            Cooldown cooldown = new Cooldown();
            ParametersSkills.Add(damage);
            ParametersSkills.Add(cooldown);
        }

        public void cast()
        {
            GetCooldown.AddMods(new DecreaseCooldown("BombaCooldown", 5));
            int damage = Convert.ToInt32(GetDamage.GetCurrentValue);
            Battle.AddMods(new InValue("Damage", EnumParameter.HEALTH, -damage, 999999));
            //OutputModificators.Add(new InValue("Damage", EnumParameter.HEALTH, -damage, 999999));
        }
        public void Update()
        {
            ParametersSkills.Update();

        }
    }
}
