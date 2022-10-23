namespace VinylCatalogueApp.Model
{
    public class VinylDisk
    {
        public int Id { get; set; }
        public string? Author { get; set; }
        public string? Publisher { get; set; }
        public string? DiskName { get; set; }
        public override string ToString() { return $"{this.Id}) Publisher:{this.Publisher};{this.Author} - {this.DiskName}"; }
    }
}
