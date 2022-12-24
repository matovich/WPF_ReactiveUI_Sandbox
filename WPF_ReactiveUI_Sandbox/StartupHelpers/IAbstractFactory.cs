namespace WPF_ReactiveUI_Sandbox.StartupHelpers
{
    public interface IAbstractFactory<T>
    {
        T Create();
    }
}