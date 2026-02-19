/*************************
 * Автор: Дорожко Ксения *
 * ***********************/

using System;

class Document {
  public string Name;
  public string Author;
  public string Keywords;
  public string Topic;
  public string FilePath;

  public virtual void ShowInfo() {
    Console.WriteLine("Name: " + Name);
    Console.WriteLine("Author: " + Author);
    Console.WriteLine("Keywords: " + Keywords);
    Console.WriteLine("Topic: " + Topic);
    Console.WriteLine("File Path: " + FilePath);
  }
}

class WordDocument : Document {
  public int FontSize;
  
  public override void ShowInfo() {
    base.ShowInfo();
    Console.WriteLine("Font Size: " + FontSize);
  }
}

class PdfDocument : Document {
  public int PdfVersion;

  public override void ShowInfo() {
    base.ShowInfo();
    Console.WriteLine("PDF Version: " + PdfVersion);
  }
}

class ExcelDocument : Document {
  public int SheetCount;

  public override void ShowInfo() {
    base.ShowInfo();
    Console.WriteLine("Sheet Count: " + SheetCount);
  }
}

class TxtDocument : Document {
  public int CharacterCount;

  public override void ShowInfo() {
    base.ShowInfo();
    Console.WriteLine("Character Count: " + CharacterCount);
  }
}

class HtmlDocument : Document {
  public bool HasCss;

  public override void ShowInfo() {
    base.ShowInfo();
    Console.WriteLine("Has CSS: " + HasCss);
  }
}

class DocumentManager {
  private static DocumentManager instance;
  
  private DocumentManager() {
  }

  public static DocumentManager GetInstance() {
    if (instance == null) {
      instance = new DocumentManager();
    }
    return instance;
  }

  public void Run() {
    Console.WriteLine("Choose document type:");
    Console.WriteLine("1 - Word");
    Console.WriteLine("2 - PDF");
    Console.WriteLine("3 - Excel");
    Console.WriteLine("4 - TXT");
    Console.WriteLine("5 - HTML");
    Console.Write("Enter choice: ");
    
    int choice;
    choice = int.Parse(Console.ReadLine());

    Document document;
    document = null;

    if (choice == 1) {
      WordDocument word = new WordDocument();
      
      Console.Write("\nEnter Name: ");
      word.Name = Console.ReadLine();
      
      Console.Write("Enter Author: ");
      word.Author = Console.ReadLine();
      
      Console.Write("Enter Keywords: ");
      word.Keywords = Console.ReadLine();
      
      Console.Write("Enter Topic: ");
      word.Topic = Console.ReadLine();
      
      Console.Write("Enter File Path: ");
      word.FilePath = Console.ReadLine();
      
      Console.Write("Enter Font Size: ");
      word.FontSize = int.Parse(Console.ReadLine());
      
      document = word;
      
    } else if (choice == 2) {
      PdfDocument pdf = new PdfDocument();
      
      Console.Write("\nEnter Name: ");
      pdf.Name = Console.ReadLine();
      
      Console.Write("Enter Author: ");
      pdf.Author = Console.ReadLine();
      
      Console.Write("Enter Keywords: ");
      pdf.Keywords = Console.ReadLine();
      
      Console.Write("Enter Topic: ");
      pdf.Topic = Console.ReadLine();
      
      Console.Write("Enter File Path: ");
      pdf.FilePath = Console.ReadLine();
      
      Console.Write("Enter PDF Version (number): ");
      pdf.PdfVersion = int.Parse(Console.ReadLine());
      
      document = pdf;
      
    } else if (choice == 3) {
      ExcelDocument excel = new ExcelDocument();
      
      Console.Write("\nEnter Name: ");
      excel.Name = Console.ReadLine();
      
      Console.Write("Enter Author: ");
      excel.Author = Console.ReadLine();
      
      Console.Write("Enter Keywords: ");
      excel.Keywords = Console.ReadLine();
      
      Console.Write("Enter Topic: ");
      excel.Topic = Console.ReadLine();
      
      Console.Write("Enter File Path: ");
      excel.FilePath = Console.ReadLine();
      
      Console.Write("Enter Sheet Count (number): ");
      excel.SheetCount = int.Parse(Console.ReadLine());
      
      document = excel;
      
    } else if (choice == 4) {
      TxtDocument txt = new TxtDocument();
      
      Console.Write("\nEnter Name: ");
      txt.Name = Console.ReadLine();
      
      Console.Write("Enter Author: ");
      txt.Author = Console.ReadLine();
      
      Console.Write("Enter Keywords: ");
      txt.Keywords = Console.ReadLine();
      
      Console.Write("Enter Topic: ");
      txt.Topic = Console.ReadLine();
      
      Console.Write("Enter File Path: ");
      txt.FilePath = Console.ReadLine();
      
      Console.Write("Enter Character Count: ");
      txt.CharacterCount = int.Parse(Console.ReadLine());
      
      document = txt;
      
    } else if (choice == 5) {
      HtmlDocument html = new HtmlDocument();
      
      Console.Write("\nEnter Name: ");
      html.Name = Console.ReadLine();
      
      Console.Write("Enter Author: ");
      html.Author = Console.ReadLine();
      
      Console.Write("Enter Keywords: ");
      html.Keywords = Console.ReadLine();
      
      Console.Write("Enter Topic: ");
      html.Topic = Console.ReadLine();
      
      Console.Write("Enter File Path: ");
      html.FilePath = Console.ReadLine();
      
      Console.Write("Does it have CSS? (true/false): ");
      html.HasCss = bool.Parse(Console.ReadLine());
      
      document = html;
      
    } else {
      Console.WriteLine("Invalid choice!");
      return;
    }

    Console.WriteLine("\nDocument details:");
    document.ShowInfo();
  }
}

class Program {
  static void Main() {
    DocumentManager manager;
    manager = DocumentManager.GetInstance();
    manager.Run();
  }
}