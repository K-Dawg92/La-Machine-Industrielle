using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace La_Machine_Industrielle
{
    public class BeerEncapsulator
    {
        // those variables below are the properties/attributes of the class, they are a class level scope (since class level variables are declared outside of
        //any methods, you can use them anywhere inside the class.)
        private double _availableBeerVolume;
        private int _availableBottles;
        private int _availableCapsules;



        // this below is the constructor 
        public BeerEncapsulator(double availableBeerVolume, int availableBottles, int availableCapsules)
        {
            _availableBeerVolume = availableBeerVolume;
            _availableBottles = availableBottles;
            _availableCapsules = availableCapsules;
        }


        public double AvailableBeerVolume
        {
            get { return _availableBeerVolume; }
        }
        public int AvailableBottles
        {
            get { return _availableBottles; }
            set { _availableBottles = value; }
        }
        public int AvailableCapsules
        {
            get { return _availableCapsules; }
            set { _availableCapsules = value; }
        }

        public void AddBeer(double amount)
        { 
            _availableBeerVolume += amount;
        }

        public int ProduceEncapsulatedBeerBottles(int bottleToProduce)
        {
            int bottleProduced = 0;
            while (bottleProduced != bottleToProduce)
            {
                if (_availableBottles > 0 && _availableCapsules > 0 && _availableBeerVolume >= 0.33)
                {
                    _availableBottles--;
                    _availableCapsules--;
                    _availableBeerVolume -= 0.33;
                    bottleProduced++;

                }
                else
                {

                    Console.WriteLine("Sorry inssuficient items to produce a bottle");
                    if (_availableBeerVolume < 0.33)
                    {
                        Console.WriteLine($"Beer problem  {(bottleToProduce - bottleProduced)*0.33}");
                    }
                    if (_availableBottles ==0)
                    {
                        Console.WriteLine($"Bottle problem {bottleToProduce - bottleProduced}");
                    }
                    if (_availableCapsules== 0)
                    {
                        Console.WriteLine($"Caps problem {bottleToProduce - bottleProduced}");
                    }
                    return 0;
                    
                }
            }

            return bottleProduced;
        }
    }
}
