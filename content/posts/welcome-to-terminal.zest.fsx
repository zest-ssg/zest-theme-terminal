// @title Welcome to Terminal
// @date 2026-07-10
// @tags hugo, terminal
// @description An introduction to the Terminal theme, now running on Zest SSG.
// @layout single

open System

let html =
    divC "post-body" [
        md """
The **Terminal** theme is a classic minimal blog theme. This port keeps the
same look and feel while running entirely on [Zest](https://zest.dev).

## What you get

- A single-column, responsive layout
- Light and dark color schemes
- Per-post tags and an archive
- An RSS feed at `/rss.xml` and a sitemap at `/sitemap.xml`

## A taste of code

```fsharp
// Define a page in Zest's F# DSL
page "hello" {
    title "Hello, Zest"
    content "<p>Generated with F#.</p>"
}
```

That is all it takes to start publishing.
"""
    ]

printfn "%s" html
