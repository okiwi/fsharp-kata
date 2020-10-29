module Lib

open System


let concat (width: int) (acc: string) (value: string) =
    match acc with
    | "" -> value
    | _ when value = "" -> acc
    | _ when acc.Length - (acc.LastIndexOf("\n") + 1) + value.Length >= width -> acc + "\n" + value
    | _ -> acc + " " + value


let wordWrap (text: string) (width: int) =
    match text with
    | "" -> ""
    | _ ->
        text.Split " "
        |> (Seq.fold (concat width) "")
