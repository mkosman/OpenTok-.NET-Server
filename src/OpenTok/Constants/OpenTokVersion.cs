using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace OpenTokSDK.Constants
{
    /**
     * For internal use.
     */
    class OpenTokVersion
    {
	    private static string Version => "Opentok-DotNet-SDK/" + Assembly.GetEntryAssembly().GetName().Version;

	    public static string GetVersion()
        {
            return Version;
        }
    }
}
