// @title 404
// @layout base
// @permalink /404.html

open System

let html =
    divC "missing" [
        h1 [ text ":( 404" ]
        p [ text "The page you were looking for could not be found." ]
        p [ aHref "/" "Go to homepage" ]
    ]

printfn "%s" html
