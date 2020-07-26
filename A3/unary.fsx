type Nat = Zero | Succ of Nat

let rec add (x:Nat) (y:Nat) : Nat = 
    match x with
    | Zero -> y
    | Succ i -> add i (Succ y)

let rec sub (x:Nat) (y:Nat) : Nat = 
    match (x,y) with
    | (Zero,_) -> y
    | (Succ i, Succ j) -> add i j
    | _ -> Zero // if we would get a negative number, return zero

let x = add (Succ(Succ(Zero))) (Succ(Zero))
printfn "Succ(Succ(Zero))) + (Succ(Zero)) = %A" x

let y = sub (Succ(Succ(Zero))) (Succ(Zero))
printfn "Succ(Succ(Zero))) - (Succ(Zero)) = %A" y