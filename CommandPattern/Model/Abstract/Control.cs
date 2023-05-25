namespace CommandPattern.Model.Abstract;

// A blueprint for a control. Things a control can do.
public abstract class Control
{
    protected Control(int id, string label)
    {
        Id = id;
        Label = label;
    }
    
    private int Id { get; }
    private string Label { get;}
    private bool IsVisible { get; set; }
    private bool IsDisabled { get; set; }
    private bool Clicked { get; set; }
    
    public abstract void OnClick();
    
    public void Show()
    {
        IsVisible = true;
    }

    public void Hide()
    {
        IsVisible = false;
    }
    
    public void Disable()
    {
        IsDisabled = true;
    }
    
    public void Enable()
    {
        IsDisabled = false;
    }
    
    public bool GetIsVisible()
    {
        return IsVisible;
    }
    
    public bool GetIsDisabled()
    {
        return IsDisabled;
    }
    
    public void Click()
    {
        if (IsDisabled)
        {
            return;
        }
        Clicked = true;
        OnClick();
    }
    
    public bool? GetIsClicked()
    {
        return Clicked;
    }
    
    
    public Control GetControl()
    {
        return this;
    }
}