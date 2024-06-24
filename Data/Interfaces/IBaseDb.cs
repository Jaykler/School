namespace School.Data.Interfaces
{
    public interface IBaseDB<TModel,TAddModel, TUpdateModel, TRemoveModel> where TModel : class
    {
        List<TModel> GetAll();
        //List<TModel> GetModelById(int id);

        TModel GetModelById(int id);

        void Save(TAddModel addModel);
        void Update(TUpdateModel updateModel);
        void Remove(TRemoveModel removeModel);
        

    }
}
