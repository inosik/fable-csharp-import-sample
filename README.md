# Fable Bindings With C\#

This is a sample which shows that we can create bindings for Fable projects with C# or any other .NET language.

## Background

As we only want to provide metadata from our assembly, we can do it with any .NET language. As long as we decorate our classes and methods with the `Import` attribute from the Fable.Core package, Fable knows what `import` statements it needs to generate. However, if we wanted to provide more than simple typed bindings, this approach won't work anymore, because Fable then would need the source code of the extra functionality, which had to be F#.

This might be useful if we wanted to reuse [Retyped][retyped] bindings with Fable.

  [retyped]: https://retyped.com

## Instructions

Follow these steps:

``` shell
# Restore the packages
dotnet tool restore
dotnet restore
npm install

# Prepare the bindings project
dotnet build -o bindings Fable.Import.LeftPad/

# Compile to JavaScript
dotnet fable Sample/ --outDir dist-temp

# Compile the JavaScript produced by Fable to JS code that Node understands
npx rollup -c

# Run the sample application
node .
```
