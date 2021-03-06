# Feliz (beta) [![Nuget](https://img.shields.io/nuget/v/Feliz.svg?maxAge=0&colorB=brightgreen)](https://www.nuget.org/packages/Feliz)

A fresh retake of the base React DSL used within Elmish applications, optimized for maximum happiness.

Here is how it looks like:

```fs
let render state dispatch =
    Html.div [
        prop.id "main"
        prop.style [ style.padding 20 ]
        prop.children [

            Html.button [
                prop.style [ style.marginRight 5 ]
                prop.onClick (fun _ -> dispatch Increment)
                prop.content "Increment"
            ]

            Html.button [
                prop.style [ style.marginLeft 5 ]
                prop.onClick (fun _ -> dispatch Decrement)
                prop.content "Decrement"
            ]

            Html.h1 state.Count
        ]
    ]
```

### Features

 - Consistent **formatting**: no more awkward indentation using two lists for every element
 - Discoverable **attributes** with no more functions, `Html` attributes or css properties globally available.
 - Proper **documentation**: each attribute and css property
 - Fully **Type-safe**: no more `Margin of obj` but instead utilizing a plethora of overloaded functions to account for the overloaded nature of `CSS` attributes
 - Included **color list** of most commonly used `Html` colors.
 - **Compatible** with the current DSL used in applications.
 - **Compatible** with [Femto](https://github.com/Zaid-Ajaj/Femto).
 - Approximately **Zero** bundle size increase where almost everything is erased to strings in the generated javascript.

### Overloaded elements

When you want to display a single string or number simply use:
```fs
Html.h1 state.Count

Html.div "Hello there!"
```
but you could also expand the attribute:
```fs
Html.h1 [
    prop.className "title"
    prop.content "Hello there!"
]
```
Here `attr.content` is simply `attr.children [ Html.text "Hello there!" ]` so you could expand it even further:
```fs
Html.h1 [
    prop.className "title"
    prop.children [
        Html.text "Hello there"
    ]
]
```
Single children work too as input:
```fs
Html.h1 (Html.strong "I am bold")
```

### Type-safe style attributes

```fs
let customStyles =
    prop.style [
        style.display.flex
        style.display.none
        style.fontSize 20
        style.borderRadius 15
        style.alignContent.flexStart
        style.textDecorationColor.blue
        style.visibility.hidden
        style.textDecoration.lineThrough
        style.position.sticky
        style.borderRadius (length.px 10)
        style.margin 10
        style.margin (length.px 10)
        style.margin(10, 10, 10, 20)
        style.margin(10, 10, 10)
        style.margin(10, 10)
        style.width 10
        style.height 100
        style.height (length.vh 50)
        style.height (length.percent 100)
        style.backgroundColor.fuchsia
        style.backgroundColor "#FFFFFF"
        style.border(3, borderStyle.dashed, colors.crimson)
        style.borderColor.blue
        style.color.red
        style.color "#000000"
    ]
```

### Conditional classes and styles

The library includes two convenient functions to apply classes or styles conditionally on elements:
```fsharp
Html.div [
    prop.classList [ true, "shiny"; state.Count < 0, "danger" ]
    prop.styleList [
        true, [ style.margin 10 ]
        state.Count >= 10, [
            style.backgroundColor.red
            style.fontSize 20
        ]
        state.Count >= 20, [
            style.backgroundColor.green
            style.fontSize 30
        ]
    ]
]
```