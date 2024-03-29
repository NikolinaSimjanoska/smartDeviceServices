using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCFServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        SmartPhone pametniTelefon = new SmartPhone();

        public SmartPhone GetData()
        {
            return pametniTelefon;
        }
        public SmartPhone GetState()
        {
            //pametniTelefon.Stanje = !pametniTelefon.Stanje;
            return pametniTelefon;
        }

        public SmartPhone SetState(bool state)
        {
            pametniTelefon.Stanje = state;
            return pametniTelefon;
        }

        public Sensor GetDataSensorPedometer()
        {
            //pametniTelefon.Stanje = !pametniTelefon.Stanje;
            return pametniTelefon.Pedometer;
        }

        public SmartPhone RaiseSteps()
        {
            pametniTelefon.Pedometer.Steps += 1;
            return pametniTelefon;
        }

        public SmartPhone RestartSteps()
        {
            pametniTelefon.Pedometer.Steps = 0;
            return pametniTelefon;
        }

        public Sensor GetDataSensorProximity()
        {
            //pametniTelefon.Stanje = !pametniTelefon.Stanje;
            return pametniTelefon.Proximity;
        }

        public SmartPhone TurnOffScreen()
        {
            if (pametniTelefon.Proximity.Km < 0.5)
                pametniTelefon.Proximity.TurnOff = false;
            return pametniTelefon;
        }

        public Sensor GetDataSensorLight()
        {
            //pametniTelefon.Stanje = !pametniTelefon.Stanje;
            return pametniTelefon.Light;
        }

        public SmartPhone AdjustBrightness()
        {
            if (pametniTelefon.Light.Light > 80)
                pametniTelefon.Light.Light = 50;
            return pametniTelefon;
        }
    }
}
