namespace Wrox.ProCSharp.Delegates
{
    class Program
    {
        static void Main()
        {
            var dealer = new CarDealer();

            var michael = new Consumer("Michael");
            dealer.NewCarInfo += michael.NewCarIsHere;   //消费者michael（变量）订阅了事件

            dealer.NewCar("Mercedes");  //一辆Mercedes到达，Michael得到了通知

            var nick = new Consumer("Nick");
            dealer.NewCarInfo += nick.NewCarIsHere;

            dealer.NewCar("Ferrari");

            dealer.NewCarInfo -= michael.NewCarIsHere;

            dealer.NewCar("Toyota");
        }
    }
}
