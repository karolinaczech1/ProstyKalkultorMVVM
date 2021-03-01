using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Calculator.Models
{
    public class OperationModel : INotifyPropertyChanged
    {

        private double number1;
        private double number2;
        private char operation;
        private String result;

        public double Number1
        {
            get { return number1; }
            set
            {
                number1 = value;
                OnPropertyChanged(nameof(Number1));
            }
        }
        public double Number2
        {
            get { return number2; }
            set
            {
                number2 = value;
                OnPropertyChanged(nameof(Number2));
            }
        }
        public char Operation
        {
            get { return operation; }
            set
            {
                operation = value;
                OnPropertyChanged(nameof(Operation));
            }
        }
        public String Result
        {
            get { return result; }
            set
            {
                result = value;
                OnPropertyChanged(nameof(Result));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void GetResult()
        {
            if(operation == '+')
            {
                Result = (number1 + number2).ToString();
            }
            else if(operation == '-')
            {
                Result = (number1 - number2).ToString();
            }
            else if(operation == '*')
            { 
                Result = (number1 * number2).ToString();
            }
            else
            {
                if (number2 != 0) Result = (number1 / number2).ToString();
                else Result = "error";
            }

        }

    }
}
