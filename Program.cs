namespace OOP
{
    internal class Program
    {
        enum CarType { Truck, Bus }

        
        
        #region car
        class Car //1. 클래스를 생성
        {
            public string name; //2. 정보들을 작성
            public float speed;
            public CarType type;

            public bool turnOn;
            public int oiAmount;

            public void Drive() //3.행동들을 작성
            {
                Console.WriteLine($"{name} 이름의 차가 움직입니다.");
                speed += 10;
            }

            public void stop()
            {
                Console.WriteLine($"{name} 이름의 차가 멈춥니다.");
                speed = 0;
            }

            public void TurnOn()
            {
                if (oiAmount > 0)
                {
                    Console.WriteLine("시동이 걸립니다.");
                    turnOn = true;
                }

            }

            public void Turnoff()
            {
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Car bongo = new Car(); //객체의 정보
            bongo.name = "봉고";
            bongo.speed = 0;
            bongo.type = CarType.Truck;

            bongo.Drive();// 4.객체의 행동
            bongo.stop();
        }
        #endregion

}
}
