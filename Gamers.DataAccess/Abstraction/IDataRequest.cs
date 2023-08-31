namespace Gamers.DataAccess.Abstraction
{
    public interface IDataRequest
    {
        public string GetSql();

        public object GetParameters();
    }

    public interface IDataRequest<TResponse> : IDataRequest
    {

    }
}
