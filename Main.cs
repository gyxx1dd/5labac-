using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace _3labac_
{
    public interface IDisplayable
    {
        void DisplayInfo();
    }

    public interface IComparable<T>
    {
        int CompareTo(T other);
    }

    public interface ICloneable
    {
        object Clone();
    }

    public class Animal : IDisplayable, IComparable<Animal>, ICloneable
    {
        public double Weight { get; set; }
        public int Age { get; set; }
        public double DailyMaintenanceCost { get; set; }

        public Animal(double weight, int age, double dailyMaintenanceCost)
        {
            Weight = weight;
            Age = age;
            DailyMaintenanceCost = dailyMaintenanceCost;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Weight: {Weight} kg");
            Console.WriteLine($"Age: {Age} years");
            Console.WriteLine($"Daily Maintenance Cost: {DailyMaintenanceCost}$");
        }

        public int CompareTo(Animal other)
        {
            if (other == null)
                return 1;
            return this.Weight.CompareTo(other.Weight);
        }

        public object Clone()
        {
            return new Animal(this.Weight, this.Age, this.DailyMaintenanceCost);
        }
    }

    public class Wolf : Animal
    {
        public string Breed { get; set; }
        public string NaturalHabitat { get; set; }

        public Wolf(double weight, int age, double dailyMaintenanceCost, string breed, string naturalHabitat)
            : base(weight, age, dailyMaintenanceCost)
        {
            Breed = breed;
            NaturalHabitat = naturalHabitat;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Breed: {Breed}");
            Console.WriteLine($"Natural Habitat: {NaturalHabitat}");
        }

        public int CompareTo(Wolf other)
        {
            if (other == null)
                return 1;
            return this.Weight.CompareTo(other.Weight);
        }

        public new object Clone()
        {
            return new Wolf(this.Weight, this.Age, this.DailyMaintenanceCost, this.Breed, this.NaturalHabitat);
        }
    }
    public  class WolfCollection
    {
        private ArrayList wolvesArrayList = new ArrayList();
        private List<Wolf> wolvesList = new List<Wolf>();
        public void AddToArrayList(Wolf wolf)
        {
            wolvesArrayList.Add(wolf);
        }

        public void AddToList(Wolf wolf)
        {
            wolvesList.Add(wolf);
        }

        public string DisplayArrayList()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Wolf wolf in wolvesArrayList)
            {
                sb.AppendLine($"Wolf Information:\n" +
                                $"Weight: {wolf.Weight} kg\n" +
                                $"Age: {wolf.Age} years\n" +
                                $"Daily Maintenance Cost: {wolf.DailyMaintenanceCost}$\n" +
                                $"Breed: {wolf.Breed}\n" +
                                $"Natural Habitat: {wolf.NaturalHabitat}\n");
            }
            return sb.ToString();
        }

        public string DisplayList()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Wolf wolf in wolvesList)
            {
                sb.AppendLine($"Wolf Information:\n" +
                                $"Weight: {wolf.Weight} kg\n" +
                                $"Age: {wolf.Age} years\n" +
                                $"Daily Maintenance Cost: {wolf.DailyMaintenanceCost}$\n" +
                                $"Breed: {wolf.Breed}\n" +
                                $"Natural Habitat: {wolf.NaturalHabitat}\n");
            }
            return sb.ToString();
        }
    }
}
