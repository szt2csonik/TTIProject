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
        /// Beteg s�lya (kg)
        /// </summary>
        private double _suly;
        /// <summary>
        /// Beteg magass�ga (m�ter)
        /// </summary>
        private double _magassag;

        /// <summary>
        /// Alap�rtelmezett konstruktor
        /// </summary>
        public Beteg()
        {
            _nev = string.Empty;
            _suly = 60;
            _magassag = 1.6;
        }

        /// <summary>
        /// �rhat� tulajdons�gok
        /// </summary>
        public string Nev
        {
            get => _nev;
            set => SetValue(ref _nev, value);
        }
        public double Suly
        {
            get => _suly;
            set => SetValue(ref _suly, value);
        }

        public double Magassag
        {
            get => _magassag;
            set => SetValue(ref _magassag, value);
        }

        /// <summary>
        /// Olvashat� tulajdons�gok
        /// Testt�meg index: kg / magass�g^2
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
                return _nev + " beteg test�meg indexe: " + TTI;
            }
        }
    }
}