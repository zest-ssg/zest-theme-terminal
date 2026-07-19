// @title Customizing the Terminal Theme
// @date 2026-07-15
// @tags terminal, ssg
// @description Tweaking subtitle, date format, and colors via _data/params.toml.
// @layout single

open System

let html =
    divC "post-body" [
        md """
Most behavior is controlled through two small data files.

### Theme parameters

`_data/params.toml` holds values such as the subtitle, date format, and the
logo text:

```toml
subtitle = "A minimal, fast, and responsive theme for Zest."
dateFormat = "MMM d, yyyy"
showReadTime = true

[logo]
logoText = "Terminal"
```

### Navigation

`_data/nav.toml` drives the top menu:

```toml
[[items]]
label = "Home"
url = "/"
weight = 1
```

Edit these files, rebuild, and the site updates — no template changes needed.
"""
    ]

printfn "%s" html
