using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchmeckCarsLtd
{
    class Car
    {

        public enum Reservoir
        {
            Gas,
            Gasoline,
            Combined
        }

        private string id;

        public Car(string id, string brand, string type, int nrSeats, int nrDoors, int power, DateTime productionDate, Reservoir reservoirType)
        {
            ID = id;
            Brand = brand;
            Type = type;
            NrSeats = nrSeats;
            NrDoors = nrDoors;
            Power = power;
            ProductionDate = productionDate;
            ReservoirType = reservoirType;
        }

        public string ID
        {
            get { return id; }
            set
            {
                if (value.Length != 5)
                {
                    throw new Exception("Id must be 5 letters");
                }
                id = value;
            }
        }
        public DateTime ProductionDate { get; set; }
        public string Brand { get; set; }
        public string Type { get; set; }
        public int NrSeats { get; set; }
        public int NrDoors { get; set; }
        public int Power { get; set; }
        public Reservoir ReservoirType { get; set; }

        public override string ToString()
        {
            return string.Format(
                "Id: {0}, Brand: {1}, Type: {2}, NrSeats: {3}, NrDoors: {4}, Power: {5}, Date: {6}, Reservoir: {7}",
                ID,
                Brand,
                Type,
                NrSeats,
                NrDoors,
                Power.PrintInFormat("KW"),
                ProductionDate.ToShortDateString(),
                ReservoirType
            );
        }


    }
}
