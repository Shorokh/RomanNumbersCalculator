using Avalonia.Controls;
using Avalonia.VisualTree;

namespace UITestsForRomanNumbersCalculator
{
    public class UnitTests
    {
        [Fact]
        public async void Test1()
        {
            var app = AvaloniaApp.GetApp();
            var mainWindow = AvaloniaApp.GetMainWindow();
            var answer = "VI";
            
            await Task.Delay(100);
            var buttonX = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Content == "I");
            var buttonDo = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Content == "+");
            var buttonY = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Content == "V");
            var buttonEq = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Content == "=");
            var buttonCE = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Content == "CE");

            var textBox = mainWindow.GetVisualDescendants().OfType<TextBox>().First();

            buttonCE.Command.Execute(buttonCE.CommandParameter);
            buttonX.Command.Execute(buttonX.CommandParameter);
            buttonDo.Command.Execute(buttonDo.CommandParameter);
            buttonY.Command.Execute(buttonY.CommandParameter);
            buttonEq.Command.Execute(buttonEq.CommandParameter);
            
            await Task.Delay(100);

            var result = (textBox.Text as string);
            Assert.True(result.Equals(answer), textBox.Text);
        }
        [Fact]
        public async void Test2()
        {
            var app = AvaloniaApp.GetApp();
            var mainWindow = AvaloniaApp.GetMainWindow();
            var answer = "IV";

            await Task.Delay(100);
            var buttonX = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Content == "V");
            var buttonDo = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Content == "-");
            var buttonY = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Content == "I");
            var buttonEq = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Content == "=");
            var buttonCE = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Content == "CE");

            var textBox = mainWindow.GetVisualDescendants().OfType<TextBox>().First();

            buttonCE.Command.Execute(buttonCE.CommandParameter);
            buttonX.Command.Execute(buttonX.CommandParameter);
            buttonDo.Command.Execute(buttonDo.CommandParameter);
            buttonY.Command.Execute(buttonY.CommandParameter);
            buttonEq.Command.Execute(buttonEq.CommandParameter);

            await Task.Delay(100);

            var result = (textBox.Text as string);

            Assert.True(result.Equals(answer), textBox.Text);
        }
        [Fact]
        public async void Test3()
        {
            var app = AvaloniaApp.GetApp();
            var mainWindow = AvaloniaApp.GetMainWindow();
            var answer = "V";

            await Task.Delay(100);
            var buttonX = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Content == "V");
            var buttonDo = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Content == "*");
            var buttonY = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Content == "I");
            var buttonEq = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Content == "=");
            var buttonCE = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Content == "CE");

            var textBox = mainWindow.GetVisualDescendants().OfType<TextBox>().First();

            buttonCE.Command.Execute(buttonCE.CommandParameter);
            buttonX.Command.Execute(buttonX.CommandParameter);
            buttonDo.Command.Execute(buttonDo.CommandParameter);
            buttonY.Command.Execute(buttonY.CommandParameter);
            buttonEq.Command.Execute(buttonEq.CommandParameter);

            await Task.Delay(1000);

            var result = (textBox.Text as string);

            Assert.True(result.Equals(answer), textBox.Text);
        }
        [Fact]
        public async void Test4()
        {
            var app = AvaloniaApp.GetApp();
            var mainWindow = AvaloniaApp.GetMainWindow();
            var answer = "V";

            await Task.Delay(100);
            var buttonX = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Content == "V");
            var buttonDo = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Content == "/");
            var buttonY = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Content == "I");
            var buttonEq = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Content == "=");
            var buttonCE = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Content == "CE");

            var textBox = mainWindow.GetVisualDescendants().OfType<TextBox>().First();

            buttonCE.Command.Execute(buttonCE.CommandParameter);
            buttonX.Command.Execute(buttonX.CommandParameter);
            buttonDo.Command.Execute(buttonDo.CommandParameter);
            buttonY.Command.Execute(buttonY.CommandParameter);
            buttonEq.Command.Execute(buttonEq.CommandParameter);

            await Task.Delay(100);

            var result = (textBox.Text as string);

            Assert.True(result.Equals(answer), textBox.Text);
        }
        [Fact]
        public async void Test5()
        {
            var app = AvaloniaApp.GetApp();
            var mainWindow = AvaloniaApp.GetMainWindow();
            var answer = "IVXLCDM";

            await Task.Delay(100);
            var buttonI = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Content == "I");
            var buttonV = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Content == "V");
            var buttonX = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Content == "X");
            var buttonL = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Content == "L");
            var buttonC = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Content == "C");
            var buttonD = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Content == "D");
            var buttonM = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Content == "M");
            var buttonCE = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Content == "CE");


            var textBox = mainWindow.GetVisualDescendants().OfType<TextBox>().First();

            buttonCE.Command.Execute(buttonCE.CommandParameter);
            buttonI.Command.Execute(buttonI.CommandParameter);
            buttonV.Command.Execute(buttonV.CommandParameter);
            buttonX.Command.Execute(buttonX.CommandParameter);
            buttonL.Command.Execute(buttonL.CommandParameter);
            buttonC.Command.Execute(buttonC.CommandParameter);
            buttonD.Command.Execute(buttonD.CommandParameter);
            buttonM.Command.Execute(buttonM.CommandParameter);
            
            await Task.Delay(100);

            var result = (textBox.Text as string);

            Assert.True(result.Equals(answer), textBox.Text);
        }
    }
}