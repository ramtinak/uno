using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[assembly: InternalsVisibleTo("Uno.UI")]
[assembly: InternalsVisibleTo("Uno.UI.Wasm")]
[assembly: InternalsVisibleTo("Uno.UI.RuntimeTests")]
[assembly: InternalsVisibleTo("Uno.UI.Tests")]
[assembly: InternalsVisibleTo("Uno.UI.Toolkit")]

#if NET6_0_OR_GREATER
[assembly: System.Reflection.AssemblyMetadata("IsTrimmable", "True")]
#elif __IOS__
[assembly: Foundation.LinkerSafe]
#elif __ANDROID__
[assembly: Android.LinkerSafe]
#endif
