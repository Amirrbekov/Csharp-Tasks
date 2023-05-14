using Spectre.Console;
using System.Collections;
using System.Reflection;
using System.Text;


namespace SpectreConsole;
using Models;

public static class Program
{

    public static void Main(String[] args)
    {
        Piano piano = new();
        piano.Brand = "Yamaha";
        piano.Model = "Yamaha CFX Akustik Tam Kuyruklu Piyano";
        piano.Price = 100123M;
        piano.Length = "9′ 0″";

        Musician pianist = new();
        pianist.FirstName = "Valeh";
        pianist.LastName = "Pianist";
        pianist.instrument = piano;

        Musician violinist = new()
        {
            FirstName = "Valeh",
            LastName = "Violinist",
            instrument = new Violet
            {
                Brand = "Yamaha",
                Model = "Yamaha YSV104BRO Silent Keman (Kahverengi)",
                Price = 38.03400M,
                Arse = "Hao Yun HVB92 4/4 Keman Arşesi"
            }
        };

        Musician guitarist = new()
        {
            FirstName = "Valeh",
            LastName = "Guitarist",
            instrument = new Guitar
            {
                Brand = "",
                MagneticArray = "",
                Model = "",
                Price = 0
            }
        };

        Musician fluteist = new()
        {
            FirstName = "Valeh",
            LastName = "Fluteist",
            instrument = new Flute
            {
                Brand = "",
                Model = "",
                Price = 0,
                Material = ""
            }
        };

        var musicians = new ArrayList();
        musicians.Add(pianist);
        musicians.Add(fluteist);
        musicians.Add(guitarist);
        musicians.Add(violinist);

        foreach (var musician in musicians)
        {
            StringBuilder sb = new();
            sb.Append($"{musician.GetType().Name}");
            sb.AppendLine();

            foreach (var property in musician.GetType().GetProperties())
            {
                if (property.PropertyType.Name != nameof(Instrument))
                {
                    sb.Append($"{" ",10}{property.Name,-20} : {property.GetValue(musician)}");
                    sb.AppendLine();

                }
                else
                {
                    sb.Append(property.Name);
                    var item = property.GetValue(musician, null);

                    foreach (var instrument in item.GetType().GetProperties())
                    {
                        sb.Append($"{" ",10}{instrument.Name,-20} : {instrument.GetValue(item)}");
                        sb.AppendLine();
                    }

                    var functions = item.GetType().GetMethods(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public).Where(x => !x.Name.StartsWith("get") && !x.Name.StartsWith("set")).ToList();

                    foreach (var function in functions)
                    {
                        var val = function.Invoke(item, null);
                        sb.Append($"{" ",10}{function.Name,-20} : {val}");
                        sb.AppendLine();
                    }
                }
            }

            sb.AppendLine();
            sb.AppendLine($"{new string('-', 100)}");
            sb.AppendLine();


            Console.WriteLine(sb.ToString());

            //// Create a table
            //var table = new Table();
            //table.Border(TableBorder.Square);
            //table.Expand();
            //// Add some columns
            //table.AddColumn("ID");
            //table.AddColumn(new TableColumn("FirstName").Centered());
            //table.AddColumn(new TableColumn("LastName").Centered());


            //// Add some rows
            //table.AddRow($"[green]{musician.GetType().GetProperty("Id").GetValue(musician)}[/]", "[green]Qux[/]", "[green]Qux[/]");

            //table.AddRow(new Markup("[blue]Corgi[/]"), new Panel("Waldo"));

            //// Render the table to the console
            //AnsiConsole.Write(table);

        }
        Console.WriteLine("Musician\n\n");
        // Create a table
        var table1 = new Table();
        table1.Border(TableBorder.Square);
        table1.Expand();
        // Add some columns
        table1.AddColumn("ID");
        table1.AddColumn(new TableColumn("FirstName").Centered());
        table1.AddColumn(new TableColumn("LastName").Centered());
        // Add some rows
        foreach (var musician in musicians)
        {
            table1.AddRow($"[green]{musician.GetType().GetProperty("Id").GetValue(musician)}[/]", $"[green]{musician.GetType().GetProperty("FirstName").GetValue(musician)}[/]", $"[green]{musician.GetType().GetProperty("LastName").GetValue(musician)}[/]");
        }
        // Render the table to the console
        AnsiConsole.Write(table1);


        Console.WriteLine("\n\nInstrument\n\n");

        // Create a table
        var table2 = new Table();
        table2.Border(TableBorder.Square);
        table2.Expand();
        // Add some columns
        table2.AddColumn("ID");
        table2.AddColumn(new TableColumn("Brand").Centered());
        table2.AddColumn(new TableColumn("Price").Centered());
        table2.AddColumn(new TableColumn("Prop").Centered());
        table2.AddColumn(new TableColumn("Sound").Centered());
        // Add some rows
        foreach (var musician in musicians)
        {
            foreach (var property in musician.GetType().GetProperties())
            {
                var item = property.GetValue(musician, null);
                //table2.AddRow($"[green]{item}[/]");
                foreach (var instrument in item.GetType().GetProperties())
                {
                    table2.AddRow($"[green]{instrument.GetType().GetProperty("Id").GetValue(item)}[/]");
                }
            }
        }
        // Render the table to the console
        AnsiConsole.Write(table2);
    }
}