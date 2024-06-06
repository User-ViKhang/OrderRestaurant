namespace RestaurentAPI.Models
{
    public class ResponeAPI<T> : ResponeModel<T>
    {
        public ResponeAPI(T resultOject)
        {
            message = "success";
            result = true;
            data = resultOject;
        }
    }
}
