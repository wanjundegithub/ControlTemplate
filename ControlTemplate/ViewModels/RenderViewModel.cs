﻿using ControlTemplate.Interfaces;
using ReactiveUI;
using System;
using System.Reactive;

namespace ControlTemplate.ViewModels
{
    public class RenderViewModel:ViewModelBase
    {
        public RenderViewModel(Lazy<IChildWindowAsyncSevice> childWindowAsyncSevice,Func<TestViewModel> contentModel)
        {
            TestCommand = ReactiveCommand.CreateFromTask(() =>
              {
                  return childWindowAsyncSevice.Value.ShowCustomChildWindowAsync("Test", contentModel.Invoke());
              });
        }

        public ReactiveCommand<Unit,Unit> TestCommand { get; }

    }
}
