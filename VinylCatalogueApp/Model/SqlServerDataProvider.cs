using VinylCatalogueApp.Migrations;

namespace VinylCatalogueApp.Model
{
    public class SqlServerDataProvider : IDataProvider
    {
        public void CreateVinylDisk(VinylDisk disk)
        {
            using (var context = new VinylDiskContext())
            {
                context.Disks.Add(disk);
                context.SaveChanges();
            }
        }

        public void DeleteVinylDisk(int id)
        {
            using (var context = new VinylDiskContext())
            {
                context.Remove(context.Disks.First(disk => disk.Id == 20));
                context.SaveChanges();
            }
        }

        public List<VinylDisk> GetAllVinylDisks()
        {
            using (var context = new VinylDiskContext())
            {
                return context.Disks.ToList();
            }
        }

        public VinylDisk GetVinylDisk(int id)
        {
            using (var context = new VinylDiskContext())
            {
                return context.Disks.First(disk => disk.Id == id);
            }
        }

        public void UpdateVinylDisk(VinylDisk disk)
        {
            using(var context = new VinylDiskContext())
            {
                context.Disks.First(Disk => Disk.Id == disk.Id).Author = disk.Author;
                context.Disks.First(Disk => Disk.Id == disk.Id).Publisher = disk.Publisher;
                context.Disks.First(Disk => Disk.Id == disk.Id).DiskName = disk.DiskName;
                context.SaveChanges();
            }
        }
    }
}
