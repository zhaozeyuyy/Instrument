using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks;
using GalaSoft.MvvmLight.Helpers;
using GalaSoft.MvvmLight.Test.ViewModel;
using NUnit.Framework;

namespace GalaSoft.MvvmLight.Test.Binding
{
    [TestFixture]
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public class BindingThreadingTest
    {
        private Binding<string, string> _binding;

        public TestViewModel VmSource
        {
            get;
            private set;
        }

        public TestViewModel VmTarget
        {
            get;
            private set;
        }

        [Test]
        public async void Binding_ExecuteFromBackgroundThread_NoError()
        {
            VmSource = new TestViewModel
            {
                Model = new TestModel
                {
                    MyProperty = "Initial value"
                }
            };

            VmTarget = new TestViewModel();

            _binding = this.SetBinding(
                () => VmSource.Model.MyProperty,
                () => VmTarget.TargetProperty);

            Assert.AreEqual(VmSource.Model.MyProperty, VmTarget.TargetProperty);

            const string newValue = "New value";

            await Task.Run(
                () =>
                {
                    VmSource.Model.MyProperty = newValue;
                });

            Assert.AreEqual(newValue, VmSource.Model.MyProperty);
            Assert.AreEqual(VmSource.Model.MyProperty, VmTarget.TargetProperty);
        }

        [Test]
        public void Binding_ExecuteFromSameThread_NoError()
        {
            VmSource = new TestViewModel
            {
                Model = new TestModel
                {
                    MyProperty = "Initial value"
                }
            };

            VmTarget = new TestViewModel();

            _binding = this.SetBinding(
                () => VmSource.Model.MyProperty,
                () => VmTarget.TargetProperty);

            Assert.AreEqual(VmSource.Model.MyProperty, VmTarget.TargetProperty);

            const string newValue = "New value";

            VmSource.Model.MyProperty = newValue;

            Assert.AreEqual(newValue, VmSource.Model.MyProperty);
            Assert.AreEqual(VmSource.Model.MyProperty, VmTarget.TargetProperty);
        }
    }
}