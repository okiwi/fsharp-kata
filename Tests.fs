module Tests

open Expecto
open Lib

[<Tests>]
let wordWrapTests =
  testList "wordWrap" [
    testCase "should not wrap empty text" <| fun _ ->
      let result = wordWrap "" 1
      Expect.equal result "" "Failed"
    
    testCase "should not wrap text shorter than width" <| fun _ ->
      let result = wordWrap "word word" 10
      Expect.equal result "word word" "Failed"

    testCase "should wrap text longer than width" <| fun _ ->
      let result = wordWrap "word word" 6
      Expect.equal result "word\nword" "Failed"
      
    testCase "should wrap text longer than width but not all words" <| fun _ ->
      let result = wordWrap "word word word" 10
      Expect.equal result "word word\nword" "Failed"
      
    testCase "should deal with white spaces at end" <| fun _ ->
      let result = wordWrap "word word word         " 10
      Expect.equal result "word word\nword" "Failed"

    testCase "should deal with white spaces at begining" <| fun _ ->
      let result = wordWrap "        word word word" 10
      Expect.equal result "word word\nword" "Failed"

    testCase "should deal with white spaces in the middle" <| fun _ ->
      let result = wordWrap "word         word word          word" 10
      Expect.equal result "word word\nword word" "Failed"
  ]

[<Tests>]
let justifyTests =
  testList "Justify" [
    testCase "should justify text" <| fun _ ->
      let result = justify "we are the worldz we are the children" 19
      Expect.equal result "we  are  the worldz\nwe are the children" "Failed"
  ]
