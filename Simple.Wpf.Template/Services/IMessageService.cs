namespace Simple.Wpf.Template.Services
{
    using System;
    using Models;
    using ViewModels;

    public interface IMessageService
    {
        IObservable<Message> Show { get; }

        void Post(string header, ICloseableViewModel viewModel);
    }
}