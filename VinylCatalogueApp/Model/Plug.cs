namespace VinylCatalogueApp.Model
{
    public class Plug : IDataProvider
    {
        // иммитация уникального Id
        private static int id = 1;

        // иммитация источника данных
        private static List<VinylDisk> VinylDisks =
            new List<VinylDisk>();

        // имплементация методов-заглушек
        public void CreateVinylDisk(VinylDisk application)
        {
            application.Id = id++;  // делаем очередной id
            VinylDisks.Add(application);
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

        public void UpdateVinylDisk(VinylDisk application)
        {
            var VinylDisk = GetVinylDisk(application.Id);
            VinylDisk.Publisher = application.Publisher;
            VinylDisk.Author = application.Author;
            VinylDisk.DiskName = application.DiskName;
        }
    }
}
