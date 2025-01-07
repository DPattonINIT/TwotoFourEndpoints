using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TwotoFourEndpoints.Services
{
    public class PersonalInfoService
    {
        public string GetPersonalInfo(string name, string wakeUp)
        {
            return $"{name} woke up at {wakeUp} today!";
        }
    }
}