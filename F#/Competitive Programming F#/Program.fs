(*
    Started at September, 28th 2023
    3 days well wasted 👍
    @link https://www.hackerrank.com/challenges/three-month-preparation-kit-two-arrays/problem?isFullScreen=true&h_l=interview&playlist_slugs%5B%5D=preparation-kits&playlist_slugs%5B%5D=three-month-preparation-kit&playlist_slugs%5B%5D=three-month-week-three
*)
open System

// Input q
let Q: Int32 = Int32.Parse(Console.ReadLine())

let mutable Output: String[] = [||]

(*
    permuteArray
    
    This function will actually doing the conditional checking for the permuted arithmetic
*)
let permuteArray (A: Int32[]) (B: Int32[]) (reverseA: bool) (reverseB: bool) (expectedOutput: Int32) : String =
    let fixedA: Int32[] = if (reverseA = true) then Array.rev A else A

    let fixedB: Int32[] = if (reverseB = true) then Array.rev B else B

    let mutable yesOrNo: String = "YES"

    for i in 0 .. Array.length fixedA - 1 do
        // Skip this iteration if "No" is already identified
        if (yesOrNo = "NO") then
            ()

        if (expectedOutput >= fixedA.[i] + fixedB.[i]) then
            yesOrNo <- "NO"


    yesOrNo

for question = 1 to Q do
    // Input n and k
    let KAndN: String[] = Console.ReadLine().Split(' ')

    // Initialize N & K
    let N = Int32.Parse(KAndN.[0])
    let K = Int32.Parse(KAndN.[1])

    // Input A & B
    let InputA: String[] = Console.ReadLine().Split(' ')
    let InputB: String[] = Console.ReadLine().Split(' ')

    let A: Int32[] = [||]
    let B: Int32[] = [||]


    // Parsing A & B into list of Int32
    for input in 0 .. Array.length InputA - 1 do
        Array.append A [| Int32.Parse(InputA.[input]) |]
        Array.append B [| Int32.Parse(InputB.[input]) |]

    // Giving 4 conditions regarding the permutations
    let fourConditions: bool[,] =
        array2D [ [| false; false |]; [| true; false |]; [| false; true |]; [| true; true |] ]

    let mutable thisQOutput: String = "NO"

    (*
        This ducking code is equivalent with C# of 

        for(int i = 0; i < fourConditions.Length(); i++)
        {
            let output = permuteArray(
                A,
                B,
                fourConditions[i][0],
                fourConditions[i][1],
                K
            );

            if(output == "YES")
            {
                result = "YES";
                break;
            }
        }
    *)
    try
        for i in 0 .. Array2D.length1 fourConditions - 1 do
            let output =
                permuteArray A B (fourConditions.[i, *][0]) (fourConditions.[i, *][1]) K

            if (output = "YES") then
                raise (new System.Exception("Yes Exception"))
    with :? System.Exception as ex when ex.Message = "Yes Exception" ->
        thisQOutput <- "YES"

    Output <- Array.concat [ Output; [| thisQOutput |] ]

for i in 0 .. Output.Length - 1 do
    Console.WriteLine(Output.[i])
