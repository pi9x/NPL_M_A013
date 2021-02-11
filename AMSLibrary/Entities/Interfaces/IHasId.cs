namespace AMSLibrary.Entities
{
    interface IHasId
    {
        string GetId();
        string GetPrefix();
        void SetId(string id);
    }
}
