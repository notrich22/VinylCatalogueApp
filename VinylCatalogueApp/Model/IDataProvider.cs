namespace VinylCatalogueApp.Model
{
    public interface IDataProvider
    {
        // 1. создание заявки
        void CreateVinylDisk(VinylDisk application);

        // 2. получение всех заявок
        List<VinylDisk> GetAllVinylDisks();

        // 3. получение информации об одной заявке по Id
        VinylDisk GetVinylDisk(int id);

        // 4. редактирование заявки
        void UpdateVinylDisk(VinylDisk application);

        // 5. удаление заявки
        void DeleteVinylDisk(int id);
    }
}
