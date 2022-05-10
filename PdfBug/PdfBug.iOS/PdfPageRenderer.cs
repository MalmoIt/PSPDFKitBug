using CoreGraphics;
using PdfBug;
using PdfBug.iOS;
using System;
using System.Collections.Generic;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(PdfPage), typeof(PdfPageRenderer))]
namespace PdfBug.iOS
{
    public class PdfPageRenderer : PageRenderer
    {
        PdfPage pdfPage;
        PsPdfTabbedViewControllerRenderer pdfTabbedViewControllerRenderer;

        public PdfPageRenderer() { }

        protected override void OnElementChanged(VisualElementChangedEventArgs e)
        {
            base.OnElementChanged(e);
            pdfPage = (PdfPage)e.NewElement;
        }

        public override void LoadView()
        {
            base.LoadView();


            var pdfs = new List<PdfModel>()
            {
                new PdfModel
                {
                    Filename = "adchart.pdf",
                    Title = "ad chart",
                    Uid = Guid.NewGuid().ToString()
                },
                new PdfModel
                {
                    Filename = "adobstacle.pdf",
                    Title = "adobstacle",
                    Uid = Guid.NewGuid().ToString()
                },
            };

            pdfTabbedViewControllerRenderer = new PsPdfTabbedViewControllerRenderer(pdfs);
            AddChildViewController(pdfTabbedViewControllerRenderer);
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            pdfTabbedViewControllerRenderer.View.AutoresizingMask = UIViewAutoresizing.FlexibleWidth | UIViewAutoresizing.FlexibleHeight;
            View.AddSubview(pdfTabbedViewControllerRenderer.View);
            pdfTabbedViewControllerRenderer.DidMoveToParentViewController(this);
        }

        public override void ViewDidAppear(bool animated)
        {
            base.ViewDidAppear(animated);

            //NavigationController.NavigationBar.BarTintColor = Color.FromHex("#181818").ToUIColor();
            //NavigationController.NavigationBar.TintColor = Color.White.ToUIColor();
            //NavigationController.NavigationBar.Translucent = false;
        }

        public override void ViewWillLayoutSubviews()
        {
            base.ViewWillLayoutSubviews();
            pdfTabbedViewControllerRenderer.View.Frame = new CGRect(0, 0, View.Bounds.Width, View.Bounds.Height);
        }
    }
}