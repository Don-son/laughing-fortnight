using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstEstimator1
{
    class DinnerParty
    {
        public DinnerParty(int numberOfPeople, bool healthyOptions, bool fancyDecorations)
        {
            this.NumberOfPeople = numberOfPeople;
            this.HealthyOption = healthyOptions;
            this.FancyDecortations = fancyDecorations;
        }
        public const int CostOfFoodPerPerson = 25;

        public int NumberOfPeople { get; set; }

        public bool FancyDecortations { get; set; }

        public bool HealthyOption { get; set; }

        public decimal Cost
        {
            get
            {
                decimal totalCost = CalculateCostOfDecorations();

                totalCost += ((CalculateCostOfBeverages() + CostOfFoodPerPerson) * NumberOfPeople);

                if (HealthyOption)
                {
                    totalCost *= .95M;
                }
                if (NumberOfPeople >= 12)
                {
                    totalCost += 100M;
                }

                return totalCost;

            }
        }

        private decimal CalculateCostOfDecorations()
        {
            decimal costOfDecorations;

            if (FancyDecortations)
            {
                costOfDecorations = (15m * NumberOfPeople) + 50m;
            }
            else costOfDecorations = (7.5m * NumberOfPeople) + 30m;

            return costOfDecorations;
        }
       


        private decimal CalculateCostOfBeverages()
        {
            decimal costOfBeverages;

            if (HealthyOption)
            {
               costOfBeverages = 5m;
            }
            else costOfBeverages = 20m;

            return costOfBeverages;
            
        }


   

        


    
    }
}
