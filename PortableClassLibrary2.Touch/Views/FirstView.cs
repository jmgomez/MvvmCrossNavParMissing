using System.Drawing;
using Cirrious.MvvmCross.Binding.BindingContext;
using Cirrious.MvvmCross.Touch.Views;
using MonoTouch.UIKit;
using MonoTouch.Foundation;
using PortableClassLibrary2.ViewModels;

namespace PortableClassLibrary2.Touch.Views
{
    [Register("FirstView")]
    public class FirstView : MvxViewController
    {
        public override void ViewDidLoad()
        {
            View = new UIView(){ BackgroundColor = UIColor.White};
            base.ViewDidLoad();

            var label = new UILabel(new RectangleF(10, 10, 300, 40));
            Add(label);
            var button = new UIButton(UIButtonType.RoundedRect){ Frame = new RectangleF(10, 50, 300, 50)};
            Add(button);
            var set = this.CreateBindingSet<FirstView, FirstViewModel>();
            set.Bind(label).To(vm => vm.Hello);
            set.Bind(button).To(vm => vm.GoToSecondCommand);
            set.Apply();
        }
    }
   [Register("SecondView")]
    public class SecondView : MvxViewController
    {
        public override void ViewDidLoad()
        {
            View = new UIView(){ BackgroundColor = UIColor.White};
            base.ViewDidLoad();

            var label = new UILabel(new RectangleF(10, 10, 300, 40));
            Add(label);
            var textField = new UITextField(new RectangleF(10, 50, 300, 40));
            Add(textField);

            var set = this.CreateBindingSet<SecondView, SecondViewModel>();
            set.Bind(label).To(vm => vm.Param);
            
            set.Apply();
        }
    }
}