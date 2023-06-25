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
            Console.WriteLine("******* VEHICLE INTERFACE *******");
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
            Console.WriteLine("******* BAMK ACCOUNT INTERFACE *******");
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
            Console.WriteLine("******* PLAYABLE INTERFACE *******");
            MusicPlayer musicPlayer = new MusicPlayer();
            musicPlayer.Play();
            musicPlayer.Pause();
            musicPlayer.Stop();

            VideoPlayer videoPlayer = new VideoPlayer();
            videoPlayer.Play();
            videoPlayer.Pause();
            videoPlayer.Stop();
            Console.WriteLine("------------------------------");

            /* 
             Create an interface IAnimal with the following methods:

             void Eat()
             void Sleep()
             Create two classes Dog and Cat that implement the IAnimal interface. 
             Implement the methods according to the behavior of each animal.
            */
            Console.WriteLine("******* ANIMAL INTERFACE *******");
            Dog dog = new Dog();
            dog.Eat();
            dog.Sleep();
            Cat cat = new Cat();
            cat.Eat();
            cat.Sleep();
            Console.WriteLine("------------------------------");

            /*
            Create an interface ILogger with the following methods:

            void LogInfo(string message)
            void LogError(string errorMessage)
            Create two classes FileLogger and DatabaseLogger that implement the ILogger interface.
            Implement the methods to log information and errors to a file and a database, respectively.
            */
            Console.WriteLine("******* lOGGER INTERFACE *******");
            FileLogger fileLogger = new FileLogger();
            fileLogger.LogInfo("This is an information message.");
            fileLogger.LogError("This is an error message.");

            DatabaseLogger databaseLogger = new DatabaseLogger();
            databaseLogger.LogInfo("This is an information message.");
            databaseLogger.LogError("This is an error message.");
            Console.WriteLine("------------------------------");

            /*
            Create an interface called IEmployee that has methods called GetName(), GetSalary(),
            and GetJobTitle(). Create two classes, FullTimeEmployee and PartTimeEmployee, that implement
            the IEmployee interface. The FullTimeEmployee class should override the GetName(), GetSalary(),
            and GetJobTitle() methods to return the full-time employee's name, salary, and job title.
            The PartTimeEmployee class should override the GetName(), GetSalary(), and GetJobTitle()
            methods to return the part-time employee's name, salary, and job title.
            */
            Console.WriteLine("******* EMPLOYEE INTERFACE *******");
            FullTimeEmployee fullTimeEmployee = new FullTimeEmployee("Mohammed", 100000, "Software Engineer");
            PartTimeEmployee partTimeEmployee = new PartTimeEmployee("Sami", 20, 40);

            Console.WriteLine("Full-time employee:");
            Console.WriteLine("Name: {0}", fullTimeEmployee.GetName());
            Console.WriteLine("Salary: {0}", fullTimeEmployee.GetSalary());
            Console.WriteLine("Job title: {0}", fullTimeEmployee.GetJobTitle());

            Console.WriteLine("Part-time employee:");
            Console.WriteLine("Name: {0}", partTimeEmployee.GetName());
            Console.WriteLine("Salary: {0}", partTimeEmployee.GetSalary());
            Console.WriteLine("Job title: {0}", partTimeEmployee.GetJobTitle());
            Console.WriteLine("------------------------------");

        }
    }
}