using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodicTable
{
    public class Element
    {
        public int atomicNumber;
        public String elementName;
        public String symbol;
        public float atomicMass;
        public int numberOfNeutrons;
        public int numberOfProtons;
        public int numberOfElectrons;
        public int period;
        public int group;
        public String phase;
        public bool isRadioactive;
        public bool isNatural;
        public bool isMetal;
        public bool isNonmetal;
        public bool isMetalloid;
        public String type;
        public float atomicRadius;
        public float electronegativity;
        public float firstIonizationEnergy;
        public String density;
        public float meltingPoint;
        public float boilingPoint;
        public int numberOfIsotopes;
        public String discoverer;
        public int yearDiscovered;
        public float specificHeat;
        public int numberOfShells;
        public int numberOfValence;

        public Element
           (int AtomicNumber,
            String ElementName,
            String Symbol,
            float AtomicMass,
            int NumberOfNeutrons,
            int NumberOfProtons,
            int NumberOfElectrons,
            int Period,
            int Group,
            String Phase,
            bool IsRadioactive,
            bool IsNatural,
            bool IsMetal,
            bool IsNonmetal,
            bool IsMetalloid,
            String Type,
            float AtomicRadius,
            float Electronegativity,
            float FirstIonizationEnergy,
            String Density,
            float MeltingPoint,
            float BoilingPoint,
            int NumberOfIsotopes,
            String Discoverer,
            int YearDiscovered,
            float SpecificHeat,
            int NumberOfShells,
            int NumberOfValence)
        {
            atomicNumber = AtomicNumber;
            elementName = ElementName;
            symbol = Symbol;
            atomicMass = AtomicMass;
            numberOfNeutrons = NumberOfNeutrons;
            numberOfProtons = NumberOfProtons;
            numberOfElectrons = NumberOfElectrons;
            period = Period;
            group = Group;
            phase = Phase;
            isRadioactive = IsRadioactive;
            isNatural = IsNatural;
            isMetal = IsMetal;
            isNonmetal = IsNonmetal;
            isMetalloid = IsMetalloid;
            type = Type;
            atomicRadius = AtomicRadius;
            electronegativity = Electronegativity;
            firstIonizationEnergy = FirstIonizationEnergy;
            density = Density;
            meltingPoint = MeltingPoint;
            boilingPoint = BoilingPoint;
            numberOfIsotopes = NumberOfIsotopes;
            discoverer = Discoverer;
            yearDiscovered = YearDiscovered;
            specificHeat = SpecificHeat;
            numberOfShells = NumberOfShells;
            numberOfValence = NumberOfValence;
        }
    }
}
