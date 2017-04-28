using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace CiCdApp
{
    public class CalculatorPageModel
    {
        public ICommand AddCommand { get; private set; }

        public ICommand MultiplyCommand { get; private set; }

        public ICommand AnswerToEverythingCommand { get; private set; }

        public int ValueA { get; set; }

        public int ValueB { get; set; }

        public int Result { get; set; }

        public CalculatorPageModel()
        {
            AddCommand = new Command(Add);
            MultiplyCommand = new Command(Multiply);
            AnswerToEverythingCommand = new Command(AnswerToEverything);
        }

        private void Add()
        {
            Result = ValueA + ValueB;
        }

        private void Multiply()
        {
            Result = ValueA * ValueB;
        }

        private void AnswerToEverything()
        {
            Result = 1337;
        }
    }
}