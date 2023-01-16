namespace Maui.Apps.Framework.MVVM
{
    public partial class ViewModelBase : ObservableObject
    {
        [ObservableProperty]
        private string _title = string.Empty;

        [ObservableProperty]
        private bool _isBusy = false;

        [ObservableProperty]
        private string _loadingText = string.Empty;

        [ObservableProperty]
        private bool _dataLoaded = false;

        [ObservableProperty]
        private bool _isErrorState = false;

        [ObservableProperty]
        private string _errorMessage = string.Empty;

        [ObservableProperty]
        private string _errorImage = string.Empty;

        public ViewModelBase() =>
            IsErrorState = false;

        //Called on Page Appearing
        public virtual async void OnNavigatedTo(object parameters) =>
            await Task.CompletedTask;

        //Set Loading Indicators for Page
        protected void SetDataLodingIndicators(bool isStaring = true)
        {
            if (isStaring)
            {
                IsBusy = true;
                DataLoaded = false;
                IsErrorState = false;
                ErrorMessage = "";
                ErrorImage = "";
            }
            else
            {
                LoadingText = "";
                IsBusy = false;
            }
        }
    }
}
