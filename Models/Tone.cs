namespace Tones.Models
{
    public class Tone
    {
    public int ToneId {get; set;}	// Primary Key
    public string FirstName {get; set;}= string.Empty;
    public string LastName {get; set;} =null!;
    public string Album {get;set;} =null!;
    public string Genre {get; set;} = string.Empty;
    public int Year{get; set;}
    public string Title {get; set;} = string.Empty;
    }
}
