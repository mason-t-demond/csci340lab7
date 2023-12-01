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

    [Required]
    [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
    [StringLength(20)]
    public string? name;

    public OffPosition primaryOffPos;

    public DefPosition primaryDefPos;
    
    public SpePosition primarySpePos;
    
    [Range(1, 10)]
    public int running;

    [Range(1, 10)]
    public int passing;

    [Range(1, 10)]
    public int catching;

    [Range(1, 10)]
    public int kicking;

    [Range(1, 10)]
    public int blocking;

    [Range(1, 10)]
    public int ovr;

}