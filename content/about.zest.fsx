// @title About
// @layout base
// @permalink /about/

open System

let html =
    md """
**Terminal** is a faithful port of the classic
[hugo-theme-terminal](https://github.com/panr/hugo-theme-terminal) to
[Zest SSG](https://zest.dev).

It demonstrates how a Hugo theme can be reimplemented with Zest's
F# DSL (`.zest.fsx`) and ZCSS (`.zcss`), TOML content frontmatter, and a
small set of data files:

- `content/*.zest.fsx` — pages written in the F# DSL
- `assets/css/*.zcss` — styles written in ZCSS
- `_data/nav.toml` — primary navigation
- `_data/params.toml` — theme parameters (subtitle, date format, ...)
- `content/rss.zest.fsx` / `content/sitemap.zest.fsx` — feed & sitemap

Everything is plain static output: no client framework, no build-time
JavaScript in the browser.
"""

printfn "%s" html
