module Tests

open Expecto
open Lib

[<Tests>]
let tests =
  testList "wordWrap" [
    testCase "should not wrap empty text" <| fun _ ->
      let result = wordWrap "" 1
      Expect.equal result "" "Failed";
    
    testCase "should not wrap text shorter than width" <| fun _ ->
      let result = wordWrap "word word" 10
      Expect.equal result "word word" "Failed";

    testCase "should wrap text longer than width" <| fun _ ->
      let result = wordWrap "word word" 6
      Expect.equal result "word\nword" "Failed"
      
    testCase "should wrap text longer than width but not all words" <| fun _ ->
      let result = wordWrap "word word word" 10
      Expect.equal result "word word\nword" "Failed"
      
    testCase "should deal with white spaces" <| fun _ ->
      let result = wordWrap "word word word         " 10
      Expect.equal result "word word\nword" "Failed"
  ]
