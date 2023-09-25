using System.ComponentModel;
using ViewModels.BaseClass;

namespace TTIProject.Model
{
    public class Beteg : ViewModelBase
    {
        /// <summary>
        /// Beteg neve
        /// </summary>
        private string _nev;
        /// <summary>
        /// Beteg súlya (kg)
        /// </summary>
        private double _suly;
        /// <summary>
        /// Beteg magassága (méter)
        /// </summary>
        private double _magassag;

        /// <summary>
        /// Alapértelmezett konstruktor
        /// </summary>
        public Beteg()
        {
            _nev = string.Empty;
            _suly = 60;
            _magassag = 1.6;
        }

        /// <summary>
        /// Írható tulajdonságok
        /// </summary>
        public string Nev
        {
            get => _nev;
            set => SetValue(ref _nev, value);
        }
        public string Suly
        {
            get => _suly.ToString();
            set => SetValue(ref _suly, Convert.ToDouble(value));
        }

        public string Magassag
        {
            get => _magassag.ToString();
            set => SetValue(ref _magassag, Convert.ToDouble(value));
        }

        /// <summary>
        /// Olvasható tulajdonságok
        /// Testtömeg index: kg / magasság^2
        /// </summary>
        public double TTI
        {
            get
            {
                double tti = _suly / Math.Pow(_magassag, 2);
                double roundedTTI = Math.Round(tti, 2);
                return roundedTTI;
            }
        }

        public string BetegAdatok
        {
            get
            {
                return _nev + " beteg testőmeg indexe: " + TTI;
            }
        }

        public void Compute()
        {
            OnPropertyChanged(nameof(TTI));
            OnPropertyChanged(nameof(BetegAdatok));
        }
    }
}
