using System.ComponentModel.DataAnnotations;

namespace BSFB07.Models;

public class Player {
    public enum OffPosition {
        QB, RB, WR, C
    }
    public enum DefPosition {
        DL, LB, CB, S
    }
    public enum SpePosition {
        K, 
    }
    
    [Key]
    public int ID { get; set; }

    [Required]
    [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
    [StringLength(20)]
    public string? name { get; set; }

    public OffPosition primaryOffPos { get; set; }

    public DefPosition primaryDefPos { get; set; }
    
    public SpePosition primarySpePos { get; set; }
    
    [Range(1, 10)]
    public int running { get; set; }

    [Range(1, 10)]
    public int passing { get; set; }

    [Range(1, 10)]
    public int catching { get; set; }

    [Range(1, 10)]
    public int kicking { get; set; }

    [Range(1, 10)]
    public int blocking { get; set; }

    [Range(1, 10)]
    public int ovr { get; set; }

}