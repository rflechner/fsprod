namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("fsprod")>]
[<assembly: AssemblyProductAttribute("fsprod")>]
[<assembly: AssemblyDescriptionAttribute("a small build server based on WebSharper and FAKE")>]
[<assembly: AssemblyVersionAttribute("1.0")>]
[<assembly: AssemblyFileVersionAttribute("1.0")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "1.0"
