

using currency4;

namespace currency5

{
    public class CurrencyData2
    {

        public void data()
        {

            string address = @"B:\currency data\time.text";
            StreamWriter stwriter = new StreamWriter(address);

            TimeSpan tens = new TimeSpan(0, 0, 10);

            for (int i = 0; i < 6; i++)
            {

                var currencyinfo = currencyApi.currencyinformation();

                stwriter.WriteLine(currencyinfo.Result.buy);


                Thread.Sleep(tens);

            }
            stwriter.Close();





        }
    }
}
