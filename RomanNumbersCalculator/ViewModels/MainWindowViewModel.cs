using Avalonia.Controls;
using Avalonia.Controls.Notifications;
using DynamicData;
using ReactiveUI;
using RomanNumbersCalculator.Models;
using RomanNumbersCalculator.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reactive;
using System.Security.Cryptography;
using System.Text;

namespace RomanNumbersCalculator.ViewModels
{

    public class MainWindowViewModel : ViewModelBase
    {
        string currentNumberStringRepresentation = "";
        string currentOperationStringRepresentation = "";
        Stack<RomanNumberExtend> StackRomanNumbers = new Stack<RomanNumberExtend>();
        public MainWindowViewModel()
        {
            //AddNumber = ReactiveCommand.Create<string, Unit>(str => { str = ""; return Unit.Default; });
            AddNumber = ReactiveCommand.Create<string>(str =>
            {
                if (currentNumberStringRepresentation != "#ERROR")
                {
                    if (currentOperationStringRepresentation == "=")
                    {
                        CurrentOperationStringRepresentation = "";
                        CurrentNumberStringRepresentation = "";
                        StackRomanNumbers.Clear();
                    }
                    CurrentNumberStringRepresentation += str;
                }
                else
                {
                    CurrentNumberStringRepresentation = str;
                }
            });
            PlusCommand = ReactiveCommand.Create(() => {
                if (currentNumberStringRepresentation == "#ERROR")
                {
                    return;
                }
                if (currentNumberStringRepresentation == "")
                {
                    if (currentOperationStringRepresentation != "")
                    {
                        currentOperationStringRepresentation = "+";
                    }
                    return;
                }
                if (currentOperationStringRepresentation == "=")
                {
                    currentOperationStringRepresentation = "+";
                    CurrentNumberStringRepresentation = "";
                    return;
                }
                try
                {
                    RomanNumberExtend newNumber = new RomanNumberExtend(currentNumberStringRepresentation);
                    if (currentOperationStringRepresentation == "")
                    {
                        currentOperationStringRepresentation = "+";
                        StackRomanNumbers.Push(newNumber);
                        CurrentNumberStringRepresentation = "";
                    }
                    else
                    {
                        if (currentOperationStringRepresentation == "+")
                        {
                            StackRomanNumbers.Push(StackRomanNumbers.Pop() + newNumber);
                        }
                        if (currentOperationStringRepresentation == "-")
                        {
                            StackRomanNumbers.Push(StackRomanNumbers.Pop() - newNumber);
                        }
                        if (currentOperationStringRepresentation == "*")
                        {
                            StackRomanNumbers.Push(StackRomanNumbers.Pop() * newNumber);
                        }
                        if (currentOperationStringRepresentation == "/")
                        {
                            StackRomanNumbers.Push(StackRomanNumbers.Pop() / newNumber);
                        }
                        currentOperationStringRepresentation = "+";
                        CurrentNumberStringRepresentation = "";
                    }
                }
                catch (RomanNumberException ex)
                {
                    CurrentNumberStringRepresentation = ex.Message;
                    currentOperationStringRepresentation = "";
                }
            });
            SubCommand = ReactiveCommand.Create(() => {
                if (currentNumberStringRepresentation == "#ERROR")
                {
                    return;
                }
                if (currentNumberStringRepresentation == "")
                {
                    if (currentOperationStringRepresentation != "")
                    {
                        currentOperationStringRepresentation = "-";
                    }
                    return;
                }
                if (currentOperationStringRepresentation == "=")
                {
                    currentOperationStringRepresentation = "-";
                    CurrentNumberStringRepresentation = "";
                }
                try
                {
                    RomanNumberExtend newNumber = new RomanNumberExtend(currentNumberStringRepresentation);
                    if (currentOperationStringRepresentation == "")
                    {
                        currentOperationStringRepresentation = "-";
                        StackRomanNumbers.Push(newNumber);
                        CurrentNumberStringRepresentation = "";
                    }
                    else
                    { 
                        if (currentOperationStringRepresentation == "+")
                        {
                            StackRomanNumbers.Push(StackRomanNumbers.Pop() + newNumber);
                        }
                        if (currentOperationStringRepresentation == "-")
                        {
                            StackRomanNumbers.Push(StackRomanNumbers.Pop() - newNumber);
                        }
                        if (currentOperationStringRepresentation == "*")
                        {
                            StackRomanNumbers.Push(StackRomanNumbers.Pop() * newNumber);
                        }
                        if (currentOperationStringRepresentation == "/")
                        {
                            StackRomanNumbers.Push(StackRomanNumbers.Pop() / newNumber);
                        }

                        currentOperationStringRepresentation = "-";
                        CurrentNumberStringRepresentation = "";
                    }
                     
                }
                    catch (RomanNumberException ex)
                    {
                        CurrentNumberStringRepresentation = ex.Message;
                        currentOperationStringRepresentation = "";
                    }
            
            });
            MulCommand = ReactiveCommand.Create(() => {
                if (currentNumberStringRepresentation == "#ERROR")
                {
                    return;
                }
                if (currentNumberStringRepresentation == "")
                {
                    if (currentOperationStringRepresentation != "")
                    {
                        currentOperationStringRepresentation = "*";
                    }
                    return;
                }
                if (currentOperationStringRepresentation == "=")
                {
                    currentOperationStringRepresentation = "*";
                    CurrentNumberStringRepresentation = "";
                    return;
                }
                try
                {
                    RomanNumberExtend newNumber = new RomanNumberExtend(currentNumberStringRepresentation);
                    if (currentOperationStringRepresentation == "")
                    {
                        currentOperationStringRepresentation = "*";
                        StackRomanNumbers.Push(newNumber);
                        CurrentNumberStringRepresentation = "";
                    }
                    else
                    {
                        if (currentOperationStringRepresentation == "+")
                        {
                            StackRomanNumbers.Push(StackRomanNumbers.Pop() + newNumber);
                        }
                        if (currentOperationStringRepresentation == "-")
                        {
                            StackRomanNumbers.Push(StackRomanNumbers.Pop() - newNumber);
                        }
                        if (currentOperationStringRepresentation == "*")
                        {
                            StackRomanNumbers.Push(StackRomanNumbers.Pop() * newNumber);
                        }
                        if (currentOperationStringRepresentation == "/")
                        {
                            StackRomanNumbers.Push(StackRomanNumbers.Pop() / newNumber);
                        }

                        currentOperationStringRepresentation = "*";
                        CurrentNumberStringRepresentation = "";
                    }
                }
                catch (RomanNumberException ex)
                {
                    CurrentNumberStringRepresentation = ex.Message;
                    currentOperationStringRepresentation = "";
                }
            });

            DivCommand = ReactiveCommand.Create(() => {
                if (currentNumberStringRepresentation == "#ERROR")
                {
                    return;
                }
                if (currentNumberStringRepresentation == "")
                {
                    if (currentOperationStringRepresentation != "")
                    {
                        currentOperationStringRepresentation = "/";
                    }
                    return;
                }
                if (currentOperationStringRepresentation == "=")
                {
                    currentOperationStringRepresentation = "/";
                    CurrentNumberStringRepresentation = "";
                }
                try
                {
                    RomanNumberExtend newNumber = new RomanNumberExtend(currentNumberStringRepresentation);
                    if (currentOperationStringRepresentation == "")
                    {
                        currentOperationStringRepresentation = "/";
                        StackRomanNumbers.Push(newNumber);
                        CurrentNumberStringRepresentation = "";
                    }
                    else
                    {
                        if (currentOperationStringRepresentation == "+")
                        {
                            StackRomanNumbers.Push(StackRomanNumbers.Pop() + newNumber);
                        }
                        if (currentOperationStringRepresentation == "-")
                        {
                            StackRomanNumbers.Push(StackRomanNumbers.Pop() - newNumber);
                        }
                        if (currentOperationStringRepresentation == "*")
                        {
                            StackRomanNumbers.Push(StackRomanNumbers.Pop() * newNumber);
                        }
                        if (currentOperationStringRepresentation == "/")
                        {
                            StackRomanNumbers.Push(StackRomanNumbers.Pop() / newNumber);
                        }

                        currentOperationStringRepresentation = "/";
                        CurrentNumberStringRepresentation = "";
                    }
                     
                }
                catch (RomanNumberException ex)
                {
                    CurrentNumberStringRepresentation = ex.Message;
                    currentOperationStringRepresentation = "";
                }
            });
            CalculateCommand = ReactiveCommand.Create(() => {
                if (currentNumberStringRepresentation == "#ERROR")
                {
                    return;
                }
                if (currentNumberStringRepresentation == "" || currentOperationStringRepresentation == "")
                {
                    return;
                }
                try
                {
                    RomanNumberExtend newNumber = new RomanNumberExtend(currentNumberStringRepresentation);
                    if (currentOperationStringRepresentation == "+")
                    {
                        StackRomanNumbers.Push(StackRomanNumbers.Pop() + newNumber);
                    }
                    if (currentOperationStringRepresentation == "-")
                    {
                        StackRomanNumbers.Push(StackRomanNumbers.Pop() - newNumber);
                    }
                    if (currentOperationStringRepresentation == "*")
                    {
                        StackRomanNumbers.Push(StackRomanNumbers.Pop() * newNumber);
                    }
                    if (currentOperationStringRepresentation == "/")
                    {
                        StackRomanNumbers.Push(StackRomanNumbers.Pop() / newNumber);
                    }

                    CurrentOperationStringRepresentation = "=";
                    newNumber = StackRomanNumbers.Pop();
                    CurrentNumberStringRepresentation = newNumber.ToString();
                    StackRomanNumbers.Push(newNumber);
                }
                catch (RomanNumberException ex)
                {
                    CurrentNumberStringRepresentation = ex.Message;
                    CurrentOperationStringRepresentation = "";
                    StackRomanNumbers.Clear();
                }
            });
            ResetCommand = ReactiveCommand.Create(() => {
                CurrentOperationStringRepresentation = "";
                CurrentNumberStringRepresentation = "";
                StackRomanNumbers.Clear();
            });
        }
        private string CurrentNumberStringRepresentation
        {
            get => currentNumberStringRepresentation;
            set
            {
                this.RaiseAndSetIfChanged(ref currentNumberStringRepresentation, value);
            }
        }
        private string CurrentOperationStringRepresentation
        {
            get => currentOperationStringRepresentation;
            set
            {
                this.RaiseAndSetIfChanged(ref currentOperationStringRepresentation, value);
            }
        }
        public ReactiveCommand<string, Unit> AddNumber { get; }
        public ReactiveCommand<Unit, Unit> PlusCommand { get; }
        public ReactiveCommand<Unit, Unit> SubCommand { get; }
        public ReactiveCommand<Unit, Unit> MulCommand { get; }
        public ReactiveCommand<Unit, Unit> DivCommand { get; }
        public ReactiveCommand<Unit, Unit> CalculateCommand { get; }
        public ReactiveCommand<Unit, Unit> ResetCommand { get; }
    }
}
