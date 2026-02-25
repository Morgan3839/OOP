/*************************
 * Автор: Дорожко Ксения *
 * ***********************/

using System;

class Animal {
  public string Name;
  public int Age;
  public string Habitat;
  public string Diet;
  public string Color;

    public virtual void GetInfo() {
    Console.WriteLine("Name: " + Name);
    Console.WriteLine("Age: " + Age);
    Console.WriteLine("Habitat: " + Habitat);
    Console.WriteLine("Diet: " + Diet);
    Console.WriteLine("Color: " + Color);
  }
}

class Mammal : Animal {
  public bool HasFur;
  
  public override void GetInfo() {
    base.GetInfo();
    Console.WriteLine("Fur: " + (HasFur ? "yes" : "no"));
  }
}

class Bird : Animal {
  public double WingSpan;

  public override void GetInfo() {
    base.GetInfo();
    Console.WriteLine("Wing span: " + WingSpan);
  }
}

class Fish : Animal {
  public string WaterType;

  public override void GetInfo() {
    base.GetInfo();
    Console.WriteLine("Water type: " + WaterType);
  }
}

class Reptile : Animal {
  public bool IsVenomous;

  public override void GetInfo() {
    base.GetInfo();
    Console.WriteLine("Venomous: " + (IsVenomous ? "yes" : "no"));
  }
}

class Amphibian : Animal {
  public string SkinMoisture;

  public override void GetInfo() {
    base.GetInfo();
    Console.WriteLine("Skin moisture: " + SkinMoisture);
  }
}

class AnimalManager {
  private static AnimalManager instance;
  
  private AnimalManager() {
  }

  public static AnimalManager GetInstance() {
    if (instance == null) {
      instance = new AnimalManager();
    }
    return instance;
  }
  
  public void Run() {
    Console.WriteLine("Choose animal type:");
    Console.WriteLine("1 - Mammal");
    Console.WriteLine("2 - Bird");
    Console.WriteLine("3 - Fish");
    Console.WriteLine("4 - Reptile");
    Console.WriteLine("5 - Amphibian");
    Console.Write("Enter choice: ");
    
    int choice;
    choice = int.Parse(Console.ReadLine());

    Animal animal;
    animal = null;

    if (choice == 1) {
      Mammal mammal;
      mammal = new Mammal();
      
      Console.Write("\nEnter name: ");
      mammal.Name = Console.ReadLine();
      
      Console.Write("Enter age: ");
      mammal.Age = int.Parse(Console.ReadLine());
      
      Console.Write("Enter habitat: ");
      mammal.Habitat = Console.ReadLine();
      
      Console.Write("Enter diet: ");
      mammal.Diet = Console.ReadLine();
      
      Console.Write("Enter color: ");
      mammal.Color = Console.ReadLine();
      
      Console.Write("Does the animal have fur? (true/false): ");
      mammal.HasFur = bool.Parse(Console.ReadLine());
      
      animal = mammal;
      
    } else if (choice == 2) {
      Bird bird;
      bird = new Bird();
      
      Console.Write("\nEnter name: ");
      bird.Name = Console.ReadLine();
      
      Console.Write("Enter age: ");
      bird.Age = int.Parse(Console.ReadLine());
      
      Console.Write("Enter habitat: ");
      bird.Habitat = Console.ReadLine();
      
      Console.Write("Enter diet: ");
      bird.Diet = Console.ReadLine();
      
      Console.Write("Enter color: ");
      bird.Color = Console.ReadLine();
      
      Console.Write("Enter wing span: ");
      bird.WingSpan = double.Parse(Console.ReadLine());
      
      animal = bird;
      
    } else if (choice == 3) {
      Fish fish;
      fish = new Fish();
      
      Console.Write("\nEnter name: ");
      fish.Name = Console.ReadLine();
      
      Console.Write("Enter age: ");
      fish.Age = int.Parse(Console.ReadLine());
      
      Console.Write("Enter habitat: ");
      fish.Habitat = Console.ReadLine();
      
      Console.Write("Enter diet: ");
      fish.Diet = Console.ReadLine();
      
      Console.Write("Enter color: ");
      fish.Color = Console.ReadLine();
      
      Console.Write("Enter water type (fresh/sea): ");
      fish.WaterType = Console.ReadLine();
      
      animal = fish;
      
    } else if (choice == 4) {
      Reptile reptile;
      reptile = new Reptile();
      
      Console.Write("\nEnter name: ");
      reptile.Name = Console.ReadLine();
      
      Console.Write("Enter age: ");
      reptile.Age = int.Parse(Console.ReadLine());
      
      Console.Write("Enter habitat: ");
      reptile.Habitat = Console.ReadLine();
      
      Console.Write("Enter diet: ");
      reptile.Diet = Console.ReadLine();
      
      Console.Write("Enter color: ");
      reptile.Color = Console.ReadLine();
      
      Console.Write("Venomous? (true/false): ");
      reptile.IsVenomous = bool.Parse(Console.ReadLine());
      
      animal = reptile;
      
    } else if (choice == 5) {
      Amphibian amphibian;
      amphibian = new Amphibian();
      
      Console.Write("\nEnter name: ");
      amphibian.Name = Console.ReadLine();
      
      Console.Write("Enter age: ");
      amphibian.Age = int.Parse(Console.ReadLine());
      
      Console.Write("Enter habitat: ");
      amphibian.Habitat = Console.ReadLine();
      
      Console.Write("Enter diet: ");
      amphibian.Diet = Console.ReadLine();
      
      Console.Write("Enter color: ");
      amphibian.Color = Console.ReadLine();
      
      Console.Write("Enter skin moisture: ");
      amphibian.SkinMoisture = Console.ReadLine();
      
      animal = amphibian;
      
    } else {
      Console.WriteLine("Invalid choice!");
      return;
    }

    Console.WriteLine("\nAnimal information:");
    animal.GetInfo();
  }
}

class Program {
  static void Main() {
    AnimalManager manager;
    manager = AnimalManager.GetInstance();
    manager.Run();
  }
}
