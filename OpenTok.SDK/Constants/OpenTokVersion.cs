using System.Reflection;

namespace OpenTok.SDK.Constants
{
    /**
     * For internal use.
     */
    class OpenTokVersion
    {
	    private static string Version => "Opentok-DotNet-SDK/" + typeof(OpenTokVersion).GetTypeInfo().Assembly.GetName().Version;

	    public static string GetVersion()
        {
            return Version;
        }
    }
}
