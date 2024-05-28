using Microsoft.AspNetCore.Mvc;

namespace News_portal
{

}
public class NewsViewModel
{
    public int Id { get; set; }
    public required string Title { get; set; }
    public required string Section { get; set; }
    public required string Author { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime PublishedAt { get; set; }
}