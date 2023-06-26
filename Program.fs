//write a function that takes a string and returns a string
let reverseString (s: string) =
    new string(Array.rev (s.ToCharArray()))

[<EntryPoint>]
let main argv =
    //let str = "Mark McFadden!!"
    System.Console.WriteLine("Enter a string: ")
    let str = System.Console.ReadLine()

    //instead of reversing the string, display it as is
    printfn "You entered: %s" str
    0 //return an integer exit code
