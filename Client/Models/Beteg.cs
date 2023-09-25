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
        /// Beteg s�lya (kg)
        /// </summary>
        private double suly;
        /// <summary>
        /// Beteg magass�ga (m�ter)
        /// </summary>
        private double magassag;

        /// <summary>
        /// Alap�rtelmezett konstruktor
        /// </summary>
        public Beteg()
        {
            nev = string.Empty;
            suly = 60;
            magassag = 1.6;
        }

        /// <summary>
        /// �rhat� tulajdons�gok
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
        /// Olvashat� tulajdons�gok
        /// Testt�meg index: kg / magass�g^2
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
                return nev + " beteg test�meg indexe: " + TTI;
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        /// <summary>
        /// Meg�rjuk az interface sz�ks�ges met�dus�t. Mindig ezt kell �rni
        /// </summary>
        /// <param name="property"></param>
        private void OnPropertyChanged(string property)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(property));
        }
    }
}