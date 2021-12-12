﻿using Prism.Mvvm;
using Reactive.Bindings;
using Reactive.Bindings.Extensions;
using SpikeAsync.Application;
using SpikeAsync.Domain;
using System;

namespace SpikeAsync.WPF.ViewModels
{
    public class CalculatorViewModel : BindableBase
    {
        private readonly CalculatorApplicationService _calculatorApplicationService;

        public ReactiveCommand RunCommand { get; }
        public ReactiveCommand CancelCommand { get; }
        public ReactiveProperty<int> Result { get; }

        public CalculatorViewModel(CalculatorApplicationService calculatorApplicationService)
        {
            _calculatorApplicationService = calculatorApplicationService;

            Calculator calculator = _calculatorApplicationService.NewCalculator();
            RunCommand = new ReactiveCommand().WithSubscribe(() => _calculatorApplicationService.Run(calculator));
            CancelCommand = new ReactiveCommand().WithSubscribe(() => _calculatorApplicationService.Cancel(calculator));

            Result = calculator.ToReactivePropertyAsSynchronized(x => x.Result);
        }
    }
}
