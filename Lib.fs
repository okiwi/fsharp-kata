module Lib

open System

let wordWrap (text:string) (width:int) = 
    text.Replace(' ', '\n')