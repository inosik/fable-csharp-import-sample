module Sample.App

open Fable.Import.JS
open Fable.Import.LeftPad

let padded =
    LeftPad.leftPad ("foo", 10)
    |> fun s -> "<" + s + ">"

console.log padded
