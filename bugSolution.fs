let swap x y = 
    (y, x)

let a = 10
let b = 20
let (c, d) = swap a b
printfn "%d %d" c d //This will print 20 10 as expected

//In this solution, we avoid mutability and return a tuple containing the swapped values. This adheres to F#'s functional paradigm and avoids potential side effects.