using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCFServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        SmartPhone GetData();

        // TODO: Add your service operations here
        [OperationContract]
        SmartPhone GetState();

        [OperationContract]
        SmartPhone SetState(bool state);

        [OperationContract]
        SmartPhone RaiseSteps();

        [OperationContract]
        SmartPhone RestartSteps();

        [OperationContract]
        SmartPhone TurnOffScreen();

        [OperationContract]
        SmartPhone AdjustBrightness();

        [OperationContract]
        Sensor GetDataSensorPedometer();

        [OperationContract]
        Sensor GetDataSensorProximity();

        [OperationContract]
        Sensor GetDataSensorLight();
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class SmartPhone
    {
        string naziv = "Redmi Note 9 Pro";
        string proizvajalec = "Xiaomi";
        int id = 2134;
        bool stanje = true;
        Sensor pedometer = new Sensor("Senzor pedometer", "MicroTick", 9168, true, 1000, 23.5);
        Sensor proximity = new Sensor("Senzor bližine", "Neo", 5555, true, 0.3, true);
        Sensor light = new Sensor("Senzor ambientalne svetlobe", "Neo", 2323, true, 90);

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
        public Sensor Pedometer
        {
            get { return pedometer; }
            set { pedometer = value; }
        }

        [DataMember]
        public Sensor Proximity
        {
            get { return proximity; }
            set { proximity = value; }
        }

        [DataMember]
        public Sensor Light
        {
            get { return light; }
            set { light = value; }
        }
    }

    [DataContract]
    public class Sensor
    {
        string naziv;
        string proizvajalec;
        int id;
        bool stanje;
        int steps;
        double km;
        bool turnoff;
        int light;

        public Sensor(string naziv, string proizvajalec, int id, bool stanje, int steps, double km) {
            this.naziv = naziv;
            this.proizvajalec = proizvajalec;
            this.id = id;
            this.stanje = stanje;
            this.steps = steps;
            this.km = km;
        }

        public Sensor(string naziv, string proizvajalec, int id, bool stanje, double km, bool turnoff)
        {
            this.naziv = naziv;
            this.proizvajalec = proizvajalec;
            this.id = id;
            this.stanje = stanje;
            this.km = km;
            this.turnoff = turnoff;
        }

        public Sensor(string naziv, string proizvajalec, int id, bool stanje, int light)
        {
            this.naziv = naziv;
            this.proizvajalec = proizvajalec;
            this.id = id;
            this.stanje = stanje;
            this.light = light;
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
        public int Steps
        {
            get { return steps; }
            set { steps = value; }
        }

        [DataMember]
        public double Km
        {
            get { return km; }
            set { km = value; }
        }

        [DataMember]
        public int Light
        {
            get { return light; }
            set { light = value; }
        }

        [DataMember]
        public bool TurnOff
        {
            get { return turnoff; }
            set { turnoff = value; }
        }
    }

}
