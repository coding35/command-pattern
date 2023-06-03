namespace CommandPattern.Model.Abstract;

public abstract class InputControl<T> : Control
{
    protected T? Value { get; set; } = default(T);
    
    protected InputControl(int id, string label) : base(id, label)
    {

    }

    public abstract override void OnClick();

    public abstract void OnInput(T value);
    
    public T GetInputValue()
    {
        return (T)Value!;
    }
}