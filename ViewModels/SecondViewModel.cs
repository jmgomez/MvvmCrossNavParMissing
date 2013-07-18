using Cirrious.MvvmCross.ViewModels;

namespace PortableClassLibrary2.ViewModels{
    public class SecondViewModel : MvxViewModel{

        public string Param { get; set; }
        public void Init(string param){
            Param = param;

        }

    }
}