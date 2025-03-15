namespace Interface_Demo;

class Program
{
    private static void Main(string[] args)
    {
      IPay pay = new ZhPay();
        pay.Pay();
    }
}