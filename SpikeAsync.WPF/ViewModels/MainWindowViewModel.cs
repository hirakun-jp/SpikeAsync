using Prism.Mvvm;
using Reactive.Bindings;
using Reactive.Bindings.Extensions;
using SpikeAsync.Application;
using System;

namespace SpikeAsync.WPF.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _title = "Prism Application";
        private readonly CalculatorApplicationService _calculatorApplicationService;

        public ReactiveCommand RunCommand { get; }
        public ReactiveCommand CancelCommand { get; }

        public ReactiveProperty<int> Result { get; }

        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public MainWindowViewModel()
        {
            _calculatorApplicationService = new CalculatorApplicationService();

            var calculator = _calculatorApplicationService.NewCalculator();
            RunCommand = new ReactiveCommand().WithSubscribe(() => _calculatorApplicationService.Run(calculator));
            CancelCommand = new ReactiveCommand().WithSubscribe(() => _calculatorApplicationService.Cancel(calculator));

            Result = calculator.ToReactivePropertyAsSynchronized(x => x.Result);
        }
    }
}
