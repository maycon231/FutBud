namespace FutBud.Services
{
    internal static class RoundPrices
    {
        public static uint RoundToFinal(uint pricecalc)
        {
            uint finalprice = 0;

            if (pricecalc <= 1000)
            {
                finalprice = RoundToNearest(pricecalc, 50);
            }
            if (pricecalc > 1000 && pricecalc <= 10000)
            {
                finalprice = RoundToNearest(pricecalc, 100);
            }
            if (pricecalc > 10000 && pricecalc <= 50000)
            {
                finalprice = RoundToNearest(pricecalc, 250);
            }
            if (pricecalc > 50000 && pricecalc <= 100000)
            {
                finalprice = RoundToNearest(pricecalc, 500);
            }
            if (pricecalc > 100000)
            {
                finalprice = RoundToNearest(pricecalc, 1000);
            }

            return finalprice;
        } //round the price
        public static uint RoundToNearest(uint Amount, uint RoundTo)   //round the price
        {
            uint ExcessAmount = Amount % RoundTo;
            if (ExcessAmount < (RoundTo / 2))
            {
                Amount -= ExcessAmount;
            }
            else
            {
                Amount += (RoundTo - ExcessAmount);
            }
            return Amount;
        }

        public static uint DoCalcBidprice(uint buynowprice)
        {
            var bidprice = buynowprice;

            if (buynowprice <= 1000)
            {
                bidprice = buynowprice - 50;
            }
            if (buynowprice > 1000 && buynowprice <= 10000)
            {
                bidprice = buynowprice - 100;
            }
            if (buynowprice > 10000 && buynowprice <= 50000)
            {
                bidprice = buynowprice - 250;
            }
            if (buynowprice > 50000 && buynowprice <= 100000)
            {
                bidprice = buynowprice - 500;
            }
            if (buynowprice > 100000)
            {
                bidprice = buynowprice - 1000;
            }

            return bidprice;
        }

    }
}
