module Lib

open System


let concat (width: int) (acc: string) (value: string) =
    match acc with
    | "" -> value
    | _ -> if acc.Length + value.Length >= width then acc + "\n" + value else acc + " " + value


let wordWrap (text: string) (width: int) =
    match text with
    | "" -> ""
    | _ ->
        text.Split " "
        |> Seq.toList
        |> (Seq.fold (concat width) "")
        |> fun x -> x.Trim()
