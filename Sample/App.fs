module Sample.App

open Fable.Core.JS
open Fable.Import.LeftPad

let paddedFoo = LeftPad.leftPad ("foo", 10)
let paddedBar = LeftPad.leftPad ("bar", 10, '_')

console.log ("[" + paddedFoo + "]")
console.log ("[" + paddedBar + "]")

open Fable.Import.Node

let url = URL ("/foo", "https://example.com")
console.log url
