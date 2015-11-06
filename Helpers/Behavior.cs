using Microsoft.Xaml.Interactivity;
using Windows.UI.Xaml;

namespace WindowsPhoneUWP.UpgradeHelpers
{
    public abstract class Behavior : DependencyObject, IBehavior
    {
        public DependencyObject AssociatedObject { get; set; }

        public virtual void Attach(DependencyObject associatedObject)
        {
            AssociatedObject = associatedObject;
        }

        public virtual void Detach()
        {
        }
    }
}
