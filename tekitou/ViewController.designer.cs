// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace tekitou
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView Area { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel KekkaLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField KingakuForm { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel Label01 { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel Label02 { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel Label03 { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel Label04 { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel Label05 { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel Label06 { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField NinzuForm { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton ResetButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton WarikanButton { get; set; }

        [Action ("ResetButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void ResetButton_TouchUpInside (UIKit.UIButton sender);

        [Action ("WarikanButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void WarikanButton_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (Area != null) {
                Area.Dispose ();
                Area = null;
            }

            if (KekkaLabel != null) {
                KekkaLabel.Dispose ();
                KekkaLabel = null;
            }

            if (KingakuForm != null) {
                KingakuForm.Dispose ();
                KingakuForm = null;
            }

            if (Label01 != null) {
                Label01.Dispose ();
                Label01 = null;
            }

            if (Label02 != null) {
                Label02.Dispose ();
                Label02 = null;
            }

            if (Label03 != null) {
                Label03.Dispose ();
                Label03 = null;
            }

            if (Label04 != null) {
                Label04.Dispose ();
                Label04 = null;
            }

            if (Label05 != null) {
                Label05.Dispose ();
                Label05 = null;
            }

            if (Label06 != null) {
                Label06.Dispose ();
                Label06 = null;
            }

            if (NinzuForm != null) {
                NinzuForm.Dispose ();
                NinzuForm = null;
            }

            if (ResetButton != null) {
                ResetButton.Dispose ();
                ResetButton = null;
            }

            if (WarikanButton != null) {
                WarikanButton.Dispose ();
                WarikanButton = null;
            }
        }
    }
}