namespace Pixzor.Models
{
    public class Photo
    {
        public int Id { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public string Url { get; set; }
        public string Photographer { get; set; }
        public string PhotographerUrl { get; set; }
        public int PhotographerId { get; set; }
        public string AvgColor { get; set; }
        public Source Src { get; set; }
        public bool Liked { get; set; }
        public string Alt { get; set; }
    }
}