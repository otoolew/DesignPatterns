using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Adventure;
using DesignPatterns.DecoratorPattern;
using DesignPatterns.EventPattern;
using DesignPatterns.ObserverPattern;

namespace DesignPatterns
{
    // Adventure Delegate
    public delegate void AttackPerformedHandler(Actor attacker, Actor defender);

    class Program
    {
        static void Main(string[] args)
        {
            Actor player = new Human("Bill", 10, 3);
            
            Actor orcEnemy = new Orc("Orc", 100, 10, 3);



            // Using the delegate                                               Method HERE!
            AttackPerformedHandler attackDelegate = new AttackPerformedHandler(AttackPerformed);
            attackDelegate(player, orcEnemy);
            attackDelegate(orcEnemy, player);
            
            //PerformSimpleAction();
            //ShowEventPattern();
            //ShowObserverPattern();
            //ShowDecoratorPattern();
            ShowEnd();
        }
        // Attack Delegate Metho
        public static void AttackPerformed(Actor attacker, Actor defender)
        {
            int damage = attacker.Strength - defender.Defense;                          
            defender.DefensiveAction();
            defender.SubtractHealthPoints(damage);
            defender.GetHealthPoints();
            Console.WriteLine(defender.Name + " was hit for " + damage + " damage.");
            Console.WriteLine(defender.Name + " now has " + defender.GetHealthPoints() + " HP.");
        }
        public static void Worker_WorkPerformed(object sender, WorkPerformedEventArgs e)
        {
            Console.WriteLine(e.WorkType + " for " + e.Hours + " Hour(s)");
        }
        public static void Worker_WorkCompleted(object sender, EventArgs e)
        {
            // This throws since there is no event arguments!
            //Console.WriteLine(e.WorkType + " Complete!"); 
            Console.WriteLine("Work Complete!");
        }

        public static void ShowObserverPattern()
        {
            WeatherData weatherData = new WeatherData();
            CurrentConditionsDisplay currentDisplay = new CurrentConditionsDisplay(weatherData);

            weatherData.SetMeasurements(80f, 65f, 30.4f);
            weatherData.SetMeasurements(82f, 70f, 29.2f);
            weatherData.SetMeasurements(78f, 90f, 27.8f);
        }
        public static void ShowDecoratorPattern()
        {
            Beverage beverage = new Espresso();
            Console.WriteLine(beverage.GetDescription()
            + " $" + beverage.Cost());

            Beverage beverage3 = new HouseBlend();
            beverage3 = new Mocha(beverage3);
            beverage3 = new WhippedCream(beverage3);
            Console.WriteLine(beverage3.GetDescription() + " $" + beverage3.Cost());
            // End of Program
        }
        public static void ShowEventPattern()
        {
            var worker = new Worker();
            worker.WorkPerformed += new EventHandler<WorkPerformedEventArgs>(Worker_WorkPerformed);
            worker.WorkCompleted += new EventHandler(Worker_WorkCompleted);
            worker.DoWork(3, WorkType.CutGrass); // WOW using void method in a static method!
        }
        public static void PerformSimpleAction()
        {
            Action<string> messageTarget;
            messageTarget = Console.WriteLine;
            messageTarget("Invoking Action!");
        }
        public static void PerformPolyMorphism()
        {

        }


        public static void ShowEnd()
        {
            // End of Program
            Console.Write("---------End---------");
            Console.ReadKey();
        }
    }
}
