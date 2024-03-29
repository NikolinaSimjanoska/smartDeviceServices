using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service2" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service2.svc or Service2.svc.cs at the Solution Explorer and start debugging.
    public class Service2 : IService2
    {
        SmartWatch pametnaUra = new SmartWatch();

        public SmartWatch GetData()
        {
            return pametnaUra;
        }
        public SmartWatch GetState()
        {
            //pametnaUra.Stanje = !pametnaUra.Stanje;
            return pametnaUra;
        }

        public SmartWatch SetState(bool state)
        {
            pametnaUra.Stanje = state;
            return pametnaUra;
        }

        public WatchSensor GetDataSensorHeartMonitor()
        {
            //pametniTelefon.Stanje = !pametniTelefon.Stanje;
            return pametnaUra.HeartMonitor;
        }

        public WatchSensor GetDataSensorSkinTemp()
        {
            //pametniTelefon.Stanje = !pametniTelefon.Stanje;
            return pametnaUra.SkinTemp;
        }

        public SmartWatch RaiseBeats()
        {
            pametnaUra.HeartMonitor.Beats += 1;
            return pametnaUra;
        }

        public SmartWatch Termometer()
        {
            pametnaUra.SkinTemp.Temp += 1;
            return pametnaUra;
        }

    }
}
