// @title Building a Static Site with Zest
// @date 2026-07-12
// @tags ssg, zest
// @description How Zest turns Markdown content and Nunjucks templates into a static site.
// @layout single

open System

let html =
    divC "post-body" [
        md """
Zest reads your `content/` folder, renders Markdown to HTML, and wraps each
page with a layout. Templates are written in **Nunjucks** (`.njk`) and have
access to `site`, `page`, `pages`, and `tags`.

A minimal layout looks like this:

```njk
<!-- @layout base -->
<article class="post">
  <h1>{{ page.title }}</h1>
  <div class="post-content">{{ content | safe }}</div>
</article>
```

Because everything is pre-rendered, the result is a folder of plain `.html`
files you can host anywhere.
"""
    ]

printfn "%s" html
