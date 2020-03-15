module Synthesis

open System
open System.Diagnostics

let abelar a = a>12 && a<3097 && a%12=0
    //failwith "Not implemented"

let area (b:float) (h:float) = 
    match b < 0.0 || h < 0.0 with
    |true -> failwith "Invalid Length"
    |false -> (b * h) / 2.0
    //failwith "Not implemented"

let zollo n =
    match n<0 with
    |true -> n*(-1)
    |false -> n*2
    //failwith "Not implemented"

let min a b =
    match a < b with
    |true -> a
    |false -> b
    //failwith "Not implemented"

let max a b =
    match a < b with
    |true -> b
    |false -> a
    //failwith "Not implemented"

let ofTime h m s = (h*60*60) + (m * 60) + s
    //failwith "Not implemented"

let toTime s = 
    match s > -1 with
    |true -> (s/60/60, (s/60)%60,s%60)
    |false -> (0,0,0)
    //failwith "Not implemented"

let rec digits n = 
    match (n<10 && n >(-10)) with
    |false -> 1 + digits(n/10)
    |true -> 1
    //failwith "Not implemented"

let minmax (a,b,c,d) = (min (min a b) (min c d)),(max (max a b) (max c d))
    //failwith "Not implemented"

let isLeap year =
    match (year>=1582) with
    |true -> (year%4=0 && (not(year % 100 = 0) || year%400=0))
    |false -> failwith "Year is less than 1582"
    //failwith "Not implemented"

let month m = 
    match m with |1->"January",31|2->"February",28|3->"March",31|4->"April",30|5->"May",31|6->"June",30|7->"July",31|8->"August",31|9->"September",30|10->"October",31|11->"November",30|12->"December",31|_->failwith "Invalid month"
    //failwith "Not implemented"

let rec toBinary i =
    let rec convert num out =
        match num with
        | 1 | 0 -> string(num) + out
        |_ -> convert (num / 2) (string(num % 2) + out)
    match i>=0 with
    |false-> failwith "Invalid number"
    |true -> convert i ""
    //let conversion = string(i)
    //failwith "Not implemented"

let bizFuzz n =
    
    failwith "Not implemented"

let monthDay d y =

    failwith "Not implemented"

let coord _ =
    failwith "Not implemented"