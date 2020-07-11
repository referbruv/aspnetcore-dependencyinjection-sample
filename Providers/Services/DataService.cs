using DiReadersApp.Providers.Repositories;

namespace DiReadersApp.Providers.Services
{
    public interface IDataService
    {
        IReadersRepository Readers { get; }
    }

    public class DataService : IDataService
    {
        private readonly IReadersRepository _readers;

        public DataService(IReadersRepository readers)
        {
            _readers = readers;
        }

        public IReadersRepository Readers => _readers;
    }
}