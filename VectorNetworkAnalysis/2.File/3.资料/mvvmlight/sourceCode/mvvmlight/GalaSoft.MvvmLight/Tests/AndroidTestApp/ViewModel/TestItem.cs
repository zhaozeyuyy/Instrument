#if __IOS__
using Foundation;
#endif

namespace GalaSoft.MvvmLight.Test.ViewModel
{
    /// <summary>
    /// Test class used for Unit test purposes.
    /// </summary>
    public class TestItem
    {
        public TestItem(string title)
        {
            Title = title;
        }

        public string Title
        {
            get;
            set;
        }

#if __IOS__
    // For tests only
        public NSIndexPath RowIndexPath
        {
            get;
            set;
        }
#endif
    }
}