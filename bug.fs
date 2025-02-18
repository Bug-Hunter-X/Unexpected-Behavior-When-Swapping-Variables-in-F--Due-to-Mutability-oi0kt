let mutable x = 10
let mutable y = 20

let swap x y = 
    let temp = x
    x <- y
    y <- temp

swap x y
printfn "%d %d" x y //This will print 20 20 as expected

//However, if we try to swap values in a function that takes the values as arguments rather than mutable variables:

let swap2 (x:int) (y:int) = 
    let temp = x
    //x <- y //This will cause an error
    //y <- temp //This will cause an error
    (y,x)

let a = 10
let b = 20
let (c,d) = swap2 a b
printfn "%d %d" c d //This will print 20 10 as expected