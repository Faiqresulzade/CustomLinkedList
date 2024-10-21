namespace Shared;

public abstract class SingletonBase<T> where T : class, new()
{
    // Lazy initialization ensures that the instance is created only when it's accessed.
    private static readonly Lazy<T> _instance = new(() => new T(), true);

    /// <summary>
    /// Property to get the singleton instance.
    /// </summary>
    public static T Instance => _instance.Value;

    /// <summary>
    /// Protected constructor to prevent external instantiation.
    /// </summary>
    /// <exception cref="InvalidOperationException"></exception>
    protected SingletonBase()
    {
        if (_instance.IsValueCreated)
            throw new InvalidOperationException($"An instance of {typeof(T).Name} already exists.");
    }

    /// <summary>
    /// Optionally, if T implements IDisposable, we can dispose of the instance.
    /// </summary>
    public static void DisposeInstance()
    {
        if (_instance.IsValueCreated && _instance.Value is IDisposable disposable) disposable.Dispose();
    }
}