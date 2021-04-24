namespace GalaSoft.MvvmLight.Test.ViewModel
{
    /// <summary>
    /// Test class used for Unit test purposes.
    /// </summary>
    public class AccountModel : ObservableObject
    {
        private string _name = "Account name";

        public decimal Balance
        {
            get
            {
                return 26;
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                Set(ref _name, value);
            }
        }
    }
}