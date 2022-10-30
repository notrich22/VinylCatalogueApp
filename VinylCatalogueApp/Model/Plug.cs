namespace VinylCatalogueApp.Model
{
    public class Plug : IDataProvider
    {
        // иммитация уникального Id
        private static int id = 4;

        // иммитация источника данных
        private static List<VinylDisk> VinylDisks =
            new List<VinylDisk>()
            {
                new VinylDisk()
                {
                    Id = 1,
                    Author="Metallica",
                    Publisher="Etwas Records",
                    DiskName="Kill'em all Full album"
                    
                },
                new VinylDisk()
                {
                    Id = 2,
                    Author="Led Zeppelin",
                    Publisher="Etwas Records",
                    DiskName="Stairway to heaven"
                },
                new VinylDisk()
                {
                    Id = 3,
                    Author="Metallica",
                    Publisher="Etwas Records",
                    DiskName="Death magnetic"
                },
            };

        // имплементация методов-заглушек
        public void CreateVinylDisk(VinylDisk disk)
        {
            disk.Id = id++;  // делаем очередной id
            VinylDisks.Add(disk);
        }

        public void DeleteVinylDisk(int id)
        {
            VinylDisks.Remove(GetVinylDisk(id));
        }

        public List<VinylDisk> GetAllVinylDisks()
        {
            return VinylDisks;
        }

        public VinylDisk GetVinylDisk(int id)
        {
            return VinylDisks.First(obj => obj.Id == id);
        }

        public void UpdateVinylDisk(VinylDisk disk)
        {
            var VinylDisk = GetVinylDisk(disk.Id);
            VinylDisk.Publisher = disk.Publisher;
            VinylDisk.Author = disk.Author;
            VinylDisk.DiskName = disk.DiskName;
        }
    }
}
