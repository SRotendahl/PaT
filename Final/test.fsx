let target = [10; 20; 30; 40]
let index  = [1;0;1;0]

let (res,_) = List.zip target index |> List.filter (fun (t,i) -> i = 1) |> List.unzip
let mutable S = []
printfn "%A" res 
S <- 1::S
printfn "%A" S

let a = Set.ofSeq [ 1 ..2.. 20 ]
printfn "%A" (a)
printfn "%A" (Set.remove 1 a)
    -- K is found by zipping together the variables of the equation 
    -- with the division, and filtering the variables that are input to the 
    -- semi-inversion.
    let var-id = zip eq.V division
    let (K,_) = var-id |> filter (\(v,io) -> io = 1) |> unzip
    let mutable S = []
    while exists (\r -> det r K) eq.R do
        S <- r :: S
        eq.R <- eq.R $\setminus$ {r} 
        K = K $\U$ r.V
    let (resVars,_) = var-id |> filter (\(v,io) -> io = 0) |> unzip
    if isSubset resVars K then
        if isEmpty desired then
            return S
        else
            
    else 
