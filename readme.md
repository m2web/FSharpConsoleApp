# Copilot Chat in Visual Studio

Within Microsoft Visual Studio Community 2022 (VisualStudio.17.Release/17.6.4+33815.320), I first attempted to just simply put a comment in the editor and then allow Copilot to complete the code for me. What I found was the code suggested by Copilot was not compiling correctly and resulting in errors. Perhaps it was hallucinating when it offered the code. I then put the same question into Copilot Chat prompt, and the result was much better.

Next, asked Copilot Chat to create a Main method similar to what you  would have in a Java class. Within a few seconds it provided the code and it compiled and functioned correctly.

Here are the step by step iterations with the code, using Copilot Chat.

Where was my prompt content in Copilot Chat: `write a function that takes a string and returns a string.`

Here is the output:

```fsharp
let reverseString (s: string) 
    = new string(Array.rev (s.ToCharArray()))

let main argv =
    //testing the reverseString function with an example string
    let str = \"example\"

    printfn \"%s\" (reverseString str)
    0 //return an integer exit code
```

Which displayed the reversed string. I did not want to reverse the string. So then the prompt content became: `instead of reversing the string, display it as is.` Here was the help:

```fsharp
let reverseString (s: string) =
    new string(Array.rev (s.ToCharArray()))

let main argv = let str = \"Hello Solar System!!\"
    //instead of reversing the string, display it as is
    printfn \"%s\" str
    0 //return an integer exit code
```

Now, I want to pass a string to the main function and then parse it from the argv variable. After copying and pasting the previous sentence into the prompt of Copilot Chat, here is the result.

```fsharp
let reverseString (s: string) = 
    new string(Array.rev (s.ToCharArray()))

let main argv = 
    //let str = \"Hello Solar System!!\"
    let str = argv.\[]
    //instead of reversing the string, display it as is
    printfn \"%s\" str
    0 //return an integer exit code
```

Yeah, I still want to keep my reverseString function :-). However, the above did not work. With Copilot Chat\'s help and me being more specific at the chat prompt, here is what I ended with:

```fsharp
let reverseString (s: string) =
    new string(Array.rev (s.ToCharArray()))

let main argv =
    //let str = \"Hello Solar System!!\"
    System.Console.WriteLine(\"Enter a string: \")
    let str = System.Console.ReadLine()
    //instead of reversing the string, display it as is
    printfn \"You entered: %s\" str
    0 //return an integer exit code
```

Hey, my first F# Console App in 25 minutes!

However, when I wanted to export the Copilot Chat content, the result was not what I expected.

![A screenshot of a chat Description automatically generated with medium
confidence](images/VisualStudioCopilotChatFSharpSession.docx/media/image1.png)

In VS Code you have the option to export, as well as import, your chat sessions in the form of a JSON file. As you can see from my prompt above, Copilot Chat in Visual Studio does not have that option. I really wanted to save the Copilot's chat session. Oh well.
