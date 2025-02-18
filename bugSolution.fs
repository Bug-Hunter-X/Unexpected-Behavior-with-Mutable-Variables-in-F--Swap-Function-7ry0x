let x = ref 10
let y = ref 20

let swap x y = 
    let temp = !x
    x := !y
    y := temp

swap x y
printfn "%d %d" !x !y

//Alternative solution using tuples:

let swapTuple (x,y) = (y,x)
let xTuple = 10
let yTuple = 20
let (x',y') = swapTuple (xTuple,yTuple)
printfn "%d %d" x' y'