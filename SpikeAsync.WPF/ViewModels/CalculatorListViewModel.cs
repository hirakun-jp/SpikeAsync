using Prism.Commands;
using Prism.Mvvm;
using Reactive.Bindings;
using SpikeAsync.Application;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SpikeAsync.WPF.ViewModels
{
    public class CalculatorListViewModel : BindableBase
    {
        public ReactiveCollection<CalculatorViewModel> CalculatorViewModels { get; }

        public CalculatorListViewModel()
        {
            CalculatorViewModels = new ReactiveCollection<CalculatorViewModel>
            {
                new CalculatorViewModel(new CalculatorApplicationService()),
                new CalculatorViewModel(new CalculatorApplicationService()),
                new CalculatorViewModel(new CalculatorApplicationService())
            };
        }
    }
}
