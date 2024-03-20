using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASP_AJAX.Models;

public enum Hobby
{
    Reading,
    Writing,
    Programming,
    Gaming,
    Cooking,
    Baking,
    Drawing,
    Painting,
    Singing,
    Dancing,
    Sports,
}

public class JimboModel
{
    [Required]
    [MinLength(3)]
    [MaxLength(20)]
    public string Name { get; set; }
    [Required]
    [Range(0, 120)]
    public int Age { get; set; }
    [Required]
    [Range(0, 200)]
    public int IQ { get; set; }
    [Required]
    public Hobby[] Hobbies { get; set; }
    
    [NotMapped]
    public static readonly List<JimboModel> Jimbos = new();
    
    public static void AddJimbo(JimboModel jimbo)
    {
        Jimbos.Add(jimbo);
    }
}