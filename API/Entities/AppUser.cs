namespace API.Entities;

public class AppUser
{
    public int Id { get; set; } //primary key (kiedy inna nazwa, dodaj [Key] nad polem- Id jest domyslne)
    public required string UserName { get; set; }
}
