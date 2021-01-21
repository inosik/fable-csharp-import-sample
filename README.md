# Fable Bindings With C\#

This is a sample which shows that we can create bindings for Fable projects with C# or any other .NET language.

## Background

As we only want to provide metadata from our assembly, we can do it with any .NET language. As long as we decorate our classes and methods with the `Import` attribute from the Fable.Core package, Fable knows what `import` statements it needs to generate. However, if we wanted to provide more than simple typed bindings, this approach won't work anymore, because Fable then would need the source code of the extra functionality, which had to be F#.

This might be useful if we wanted to reuse [Retyped][retyped] bindings with Fable.

  [retyped]: https://retyped.com

## Why C\#?

I noticed that with the `extern` keyword, we can build really nice bindings for JavaScript packages. However, `extern` is somewhat limited and hard to use in F#. It can only be used with functions, and the syntax switches to a C-like style when creating such functions. In C#, however, `extern` can be pretty much slapped on everything: instance methods, static methods, properties and even constructors!

Bindings for JavaScript classes, for example, become really straight forward to write for authors:

``` csharp
[Fable.Core.Global]
public class XMLHttpRequest
{
  public extern XMLHttpRequest();
  public extern void send();
}
```

And easy to use for users:

``` fsharp
let req = XMLHttpRequest ()
req.send ()
```

## Instructions

Follow these steps:

``` shell
# Restore the packages
dotnet tool restore
dotnet restore
npm install

# Prepare the bindings
# Unfortunately, project references don't work here
dotnet build -o bindings Fable.Import.LeftPad/
dotnet build -o bindings Fable.Import.Node/

# Compile to JavaScript
dotnet fable Sample/ --outDir dist-temp

# Compile the JavaScript produced by Fable to JS code that Node understands
npx rollup -c

# Run the sample application
node .
```
