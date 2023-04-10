using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Characteristics
{
    public class ParameterCollection
    {
        private Dictionary<string, UnitParameter> parameters;
        public Dictionary<string, UnitParameter> GetCollection => parameters;
        public List<UnitParameter> GetParameters => parameters.Values.ToList();

        public int Count => throw new NotImplementedException();

        public ParameterCollection()
        {
            parameters = new Dictionary<string, UnitParameter>();
        }
        public UnitParameter GetValue(string paramName)
        {
            UnitParameter param;
            if (parameters.TryGetValue(paramName, out param))
            {
                return param;
            }
            return null;
        }
        public bool ContainsKey(string key)=>parameters.ContainsKey(key);

        public void Add(string key, UnitParameter value)=>parameters.Add(key, value);

        public void Add(UnitParameter item) => parameters.Add(item.Name, item);

        public bool Remove(string key)=>parameters.Remove(key);

        public void Add(KeyValuePair<string, UnitParameter> item) => parameters.Add(item.Key,item.Value);

        public void Clear() => parameters.Clear();

        public bool Contains(KeyValuePair<string, UnitParameter> item) => parameters.Contains(item);

        public bool Remove(KeyValuePair<string, UnitParameter> item) => parameters.Remove(item.Key);

        public void AddEffect(Modificator<double> effect)
        {
            UnitParameter param = this.GetValue(effect.ParamName);
            if (param is null) return;
            param.AddMods(effect);

        }
        public void AddEffect(List<Modificator<double>> effects)
        {
            foreach (var effect in effects)
            {
                UnitParameter param = this.GetValue(effect.ParamName);
                if (param is null) return;
                param.AddMods(effect);
            }
        }

        public void Update()
        {
            foreach (var param in GetParameters)
            {
                param.Update();
            }
        }
        public IEnumerator<UnitParameter> GetEnumerator()
        {
            return GetParameters.GetEnumerator();
        }

    }
}
