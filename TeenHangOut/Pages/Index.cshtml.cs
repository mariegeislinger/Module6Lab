using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TeenHangOut.Pages;

public class IndexModel : PageModel
{
    public User[] Users { get; set; }
    public Post[] Posts { get; set; }

    public void OnGet()
    {
        // Create array of users
        Users = new User[]
        {
            new User("MusicLover", 15, "Purple"),
            new User("GamerGirl", 16, "Red"),
            new User("BookwormBen", 15, "Yellow"),
            new User("StarWarsFanGirl", 17, "Green")
        };

        // Create array of posts
        Posts = new Post[]
        {
            new Post("GamerGirl", "Anyone want to play online later?", 30),
            new Post("BookwormBen", "Reading the best book ever!", 15),
            new Post("MusicLover", "Concert next week! So excited!", 22),
            new Post("StarWarsFanGirl", "Yoda the one for me.")
        };
    }
}