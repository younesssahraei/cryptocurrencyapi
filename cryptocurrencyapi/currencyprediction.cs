using currency4;

namespace currency6
{
    public class CurrencyPredictions
    {
        public void prediction()

        {
            string address = @"B:\currency data\time.text";
            StreamReader streader = new StreamReader(address);


            double line1 = Convert.ToDouble(streader.ReadLine());
            double line2 = Convert.ToDouble(streader.ReadLine());
            double line3 = Convert.ToDouble(streader.ReadLine());

            var plus = line1 + line2 + line3;



            long average1 = Convert.ToInt32(plus) / 3;

            var currencyinfo = currencyApi.currencyinformation();

            var q = currencyinfo.Result.high;
            var e = currencyinfo.Result.low;
            var r = q + e;
            var t = Convert.ToInt32(r) / 2;

            var m = t - average1;

            var predictonbuy = m + currencyinfo.Result.buy;


            Console.WriteLine("predicton  is:  {0}", predictonbuy);

            Console.WriteLine("now price is {0}", currencyinfo.Result.buy);

        }

















    }
















}





























