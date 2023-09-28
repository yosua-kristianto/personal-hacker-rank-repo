(*
    @link https://www.hackerrank.com/challenges/three-month-preparation-kit-two-arrays/problem?isFullScreen=true&h_l=interview&playlist_slugs%5B%5D=preparation-kits&playlist_slugs%5B%5D=three-month-preparation-kit&playlist_slugs%5B%5D=three-month-week-three
*)
open System

// Input q
let Q: Int32 = Int32.Parse(Console.ReadLine());

// Input n and k
let KAndN: String[] = Console.ReadLine().Split(' ');

let K: Int32 = Int32.Parse(KAndN.[1]);
let N: Int32 = Int32.Parse(KAndN.[0]);