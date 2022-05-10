using Foundation;
using PSPDFKit.Model;
using UIKit;

namespace PdfBug.iOS
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the 
    // User Interface of the application, as well as listening (and optionally responding) to 
    // application events from iOS.
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        //
        // This method is invoked when the application has loaded and is ready to run. In this 
        // method you should instantiate the window, load the UI into it and then make the window
        // visible.
        //
        // You have 17 seconds to return from this method, or iOS will terminate your application.
        //
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            // Activate PSPDFKit for no.avinor.infoapp.alpha
            PSPDFKitGlobal.SetLicenseKey("fWvT2px43MPnV+RJkQ08OHre8+iDx4PbEsv45DSiD/pqEsPXmR1ru6Ur1Q4TYuvqAMjCn4ikFcfKk4p6lBiOPZlytmcNFca2UQkvuL33qWRHuLg+Ct/Svl6nEiFPDTEsumbu48GWo1FMML+qjfFtaEDDZtik79f7NS7D76wg077+Dl5+peCam4+J7FKc7Yvyz4RMiOH4JWtp5JBxxZsXHtGQk7MHftZ/4gXEnbAvzPHzZ8Mx2nxstmtci+cuFX5tuearl3tXmWdZpfdM9yNRkjkue8+/OlBgxJ77CP1+4CT41FzPyBDnYwChK/JGW6blhIq+9FeASRF4q3EseM+9lahdAlAlhwamKmkaSBVIR45LxHFMgTY+596BsPmca/QIJFBHJvO5WVxLejAeCm/AylqIGPedxsGd02H5HR/1isYKZ6AT+1Jz9zcsu68N/f/qwyNZWrtlZXBbCVvR1NwagU0t5MhdGrsCdC4bHRshe/9ASl4rLd8pfWynmXxbjG/wgDnt29LZjtr9WhhmqgxzRtsZpgIuu8tPaza7feHOdhgPMCsrjYT/1INUzKowwIZqt8ENIvfYJn8RtUwAQVI53Jsp//SExKkI5Wy81LJg0AV6h7XqS3J56GGSoAY1qREgWWsmaduYF2qwsYkbJNEO5w==");

            global::Xamarin.Forms.Forms.Init();
            LoadApplication(new App());

            return base.FinishedLaunching(app, options);
        }
    }
}
