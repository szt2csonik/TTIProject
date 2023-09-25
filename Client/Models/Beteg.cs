using System;
using System.ComponentModel;

namespace TTIProject.Model
{
    public class Beteg : INotifyPropertyChanged
    {
        /// <summary>
        /// Beteg neve
        /// </summary>
        private string nev;
        /// <summary>
        /// Beteg súlya (kg)
        /// </summary>
        private double suly;
        /// <summary>
        /// Beteg magassága (méter)
        /// </summary>
        private double magassag;

        /// <summary>
        /// Alapértelmezett konstruktor
        /// </summary>
        public Beteg()
        {
            nev = string.Empty;
            suly = 60;
            magassag = 1.6;
        }

        /// <summary>
        /// Írható tulajdonságok
        /// </summary>
        public string Nev
        {
            set
            {
                nev = value;
                OnPropertyChanged("BetegAdatok");
            }
        }
        public double Suly
        {
            set
            {
                suly = value;
                OnPropertyChanged("BetegAdatok");
                OnPropertyChanged("TTI");
            }
        }

        public double Magassag
        {
            set
            {
                magassag = value;
                OnPropertyChanged("BetegAdatok");
                OnPropertyChanged("TTI");
            }
        }

        /// <summary>
        /// Olvasható tulajdonságok
        /// Testtömeg index: kg / magasság^2
        /// </summary>
        public double TTI
        {
            get
            {
                double tti = suly / Math.Pow(magassag, 2);
                double roundedTTI = Math.Round(tti, 2);
                return roundedTTI;
            }
        }

        public string BetegAdatok
        {
            get
            {
                return nev + " beteg testõmeg indexe: " + TTI;
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        /// <summary>
        /// Megírjuk az interface szükséges metódusát. Mindig ezt kell írni
        /// </summary>
        /// <param name="property"></param>
        private void OnPropertyChanged(string property)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(property));
        }
    }
}