using DependencyInversion.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion
{
    public static class Factory
    {
        public static IPatient NewPatient()
        {
            return new Patient();
        }

        public static IObservation NewObservation()
        {
            return new Observation(NewLogger(), NewMessage());
        }

        public static ILogger NewLogger()
        {
            return new Logger();
        }

        public static IMessage NewMessage()
        {
            return new Message();
        }
    }
}
