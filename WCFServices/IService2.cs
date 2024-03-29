using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService2" in both code and config file together.
    [ServiceContract]
    public interface IService2
    {
        [OperationContract]
        SmartWatch GetData();

        // TODO: Add your service operations here
        [OperationContract]
        SmartWatch GetState();

        [OperationContract]
        SmartWatch SetState(bool state);

        [OperationContract]
        WatchSensor GetDataSensorHeartMonitor();

        [OperationContract]
        WatchSensor GetDataSensorSkinTemp();

        [OperationContract]
        SmartWatch RaiseBeats();

        [OperationContract]
        SmartWatch Termometer();
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class SmartWatch
    {
        string naziv = "SmartWatch 9 Pro";
        string proizvajalec = "Xiaomi";
        int id = 5231;
        bool stanje = true;
        WatchSensor heartMonitor = new WatchSensor("Merilnik srčnega utripa", "UKC", 8564, true, 150);
        WatchSensor skinTemp = new WatchSensor("Senzor temperature kože", "UKC", 8568, true, 36.8);
        [DataMember]
        public string Naziv
        {
            get { return naziv; }
            set { naziv = value; }
        }

        [DataMember]
        public string Proizvajalec
        {
            get { return proizvajalec; }
            set { proizvajalec = value; }
        }

        [DataMember]
        public bool Stanje
        {
            get { return stanje; }
            set { stanje = value; }
        }

        [DataMember]
        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        [DataMember]
        public WatchSensor HeartMonitor
        {
            get { return heartMonitor; }
            set { heartMonitor = value; }
        }

        [DataMember]
        public WatchSensor SkinTemp
        {
            get { return skinTemp; }
            set { skinTemp = value; }
        }
    }

    [DataContract]
    public class WatchSensor
    {
        string naziv;
        string proizvajalec;
        int id;
        bool stanje;
        int beats;
        double temp;

        public WatchSensor(string naziv, string proizvajalec, int id, bool stanje, int beats)
        {
            this.naziv = naziv;
            this.proizvajalec = proizvajalec;
            this.id = id;
            this.stanje = stanje;
            this.beats = beats;
        }

        public WatchSensor(string naziv, string proizvajalec, int id, bool stanje, double temp)
        {
            this.naziv = naziv;
            this.proizvajalec = proizvajalec;
            this.id = id;
            this.stanje = stanje;
            this.temp = temp;
        }

        [DataMember]
        public string Naziv
        {
            get { return naziv; }
            set { naziv = value; }
        }

        [DataMember]
        public string Proizvajalec
        {
            get { return proizvajalec; }
            set { proizvajalec = value; }
        }

        [DataMember]
        public bool Stanje
        {
            get { return stanje; }
            set { stanje = value; }
        }

        [DataMember]
        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        [DataMember]
        public int Beats
        {
            get { return beats; }
            set { beats = value; }
        }

        [DataMember]
        public double Temp
        {
            get { return temp; }
            set { temp = value; }
        }
    }
}
