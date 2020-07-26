(* type Exp = Num of int
         | Vid of string
         | Cons of Exp * Exp
         | Cid of string
         | Fid of string
         | Oid of string

let pids = ['<'; '>']
let cids = [':'; '@']
let oids = ['+'; '-'; '/'; '%']
let nums = ['0';'1';'2';'3';'4';'5';'6';'7';'8';'9']

let charExists c list = List.exists (fun el -> c = el) list

let isFid (f:string) = 
    f.[0] = 'f' && 
    not(String.exists (fun c -> charExists c pids) f.[1..]) &&
    not(String.exists (fun c -> charExists c cids) f.[1..]) &&
    not(String.exists (fun c -> charExists c oids) f.[1..])

let isVid (f:string) = 
    f.[0] = 'v' && 
    not(String.exists (fun c -> charExists c pids) f.[1..]) &&
    not(String.exists (fun c -> charExists c cids) f.[1..]) &&
    not(String.exists (fun c -> charExists c oids) f.[1..])

let parseExp e = 
    match e with 
    | n when String.forall (fun c -> charExists c nums) e -> Num n
    | v when isVid e -> Vid v
    | e1:es -> 


printfn "fInsert: %A" (isFid "fInsert")
printfn "Insert: %A" (isFid "Insert")
printfn "fInsert+: %A" (isFid "fInsert+")
printfn "fInsert:: %A" (isFid "Insert:")
printfn "fInsert<: %A" (isFid "Insert<")
(* let getChar str =
    if String.IsNullOrEmpty(str) then
        (false,"") *)
     *)

let target = [10; 20; 30; 40]
let index  = [1;0;1,0]

let (res,_) = List.zip target index |> List.filter (fun (t,i) -> i = 1) |> List.unzip

printfn "%A" res 