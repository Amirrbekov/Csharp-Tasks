using System.ComponentModel.DataAnnotations;

namespace SpectreConsole.Models;

public abstract class Instrument
{
    public Instrument() { this.Id = Guid.NewGuid(); }

    public Guid Id { get; set; }
    public string? Brand { get; set; }
    public string? Model { get; set; }
    public decimal? Price { get; set; }

    public abstract string Sound();
    public abstract string Prop();
}

public class Piano : Instrument
{
    public string? Length { get; set; }

    public override string Prop() => $"{this.GetType().Name} Prop";

    public override string Sound() => $"{this.GetType().Name} Sound";
}

public class Violet : Instrument
{
    public string? Arse { get; set; }

    public override string Prop() => $"{this.GetType().Name} Prop";

    public override string Sound() => $"{this.GetType().Name} Sound";

}

public class Guitar : Instrument
{
    public string? MagneticArray { get; set; }

    public override string Prop() => $"{this.GetType().Name} Prop";

    public override string Sound() => $"{this.GetType().Name} Sound";
}

public class Flute : Instrument
{
    public string? Material { get; set; }
    public override string Prop() => $"{this.GetType().Name} Prop";

    public override string Sound() => $"{this.GetType().Name} Sound";
}

public class Musician
{
    public Musician() {this.Id = Guid.NewGuid();}
    public Guid Id { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set;}

    public Instrument? instrument { get; set; }
}

public class BaseEntity<T> where T : struct, IEquatable<T>
{
    public T Id { get; set; }
    public virtual string Name { get; set; }
}

public class Category : BaseEntity<Guid>
{
    [Display(Name = "Category Name")]
    public override string Name { get; set; } = null!;
    [Display(Name = "Description")]
    public string? Description { get; set; }
}

public class B : BaseEntity<Guid> { }
public class C : BaseEntity<Guid> { }
public class D : BaseEntity<Guid> { }
public class E : BaseEntity<Guid> { }