module Sample.App

open Fable.Import.JS
open Fable.Import.LeftPad

let embrace s = "<" + s + ">"

let paddedFoo =
    LeftPad.leftPad ("foo", 10)
    |> embrace

let paddedBar =
    LeftPad.leftPad ("bar", 10, '_')
    |> embrace

console.log paddedFoo
console.log paddedBar
