using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstEstimator1
{
    class BirthdayParty
    {
        public const int CostOfFoodPerPerson = 25;

        public int NumberOfPeople { get; set; }

        public bool FancyDecorations { get; set; }

        public string CakeWriting { get; set; }

        public bool CakeWritingTooLong
        {
            get
            {
                if (CakeWriting.Length > MaxWritingLength())
                {
                    return true;


                }
                else return false;
            }
        }

        public decimal Cost
        {
            get
            {
                decimal totalCost = CalculateCostOfDecorations();
                totalCost += CostOfFoodPerPerson * NumberOfPeople;
                decimal cakeCost;
                if (CakeSize() == 8)
                    cakeCost = 40M + ActaulLength * .25M;
                
                else
                    cakeCost = 75M + ActaulLength * .25M;

                if (NumberOfPeople >= 12)
                {
                    totalCost += 100M;
                }
                return totalCost + cakeCost;
            }
        }

        

        public BirthdayParty( int numberOfPeople, bool fancyDecoration, string cakeWriting)
        {
            NumberOfPeople = numberOfPeople;
            FancyDecorations = fancyDecoration;
            CakeWriting = cakeWriting;
        }
         
        private int ActaulLength
        {
            get
            {
                if (CakeWriting.Length > MaxWritingLength())
                    return MaxWritingLength();
                else
                    return CakeWriting.Length;
            }
        }

        private int CakeSize()
        {
            if (NumberOfPeople <= 4)
            {
                return 8;
            }
            else return 16;
        }

        private int MaxWritingLength()
        {
            if (CakeSize() == 8)
            {
                return 16;
            }
            else return 40;
        }

        private decimal CalculateCostOfDecorations()
        {
            decimal costOfDecoration;
            if (FancyDecorations)
                costOfDecoration = (NumberOfPeople * 15.00M) + 50M;
            else
                costOfDecoration = (NumberOfPeople * 7.50M) + 30M;
            return costOfDecoration;            
        }



        
    }
}
