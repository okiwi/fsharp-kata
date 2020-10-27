module Tests

open Expecto
open Lib

[<Tests>]
let tests =
  testList "lib" [
    testCase "foo is true" <| fun _ ->
      let subject = foo
      Expect.isTrue subject "Should be true"
  ]
