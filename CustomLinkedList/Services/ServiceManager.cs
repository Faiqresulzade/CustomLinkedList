global using Contracts;
global using Shared;
namespace Services;

public sealed class ServiceManager<T>
{
    public IAddService<T> AddService => new AddService<T>();
    public IGetService<T> GetService => new GetService<T>();
    public IRemoveService<T> RemoveService => new RemoveService<T>();
}