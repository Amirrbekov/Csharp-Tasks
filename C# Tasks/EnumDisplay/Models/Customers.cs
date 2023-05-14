using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace Enum_Display.Models;

public enum Status : byte
{
    None = 0,

    [Display(Name = "Aktif Kullanıcıları Listeler")]
    Active = 1,

    [Display(Name = "Pasif Kullanıcıları Listeler")]
    Passive,

    [Display(Name = "Silinmiş Kullanıcıları Listeler")]
    Deleted,

    [Display(Name = "Kaydını Dondurmuş Kullanıcıları Listeler")]
    Holiday
}

public class Customers
{
    public Status Status { get; set; }
    public void DisplayName()
    {
        var prop = typeof(Status).GetFields();
        foreach (var field in prop)
        {
            var displayAtr = field.GetCustomAttribute(typeof(DisplayAttribute)) as DisplayAttribute;
            if (displayAtr != null)
            {
                Console.WriteLine($"{field.Name} => {displayAtr.Name}");
            }
        }
    }
}