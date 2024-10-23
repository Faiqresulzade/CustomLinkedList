global using Contracts;
global using Shared;
namespace Services;

public sealed class ServiceManager<T>
{
    private readonly IAddService<T> _addService;
    private readonly IGetService<T> _getService;
    private readonly IRemoveService<T> _removeService;

    public ServiceManager()
    {
        _addService = new AddService<T>();
        _getService = new GetService<T>();
        _removeService = new RemoveService<T>();
    }

    public IAddService<T> AddService => _addService;
    public IGetService<T> GetService => _getService;
    public IRemoveService<T> RemoveService => _removeService;
}