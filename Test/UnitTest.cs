using CommandPattern.Implementation.Command;
using CommandPattern.Implementation.Control;
using CommandPattern.Model.Abstract;
using CommandPattern.Model.Implementation;

namespace Test;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void ButtonShouldBeHiddenOnPageLoad()
    {
        // receiver
        ActionControl actionControl = new ActionControl();
        Button button = new Button(1, "button1");
        
        // concrete command
        ControlHiddenCommand? hide = new ControlHiddenCommand(button);
        ControlDisableCommand? disable = new ControlDisableCommand(button);
        
        // invoker
        actionControl.SetCommand(hide);
        actionControl.SetCommand(disable);
        
        // execute
        actionControl.OnPageLoad();
        
        Assert.IsFalse(button.GetIsVisible());
    }

    [Test]
    public void ButtonShouldBeVisibleOnPageLoad()
    {
        ActionControl actionControl = new ActionControl();
        Button button = new Button(1, "button1");
        ControlVisibleCommand? show = new ControlVisibleCommand(button);
        ControlEnableCommand? enable = new ControlEnableCommand(button);

        actionControl.SetCommand(show);
        actionControl.SetCommand(enable);
        actionControl.OnPageLoad();
        Assert.IsTrue(button.GetIsVisible());
    }

    [Test]
    public void HomePageShouldOnlyHaveButtonsVisible()
    {
        HomePage homePage = new HomePage(new List<Control>()
        {
            new Button(1, "button1"),
            new Toggle(2, "toggle1"),
            new Input(3, "input1"),
            new Button(4, "button2")
        });
        
        foreach (var control in Page.Controls!)
        {        
            ActionControl actionControl = new ActionControl();
            if (control is Button)
            {
                ControlVisibleCommand? show = new ControlVisibleCommand(control);
                ControlEnableCommand? enable = new ControlEnableCommand(control);
                ControlClickCommand? onClick = new ControlClickCommand(control);
                actionControl.SetCommand(show);
                actionControl.SetCommand(enable);
                actionControl.SetCommand(onClick);
            }
            else
            {
                ControlHiddenCommand? hide = new ControlHiddenCommand(control);
                ControlDisableCommand? disable = new ControlDisableCommand(control);
                ControlClickCommand? onClick = new ControlClickCommand(control);
                actionControl.SetCommand(hide);
                actionControl.SetCommand(disable);
                actionControl.SetCommand(onClick);
            }        
            actionControl.OnPageLoad();
        }
        
        foreach (var control in Page.Controls)
        {
            control.Click();
            if (control is Button)
            {
                Assert.IsTrue(control.GetIsVisible());
                Assert.IsFalse(control.GetIsDisabled());            
                Assert.IsTrue(control.GetIsClicked());
            }
            else
            {
                Assert.IsFalse(control.GetIsVisible());
                Assert.IsTrue(control.GetIsDisabled());
                Assert.IsFalse(control.GetIsClicked());
            }
        }
    }
    
    [Test]
    public void HomePageShouldOnlyHaveButtonsVisibleWithLambda()
    {
        HomePage homePage = new HomePage(new List<Control>()
        {
            new Button(1, "button1"),
            new Toggle(2, "toggle1"),
            new Input(3, "input1"),
            new Button(4, "button2")
        });
        
        foreach (var control in Page.Controls!)
        {        
            ActionControl actionControl = new ActionControl();
            if (control is Button)
            {
                actionControl.SetCommand(() =>  { 
                    control.Show();
                    control.Enable();
                    control.OnClick();
                    return null;
                });
        
            }
            else
            {
                actionControl.SetCommand(() => {
                    control.Hide();
                    control.Disable();
                    control.OnClick();
                    return null;
                });
            }        
            actionControl.OnPageLoad();
        }
        
        foreach (var control in Page.Controls)
        {
            control.Click();
            if (control is Button)
            {
                Assert.IsTrue(control.GetIsVisible());
                Assert.IsFalse(control.GetIsDisabled());            
                Assert.IsTrue(control.GetIsClicked());
            }
            else
            {
                Assert.IsFalse(control.GetIsVisible());
                Assert.IsTrue(control.GetIsDisabled());
                Assert.IsFalse(control.GetIsClicked());
            }
        }
    }
    
    [Test]
    public void CommandsBeShouldRemoveOnPageUnload()
    {
        // receiver
        ActionControl actionControl = new ActionControl();
        Button button = new Button(1, "button1");
        
        // concrete command
        ControlHiddenCommand? hide = new ControlHiddenCommand(button);
        ControlDisableCommand? disable = new ControlDisableCommand(button);
        
        // invoker
        actionControl.SetCommand(hide);
        actionControl.SetCommand(disable);
        
        // execute
        actionControl.OnPageLoad();
        actionControl.OnPageUnload();
        Assert.IsEmpty(actionControl.GetCommands()!);
    }
    
    [Test]
    public void CommandShouldBeRemovedOnRemoveAction()
    {
        // receiver
        ActionControl actionControl = new ActionControl();
        Button button = new Button(1, "button1");
        
        // concrete command
        ControlHiddenCommand? hide = new ControlHiddenCommand(button);
        ControlDisableCommand? disable = new ControlDisableCommand(button);
        
        // invoker
        actionControl.SetCommand(hide);
        actionControl.SetCommand(disable);
        actionControl.RemoveCommand(hide);

        // execute
        actionControl.OnPageLoad();

        Assert.That(actionControl.GetCommands()!.Count, Is.EqualTo(1));
    }
    
    [Test]
    public void AllCommandShouldBeRemovedOnRemoveAllAction()
    {
        // receiver
        ActionControl actionControl = new ActionControl();
        Button button = new Button(1, "button1");
        
        // concrete command
        ControlHiddenCommand? hide = new ControlHiddenCommand(button);
        ControlDisableCommand? disable = new ControlDisableCommand(button);
        
        // invoker
        actionControl.SetCommand(hide);
        actionControl.SetCommand(disable);
        actionControl.RemoveAllCommands();
        
        // execute
        actionControl.OnPageLoad();

        Assert.That(actionControl.GetCommands()!.Count, Is.EqualTo(0));
    }
    

}