using System;
using UIKit;
namespace tekitou
{
    public class TestAlart : UIViewController
    {
        public TestAlart()
        {
            var ac = UIAlertController.Create("確認", "よろしいですか？", UIAlertControllerStyle.Alert);
            var action = UIAlertAction.Create("OK", UIAlertActionStyle.Default, null);
            ac.AddAction(action);
            PresentViewController(ac, true, null);

        }
    }
}
