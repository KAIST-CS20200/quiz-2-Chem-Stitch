module CS220.Quiz1.Math

open System

/// Modify the function `collatz` in such a way that the function takes in a
/// 32-bit integer, and returns the number of steps it takes to reach 1 in the
/// Collatz sequence.
let f n =
  if n % 2UL = 0UL then n / 2UL
  else 3UL * n + 1UL

let collatz n =
  let rec iter cnt n  = 
    if n = 1UL then
      cnt
    else
      let result = f n
      //printfn "%d" result
      iter (cnt + 1) result
  iter 0 (uint64 n)