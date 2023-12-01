using System.ComponentModel.DataAnnotations;

namespace BSFB07.Models;

public class Player {
    [Key]
    public int Id { get; set; }

    [Required]
    [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
    [StringLength(20)]
    public string? name { get; set; }

    [Display(Name = "Offensive Position")]
    [StringLength(2)]
    public string? primaryOffPos { get; set; }

    [Display(Name = "Defensive Position")]
    [StringLength(2)]
    public string? primaryDefPos { get; set; }
    
    [Display(Name = "Special Teams Position")]
    [StringLength(2)]
    public string? primarySpePos { get; set; }
    
    [Range(1, 10)]
    public int Running { get; set; }

    [Range(1, 10)]
    public int Passing { get; set; }

    [Range(1, 10)]
    public int Catching { get; set; }

    [Range(1, 10)]
    public int Kicking { get; set; }

    [Range(1, 10)]
    public int Blocking { get; set; }

    [Display(Name = "Overall")]
    [Range(1, 100)]
    public int Ovr { get; set; }

}