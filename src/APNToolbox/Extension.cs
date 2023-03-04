using Microsoft.AspNetCore.Html;
using Microsoft.DotNet.Interactive;
using System.CommandLine;

namespace APNToolbox {
    public class Extension {
        public static void Load(Kernel kernel) {
            var nowCommand = new Command("#!now", "The current datetime");

            nowCommand.SetHandler(() => {

                KernelInvocationContext.Current.Display(new HtmlString($"{DateTime.Now}"));

            });

            kernel.AddDirective(nowCommand);

            KernelInvocationContext.Current.Display(new HtmlString("APNToolbox ready"));
        }
    }
}