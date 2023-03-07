
Console.WriteLine("My Wishes");

List<Wish> wishes = new List<Wish>();

wishes.Add(new Wish { Description = "An original eight track of William Shatner's 'Lucy in the Sky with Diamonds'" });
wishes.Add(new Wish { Description = "The ability to think of interesting wishes on short notice" });
wishes.Add(new Wish { Description = "World peace, but not the kind of world peace where all the humans are removed from existence" });
wishes.Add(new Wish { Description = "A washtub of Skittles" });
wishes.Add(new Wish { Description = "Some kind of bird that can be trained to deliver messages" });
wishes.Add(new Wish { Description = "A self-cleaning house" });


foreach (var wish in wishes)
{
    Console.WriteLine(wish.Description);
}


public class Wish
{
    public string Description { get; set; } = default!;
}