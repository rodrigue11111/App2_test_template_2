using System;
using System.Collections.ObjectModel;

using App2_test_template_2.Contracts.ViewModels;
using App2_test_template_2.Core.Contracts.Services;
using App2_test_template_2.Core.Models;

using CommunityToolkit.Mvvm.ComponentModel;

namespace App2_test_template_2.ViewModels
{
    public class RésultatsViewModel : ObservableRecipient, INavigationAware
    {
        private readonly ISampleDataService _sampleDataService;

        public ObservableCollection<SampleOrder> Source { get; } = new ObservableCollection<SampleOrder>();

        public RésultatsViewModel(ISampleDataService sampleDataService)
        {
            _sampleDataService = sampleDataService;
        }

        public async void OnNavigatedTo(object parameter)
        {
            Source.Clear();

            // TODO: Replace with real data.
            var data = await _sampleDataService.GetGridDataAsync();

            foreach (var item in data)
            {
                Source.Add(item);
            }
        }

        public void OnNavigatedFrom()
        {
        }
    }
}
