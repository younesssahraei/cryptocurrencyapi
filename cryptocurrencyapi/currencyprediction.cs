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

            var y = currencyinfo.Result.high;
            var o = currencyinfo.Result.low;
            var u = y + o;
            var n = Convert.ToInt32(u) / 2;

            var m = n - average1;

            var predictonbuy = m + currencyinfo.Result.buy;


            Console.WriteLine("predicton  is:  {0}", predictonbuy);

            Console.WriteLine("now price is {0}", currencyinfo.Result.buy);

        }

















    }
















}





























