namespace InterfaceTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Create an interface IVehicle with the following methods:
            void Start()
            void Accelerate(int speed)
            void Brake()
            Create two classes Car and Motorcycle that implement the IVehicle interface. 
            Implement the methods according to the behavior of each vehicle type.
            */

            Car car = new Car();
            car.Start();
            car.Accelerate(100);
            car.Brake();

            Motorcycle motorcycle = new Motorcycle();
            motorcycle.Start();
            motorcycle.Accelerate(80);
            motorcycle.Brake();
            Console.WriteLine("------------------------------");

            /*Create an interface called IBankAccount that has methods called GetBalance(), Deposit(), and Withdraw().
             Create two classes, SavingsAccount and CheckingAccount, that implement the IBankAccount interface.
            The SavingsAccount class should override the Deposit() and Withdraw() methods to add and subtract money
            from the savings account balance. The CheckingAccount class should override the Deposit() and Withdraw() 
            methods to add and subtract money from the checking account balance.
            */

            SavingsAccount savingsAccount = new SavingsAccount();
            savingsAccount.Deposit(300);
            Console.WriteLine("Savings account balance: {0}", savingsAccount.GetBalance());

            CheckingAccount checkingAccount = new CheckingAccount();
            checkingAccount.Deposit(400);
            Console.WriteLine("Checking account balance: {0}", checkingAccount.GetBalance());

            checkingAccount.Withdraw(100);
            Console.WriteLine("Checking account balance: {0}", checkingAccount.GetBalance());
            Console.WriteLine("------------------------------");

            /*
            Create an interface IPlayable with the following methods:
            void Play()
            void Pause()
            void Stop()
            Create two classes MusicPlayer and VideoPlayer that implement the IPlayable interface.
            Implement the methods to control the playback of music and videos.
            */

            MusicPlayer musicPlayer = new MusicPlayer();
            musicPlayer.Play();
            musicPlayer.Pause();
            musicPlayer.Stop();

            VideoPlayer videoPlayer = new VideoPlayer();
            videoPlayer.Play();
            videoPlayer.Pause();
            videoPlayer.Stop();
        }
    }
}