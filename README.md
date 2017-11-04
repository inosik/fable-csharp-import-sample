# Fable Bindings With C#

This is a sample which shows that we can create bindings for Fable projects with C# or any other .NET language.

## Background

As we only want to provide metadata from our assembly, we can do it with any .NET language. As long as we decorate our classes and methods with the `Import` attribute from the Fable.Core package, Fable knows what `import` statements it needs to generate. However, if we wanted to provide more than simple typed bindings, this approach won't work anymore, because Fable then would need the source code of the extra functionality, which had to be F#.

This might be useful if we wanted to reuse [Retyped][retyped] bindings with Fable.

  [retyped]: https://retyped.com

## Instructions

Follow these steps:

1. Restore the packages
    1. `.paket/paket.exe restore`
    1. `yarn install`

1. Prepare the bindings project
    1. `pushd Fable.Import.LeftPad/`
    1. `dotnet restore`
    1. `dotnet build`
    1. `popd`

1. Prepare the sample project
    1. `cd Sample/`
    1. `dotnet restore`
    1. `dotnet fable start`

1. Compile to JS and run it
    1. Open another terminal window in the project directory
    1. `yarn run build`
    1. `node .`
