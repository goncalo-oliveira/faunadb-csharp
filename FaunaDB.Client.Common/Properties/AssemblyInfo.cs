using System.Reflection;
using System.Runtime.CompilerServices;

// Information about this assembly is defined by the following attributes.
// Change them to the values specific to your project.

[assembly: AssemblyTitle("FaunaDB.Client.Common")]
[assembly: AssemblyCompany("Fauna, Inc.")]
[assembly: AssemblyProduct("C# Driver for FaunaDB")]
[assembly: AssemblyDescription("C# Driver for FaunaDB")]
[assembly: AssemblyCopyright("© Fauna, Inc. 2017. Distributed under MPL 2.0 License")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

#if DEBUG
[assembly: AssemblyConfiguration("Debug")]
[assembly: InternalsVisibleTo("FaunaDB.Client.Common.Test")]
[assembly: InternalsVisibleTo("FaunaDB.Client.Api.V2.Test")]
[assembly: InternalsVisibleTo("FaunaDB.Client.Api.V2")]
#else
[assembly: AssemblyConfiguration("Release")]
[assembly: InternalsVisibleTo("FaunaDB.Client.Api.V2, PublicKey=002400000480000094000000060200000024000052534131000400000100010031060d1deed1ff"
                              + "372b2325456bfb6381d3290dd74f658fbc80c9134e0b076f3357f9f25fa29785ed4dc90a41a06f"
                              + "c25f61090b1bba0d24ca626073b5e02a0f13a96489b325ce0c9f6ba5f4137faf21a505cb0c410b"
                              + "ca22381dbf8b62900b160e82b220ad8dfbadf98bc8745f42f7ebbfca525de7e9f13817b8ef9b7a"
                              + "6b8c08d3")]
#endif

// The assembly version has the format "{Major}.{Minor}.{Build}.{Revision}".
// The form "{Major}.{Minor}.*" will automatically update the build and revision,
// and "{Major}.{Minor}.{Build}.*" will update just the revision.

[assembly: AssemblyVersion(FaunaDBCommonAttribute.Version)]
[assembly: AssemblyFileVersion(FaunaDBCommonAttribute.Version)]
[assembly: AssemblyInformationalVersion(FaunaDBCommonAttribute.Version + "-alpha")]

// The following attributes are used to specify the signing key for the assembly,
// if desired. See the Mono documentation for more information about signing.

//[assembly: AssemblyDelaySign(false)]
//[assembly: AssemblyKeyFile("")]

static class FaunaDBCommonAttribute
{
    public const string Version = "1.0.0";
}
