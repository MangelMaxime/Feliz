namespace Feliz

open Fable.Core
open Feliz.Styles

[<Erase>]
/// Specifies a number of specialized CSS units
type length =
    /// Pixels are (1px = 1/96th of 1in).
    ///
    /// **Note**: Pixels (px) are relative to the viewing device. For low-dpi devices, 1px is one device pixel (dot) of the display. For printers and high resolution screens 1px implies multiple device pixels.
    static member inline px(value: int) : ICssUnit = unbox ((unbox<string>value) + "px")
    static member inline px(value: double) : ICssUnit = unbox ((unbox<string>value) + "px")
    /// Centimeters
    static member inline cm(value: int) : ICssUnit = unbox ((unbox<string>value) + "cm")
    /// Centimeters
    static member inline cm(value: double) : ICssUnit = unbox ((unbox<string>value) + "cm")
    /// Millimeters
    static member inline mm(value: int) : ICssUnit = unbox ((unbox<string>value) + "mm")
    /// Millimeters
    static member inline mm(value: double) : ICssUnit = unbox ((unbox<string>value) + "mm")
    /// Inches (1in = 96px = 2.54cm)
    static member inline inch(value: int) : ICssUnit = unbox ((unbox<string>value) + "in")
    /// Inches (1in = 96px = 2.54cm)
    static member inline inch(value: double) : ICssUnit = unbox ((unbox<string>value) + "in")
    /// Points (1pt = 1/72 of 1in)
    static member inline pt(value: int) : ICssUnit = unbox ((unbox<string>value) + "pt")
    /// Points (1pt = 1/72 of 1in)
    static member inline pt(value: double) : ICssUnit = unbox ((unbox<string>value) + "pt")
    /// Picas (1pc = 12 pt)
    static member inline pc(value: int) : ICssUnit = unbox ((unbox<string>value) + "pc")
    /// Picas (1pc = 12 pt)
    static member inline pc(value: double) : ICssUnit = unbox ((unbox<string>value) + "pc")
    /// Relative to the font-size of the element (2em means 2 times the size of the current font
    static member inline em(value: int) : ICssUnit = unbox ((unbox<string>value) + "em")
    /// Relative to the font-size of the element (2em means 2 times the size of the current font
    static member inline em(value: double) : ICssUnit = unbox ((unbox<string>value) + "em")
    /// Relative to the x-height of the current font (rarely used)
    static member inline ex(value: int) : ICssUnit = unbox ((unbox<string>value) + "ex")
    /// Relative to the x-height of the current font (rarely used)
    static member inline ex(value: double) : ICssUnit = unbox ((unbox<string>value) + "ex")
    static member inline ch(value: int) : ICssUnit = unbox ((unbox<string>value) + "ch")
    /// Relative to font-size of the root element
    static member inline rem(value: double) : ICssUnit = unbox ((unbox<string>value) + "rem")
    /// Relative to font-size of the root element
    static member inline rem(value: int) : ICssUnit = unbox ((unbox<string>value) + "rem")
    /// Relative to 1% of the height of the viewport*
    ///
    /// **Viewport** = the browser window size. If the viewport is 50cm wide, 1vw = 0.5cm.
    static member inline vh(value: int) : ICssUnit = unbox ((unbox<string>value) + "vh")
    /// Relative to 1% of the height of the viewport*
    ///
    /// **Viewport** = the browser window size. If the viewport is 50cm wide, 1vw = 0.5cm.
    static member inline vh(value: double) : ICssUnit = unbox ((unbox<string>value) + "vh")
    /// Relative to 1% of the width of the viewport*
    ///
    /// **Viewport** = the browser window size. If the viewport is 50cm wide, 1vw = 0.5cm.
    static member inline vw(value: int) : ICssUnit = unbox ((unbox<string>value) + "vw")
    /// Relative to 1% of the width of the viewport*
    ///
    /// **Viewport** = the browser window size. If the viewport is 50cm wide, 1vw = 0.5cm.
    static member inline vw(value: double) : ICssUnit = unbox ((unbox<string>value) + "vw")
    /// Relative to 1% of viewport's smaller dimension
    static member inline vmin(value: double) : ICssUnit = unbox ((unbox<string>value) + "vmin")
    /// Relative to 1% of viewport's smaller dimension
    static member inline vmin(value: int) : ICssUnit = unbox ((unbox<string>value) + "vmin")
    /// Relative to 1% of viewport's larger dimension
    static member inline vmax(value: double) : ICssUnit = unbox ((unbox<string>value) + "vmax")
    /// Relative to 1% of viewport's* larger dimension
    static member inline vmax(value: int) : ICssUnit = unbox ((unbox<string>value) + "vmax")
    /// Relative to the parent element
    static member inline perc(value: int) : ICssUnit = unbox ((unbox<string>value) + "%")
    /// Relative to the parent element
    static member inline perc(value: double) : ICssUnit = unbox ((unbox<string>value) + "%")
    /// Relative to the parent element
    static member inline percent(value: int) : ICssUnit = unbox ((unbox<string>value) + "%")
    /// Relative to the parent element
    static member inline percent(value: double) : ICssUnit = unbox ((unbox<string>value) + "%")
    static member inline auto : ICssUnit = unbox "auto"

[<Erase>]
type style =
    /// The zIndex property sets or returns the stack order of a positioned element.
    ///
    /// An element with greater stack order (1) is always in front of another element with lower stack order (0).
    ///
    /// **Tip**: A positioned element is an element with the position property set to: relative, absolute, or fixed.
    ///
    /// **Tip**: This property is useful if you want to create overlapping elements.
    static member inline zIndex(value: int) = Interop.mkStyle "zIndex" value
    static member inline margin(value: int) = Interop.mkStyle "margin" value
    static member inline margin(top: int, right: int) = Interop.mkStyle "margin" (sprintf "%dpx %dpx" top right)
    static member inline margin(top: ICssUnit, right: int) =
        Interop.mkStyle "margin" (
            (unbox<string> top) + " " +
            (unbox<string>right) + "px"
        )

    static member inline padding(top: ICssUnit, right: int) =
        Interop.mkStyle "padding" (
            (unbox<string> top) + " " +
            (unbox<string>right) + "px"
        )

    static member inline margin(top: ICssUnit, right: int, bottom: int) =
        Interop.mkStyle "margin" (
            (unbox<string> top) + " " +
            (unbox<string>right) + "px " +
            (unbox<string>bottom) + "px"
        )

    static member inline padding(top: ICssUnit, right: int, bottom: int) =
        Interop.mkStyle "padding" (
            (unbox<string> top) + " " +
            (unbox<string> right) + "px " +
            (unbox<string> bottom) + "px"
        )

    static member inline margin(top: ICssUnit, right: ICssUnit, bottom: int) =
        Interop.mkStyle "margin" (
            (unbox<string> top) + " " +
            (unbox<string> right) + " " +
            (unbox<string>bottom) + "px"
        )

    static member inline padding(top: ICssUnit, right: ICssUnit, bottom: int) =
        Interop.mkStyle "padding" (
            (unbox<string> top) + " " +
            (unbox<string> right) + " " +
            (unbox<string>bottom) + "px"
        )

    static member inline margin(top: ICssUnit, right: ICssUnit, bottom: ICssUnit) =
        Interop.mkStyle "margin" (
            (unbox<string> top) + " " +
            (unbox<string> right) + " " +
            (unbox<string> bottom)
        )

    static member inline padding(top: ICssUnit, right: ICssUnit, bottom: ICssUnit) =
        Interop.mkStyle "padding" (
            (unbox<string> top) + " " +
            (unbox<string> right) + " " +
            (unbox<string> bottom)
        )

    static member inline margin(top: ICssUnit, right: int, bottom: ICssUnit) =
        Interop.mkStyle "margin" (
            (unbox<string> top) + " " +
            (unbox<string> right) + "px " +
            (unbox<string> bottom)
        )

    static member inline padding(top: ICssUnit, right: int, bottom: ICssUnit) =
        Interop.mkStyle "padding" (
            (unbox<string> top) + " " +
            (unbox<string> right) + "px " +
            (unbox<string> bottom)
        )

    static member inline margin(top: ICssUnit, right: ICssUnit, bottom: ICssUnit, left: ICssUnit) =
        Interop.mkStyle "margin" (
            (unbox<string> top) + " " +
            (unbox<string> right) + " " +
            (unbox<string> bottom) + " " +
            (unbox<string> left)
        )

    static member inline padding(top: ICssUnit, right: ICssUnit, bottom: ICssUnit, left: ICssUnit) =
        Interop.mkStyle "padding" (
            (unbox<string> top) + " " +
            (unbox<string> right) + " " +
            (unbox<string> bottom) + " " +
            (unbox<string> left)
        )

    static member inline margin(top: ICssUnit, right: int, bottom: int, left: int) =
        Interop.mkStyle "margin" (
            (unbox<string> top) + " " +
            (unbox<string>right) + "px " +
            (unbox<string>bottom) + "px " +
            (unbox<string>left) + "px"
        )

    static member inline padding(top: ICssUnit, right: int, bottom: int, left: int) =
        Interop.mkStyle "padding" (
            (unbox<string> top) + " " +
            (unbox<string>right) + "px " +
            (unbox<string>bottom) + "px " +
            (unbox<string>left) + "px"
        )

    static member inline margin(top: int, right: ICssUnit) =
        Interop.mkStyle "margin" (
            (unbox<string> right) + " " +
            (unbox<string>top) + "px"
        )

    static member inline padding(top: int, right: ICssUnit) =
        Interop.mkStyle "padding" (
            (unbox<string> right) + " " +
            (unbox<string>top) + "px"
        )
    static member inline margin(top: int, right: int, bottom: int) =
        Interop.mkStyle "margin" ((unbox<string> top) + "px " + (unbox<string> right) + "px " + (unbox<string> bottom) + "px")
    static member inline margin(top: int, right: int, bottom: int, left: int) =
        Interop.mkStyle "margin" (
            (unbox<string> top) + "px " +
            (unbox<string> right) + "px " +
            (unbox<string> bottom) + "px " +
            (unbox<string> left) + "px")

    static member inline margin(value: ICssUnit) = Interop.mkStyle "margin" value
    static member inline marginLeft(value: int) = Interop.mkStyle "marginLeft" value
    static member inline marginLeft(value: ICssUnit) = Interop.mkStyle "marginLeft" value
    static member inline marginRight(value: int) = Interop.mkStyle "marginRight" value
    static member inline marginRight(value: ICssUnit) = Interop.mkStyle "marginRight" value
    static member inline marginTop(value: int) = Interop.mkStyle "marginTop" value
    static member inline marginTop(value: ICssUnit) = Interop.mkStyle "marginTop" value
    static member inline marginBottom(value: int) = Interop.mkStyle "marginBottom" value
    static member inline marginBottom(value: ICssUnit) = Interop.mkStyle "marginBottom" value
    static member inline padding(value: int) = Interop.mkStyle "padding" value
    static member inline padding(top: int, right: int) = Interop.mkStyle "padding" (sprintf "%dpx %dpx" top right)
    static member inline padding(top: int, right: int, bottom: int) = Interop.mkStyle "padding" (sprintf "%dpx %dpx %dpx" top right bottom)
    static member inline padding(top: int, right: int, bottom: int, left: int) = Interop.mkStyle "padding" (sprintf "%dpx %dpx %dpx %dpx" top right bottom left)
    static member inline padding(value: ICssUnit) = Interop.mkStyle "padding" value
    static member inline paddingBottom(value: int) = Interop.mkStyle "paddingBottom" value
    static member inline paddingBottom(value: ICssUnit) = Interop.mkStyle "paddingBottom" value
    static member inline paddingLeft(value: int) = Interop.mkStyle "paddingLeft" value
    static member inline paddingLeft(value: ICssUnit) = Interop.mkStyle "paddingLeft" value
    static member inline paddingRight(value: int) = Interop.mkStyle "paddingRight" value
    static member inline paddingRight(value: ICssUnit) = Interop.mkStyle "paddingRight" value
    static member inline paddingTop(value: int) = Interop.mkStyle "paddingTop" value
    static member inline paddingTop(value: ICssUnit) = Interop.mkStyle "paddingTop" value
    static member inline fontSize(size: int) = Interop.mkStyle "fontSize" size
    static member inline fontSize(size: ICssUnit) = Interop.mkStyle "fontSize" size
    static member inline backgroundColor (color: string) = Interop.mkStyle "backgroundColor" color
    static member inline color (color: string) = Interop.mkStyle "color" color
    static member inline top(value: int) = Interop.mkStyle "top" value
    static member inline top(value: ICssUnit) = Interop.mkStyle "top" value
    static member inline bottom(value: int) = Interop.mkStyle "bottom" value
    static member inline bottom(value: ICssUnit) = Interop.mkStyle "bottom" value
    static member inline left(value: int) = Interop.mkStyle "left" value
    static member inline left(value: ICssUnit) = Interop.mkStyle "left" value
    static member inline right(value: int) = Interop.mkStyle "right" value
    static member inline right(value: ICssUnit) = Interop.mkStyle "right" value
    static member inline custom(key: string, value: 't) = Interop.mkStyle key value
    static member inline border(width: int, style: IBorderStyle, color: string) = Interop.mkStyle "border" (sprintf "%dpx %s %s" width (unbox style) color)
    static member inline border(width: ICssUnit, style: IBorderStyle, color: string) = Interop.mkStyle "border" (sprintf "%dpx %s %s" (unbox width) (unbox style) color)
    static member inline border(width: string, style: IBorderStyle, color: string) = Interop.mkStyle "border" (sprintf "%s %s %s" width (unbox style) color)
    static member inline borderWidth (width: int) = Interop.mkStyle "borderWidth" width
    static member inline borderStyle (style: IBorderStyle) = Interop.mkStyle "borderStyle" style
    static member inline borderStyle(top: IBorderStyle, right: IBorderStyle)  =
        Interop.mkStyle "borderStyle" (sprintf "%s %s" (unbox top) (unbox right))
    static member inline borderStyle(top: IBorderStyle, right: IBorderStyle, bottom: IBorderStyle) =
        Interop.mkStyle "borderStyle" (sprintf "%s %s %s" (unbox top) (unbox right) (unbox bottom))
    static member inline multiple(top: IBorderStyle, right: IBorderStyle, bottom: IBorderStyle, left: IBorderStyle) =
        Interop.mkStyle "borderStyle" (sprintf "%s %s %s %s" (unbox top) (unbox right) (unbox bottom) (unbox left))
    static member inline borderColor (color: string) = Interop.mkStyle "borderColor" color
    static member inline borderRadius (radius: int) = Interop.mkStyle "borderRadius" radius
    static member inline fontFamily (family: string) = Interop.mkStyle "fontFamily" family
    /// Defines from thin to thick characters. 400 is the same as normal, and 700 is the same as bold.
    /// Possible values are [100, 200, 300, 400, 500, 600, 700, 800, 900]
    static member inline fontWeight (weight: int) = Interop.mkStyle "fontWeight" weight
    static member inline borderRadius (radius: ICssUnit) = Interop.mkStyle "borderRadius" radius
    static member inline borderWidth (top: int, right: int) =
        let value = sprintf "%dpx %dpx" top right
        Interop.mkStyle "borderWidth" value
    static member inline borderWidth (top: int, right: int, bottom: int) =
        let value = sprintf "%dpx %dpx %dpx" top right bottom
        Interop.mkStyle "borderWidth" value
    static member inline borderWidth (top: int, right: int, bottom: int, left: int) =
        let value = sprintf "%dpx %dpx %dpx %dpx" top right bottom left
        Interop.mkStyle "borderWidth" value
    static member inline textDecorationColor(color: string) = Interop.mkStyle "textDecorationColor" color
    static member inline textDecorationLine(line: ITextDecorationLine) = Interop.mkStyle "textDecorationLine" line
    static member inline textDecoration(line: ITextDecorationLine) = Interop.mkStyle "textDecoration" line
    static member inline textDecoration(bottom: ITextDecorationLine, top: ITextDecorationLine) = Interop.mkStyle "textDecoration" (sprintf "%s %s" (unbox bottom) (unbox top))
    static member inline textDecoration(bottom: ITextDecorationLine, top: ITextDecorationLine, style: ITextDecoration) =
        let value = sprintf "%s %s %s" (unbox bottom) (unbox top) (unbox style)
        Interop.mkStyle "textDecoration" value
    static member inline textDecoration(bottom: ITextDecorationLine, top: ITextDecorationLine, style: ITextDecoration, color: string) =
        let value = sprintf "%s %s %s %s" (unbox bottom) (unbox top) (unbox style) color
        Interop.mkStyle "textDecoration" value
    static member inline textIndent(value: int) = Interop.mkStyle "textIndent" value
    static member inline textIndent(value: string) = Interop.mkStyle "textIndent" value
    static member inline opacity(value: double) = Interop.mkStyle "opacity" value
    static member inline minWidth (value: int) = Interop.mkStyle "minWidth" value
    static member inline minWidth (value: ICssUnit) = Interop.mkStyle "minWidth" value
    static member inline backgroundPosition  (position: string) = Interop.mkStyle "backgroundPosition" position
    static member inline cursor (value: string) = Interop.mkStyle "cursor" value
    static member inline minWidth (value: string) = Interop.mkStyle "minWidth" value
    static member inline minHeight (value: int) = Interop.mkStyle "minHeight" value
    static member inline minHeight (value: ICssUnit) = Interop.mkStyle "minHeight" value
    static member inline maxWidth (value: int) = Interop.mkStyle "maxWidth" value
    static member inline maxWidth (value: ICssUnit) = Interop.mkStyle "maxWidth" value
    static member inline maxHeight (value: int) = Interop.mkStyle "maxHeight" value
    static member inline maxHeight (value: ICssUnit) = Interop.mkStyle "maxHeight" value
    static member inline height (value: int) = Interop.mkStyle "height" value
    static member inline height (value: ICssUnit) = Interop.mkStyle "height" value
    static member inline width (value: int) = Interop.mkStyle "width" value
    static member inline width (value: ICssUnit) = Interop.mkStyle "width" value
    static member inline backgroundSize (value: string) = Interop.mkStyle "backgroundSize" value
    static member inline backgroundImage (value: string) = Interop.mkStyle "backgroundImage" value
    static member inline backgroundImageUrl (value: string) = Interop.mkStyle "backgroundImage" ("url(" + value + ")")
    static member inline backgroundRepeat (repeat: IBackgroundRepeat) = Interop.mkStyle "backgroundRepeat" repeat


[<Erase>]
module style =

    [<Erase>]
    type overflow =
        /// The content is not clipped, and it may be rendered outside the left and right edges. This is default.
        static member inline visible = Interop.mkStyle "overflow" "visibile"
        /// The content is clipped - and no scrolling mechanism is provided.
        static member inline hidden = Interop.mkStyle "overflow" "hidden"
        /// The content is clipped and a scrolling mechanism is provided.
        static member inline scroll = Interop.mkStyle "overflow" "scroll"
        /// Should cause a scrolling mechanism to be provided for overflowing boxes
        static member inline auto = Interop.mkStyle "overflow" "auto"
        /// Sets this property to its default value.
        static member inline initial = Interop.mkStyle "overflow" "initial"
        /// Inherits this property from its parent element.
        static member inline inheritFromParent = Interop.mkStyle "overflow" "inherit"

    [<Erase>]
    type overflowX =
        /// The content is not clipped, and it may be rendered outside the left and right edges. This is default.
        static member inline visible = Interop.mkStyle "overflowX" "visibile"
        /// The content is clipped - and no scrolling mechanism is provided.
        static member inline hidden = Interop.mkStyle "overflowX" "hidden"
        /// The content is clipped and a scrolling mechanism is provided.
        static member inline scroll = Interop.mkStyle "overflowX" "scroll"
        /// Should cause a scrolling mechanism to be provided for overflowing boxes
        static member inline auto = Interop.mkStyle "overflowX" "auto"
        /// Sets this property to its default value.
        static member inline initial = Interop.mkStyle "overflowX" "initial"
        /// Inherits this property from its parent element.
        static member inline inheritFromParent = Interop.mkStyle "overflowX" "inherit"

    [<Erase>]
    type visibility =
        /// The element is hidden (but still takes up space).
        static member inline hidden = Interop.mkStyle "visibility" "hidden"
        /// Default value. The element is visible.
        static member inline visible = Interop.mkStyle "visibility" "visible"
        /// Only for table rows (`<tr>`), row groups (`<tbody>`), columns (`<col>`), column groups (`<colgroup>`). This value removes a row or column, but it does not affect the table layout. The space taken up by the row or column will be available for other content.
        ///
        /// If collapse is used on other elements, it renders as "hidden"
        static member inline collapse = Interop.mkStyle "visibility" "collapse"
        /// Sets this property to its default value.
        static member inline initial = Interop.mkStyle "visibility" "initial"
        /// Inherits this property from its parent element.
        static member inline inheritFromParent = Interop.mkStyle "visibility" "inherit"

    [<Erase>]
    type fontKerning =
        /// Default. The browser determines whether font kerning should be applied or not
        static member inline auto = Interop.mkStyle "fontKerning" "auto"
        /// Specifies that font kerning is applied
        static member inline normal = Interop.mkStyle "fontKerning" "normal"
        /// Specifies that font kerning is not applied
        static member inline none = Interop.mkStyle "fontKerning" "none"

    [<Erase>]
    /// The font-weight property sets how thick or thin characters in text should be displayed.
    type fontWeight =
        /// Defines normal characters. This is default.
        static member inline normal = Interop.mkStyle "fontWeight" "normal"
        /// Defines thick characters.
        static member inline bold = Interop.mkStyle "fontWeight" "bold"
        /// Defines thicker characters
        static member inline bolder = Interop.mkStyle "fontWeight" "bolder"
        /// Defines lighter characters.
        static member inline lighter = Interop.mkStyle "fontWeight" "lighter"
        /// Sets this property to its default value.
        static member inline initial = Interop.mkStyle "fontWeight" "initial"
        /// Inherits this property from its parent element.
        static member inline inheritFromParent = Interop.mkStyle "fontWeight" "inherit"

    [<Erase>]
    type fontStyle =
        /// The browser displays a normal font style. This is defaut.
        static member inline normal = Interop.mkStyle "fontStyle" "normal"
        /// The browser displays an italic font style.
        static member inline italic = Interop.mkStyle "fontStyle" "italic"
        /// The browser displays an oblique font style.
        static member inline oblique = Interop.mkStyle "fontStyle" "oblique"
        /// Sets this property to its default value.
        static member inline initial = Interop.mkStyle "fontStyle" "initial"
        /// Inherits this property from its parent element.
        static member inline inheritFromParent = Interop.mkStyle "fontStyle" "inherit"

    [<Erase>]
    type fontVariant =
        /// The browser displays a normal font. This is default
        static member inline normal : IFontVariant = unbox "normal"
        /// The browser displays a small-caps font
        static member inline smallCaps : IFontVariant = unbox "small-caps"
        /// Sets this property to its default value.
        static member inline initial : IFontVariant = unbox "initial"
        /// Inherits this property from its parent element.
        static member inline inheritFromParent : IFontVariant = unbox "inherit"

    [<Erase>]
    type overflowY =
        /// The content is not clipped, and it may be rendered outside the left and right edges. This is default.
        static member inline visible = Interop.mkStyle "overflowY" "visibile"
        /// The content is clipped - and no scrolling mechanism is provided.
        static member inline hidden = Interop.mkStyle "overflowY" "hidden"
        /// The content is clipped and a scrolling mechanism is provided.
        static member inline scroll = Interop.mkStyle "overflowY" "scroll"
        /// Should cause a scrolling mechanism to be provided for overflowing boxes
        static member inline auto = Interop.mkStyle "overflowY" "auto"
        /// Sets this property to its default value.
        static member inline initial = Interop.mkStyle "overflowY" "initial"
        /// Inherits this property from its parent element.
        static member inline inheritFromParent = Interop.mkStyle "overflowY" "inherit"

    [<Erase>]
    type wordWrap =
        /// Break words only at allowed break points
        static member inline normal = Interop.mkStyle "wordWrap" "normal"
        /// Allows unbreakable words to be broken
        static member inline breakWord = Interop.mkStyle "wordWrap" "break-word"
        /// Sets this property to its default value.
        static member inline initial = Interop.mkStyle "wordWrap" "initial"
        /// Inherits this property from its parent element.
        static member inline inheritFromParent = Interop.mkStyle "wordWrap" "inherit"

    [<Erase>]
    type alignSelf =
        /// Default. The element inherits its parent container's align-items property, or "stretch" if it has no parent container.
        static member inline auto = Interop.mkStyle "alignSelf" "auto"
        /// The element is positioned to fit the container
        static member inline stretch = Interop.mkStyle "alignSelf" "stretch"
        /// The element is positioned at the center of the container
        static member inline center = Interop.mkStyle "alignSelf" "center"
        /// The element is positioned at the beginning of the container
        static member inline flexStart = Interop.mkStyle "alignSelf" "flex-start"
        /// The element is positioned at the end of the container
        static member inline flexEnd = Interop.mkStyle "alignSelf" "flex-end"
        /// The element is positioned at the baseline of the container
        static member inline baseline = Interop.mkStyle "alignSelf" "baseline"
        /// Sets this property to its default value
        static member inline initial = Interop.mkStyle "alignSelf" "initial"
        /// Inherits this property from its parent element
        static member inline inheritFromParent = Interop.mkStyle "alignSelf" "inherit"


    [<Erase>]
    type alignItems =
        /// Default. Items are stretched to fit the container
        static member inline stretch = Interop.mkStyle "alignItems" "stretch"
        /// Items are positioned at the center of the container
        static member inline center = Interop.mkStyle "alignItems"  "center"
        /// Items are positioned at the beginning of the container
        static member inline flexStart = Interop.mkStyle "alignItems" "flex-start"
        /// Items are positioned at the end of the container
        static member inline flexEnd = Interop.mkStyle "alignItems" "flex-end"
        /// Items are positioned at the baseline of the container
        static member inline baseline = Interop.mkStyle "alignItems" "baseline"
        /// Sets this property to its default value
        static member inline initial = Interop.mkStyle "alignItems"  "initial"
        /// Inherits this property from its parent element
        static member inline inheritFromParent = Interop.mkStyle "alignItems"  "inherit"

    [<Erase>]
    type alignContent =
        /// Default value. Lines stretch to take up the remaining space.
        static member inline stretch = Interop.mkStyle "alignContent" "stretch"
        /// Lines are packed toward the center of the flex container.
        static member inline center = Interop.mkStyle "alignContent" "center"
        /// Lines are packed toward the start of the flex container.
        static member inline flexStart = Interop.mkStyle "alignContent" "flex-start"
        /// Lines are packed toward the end of the flex container.
        static member inline flexEnd = Interop.mkStyle "alignContent" "flex-end"
        /// Lines are evenly distributed in the flex container.
        static member inline spaceBetween = Interop.mkStyle "alignContent" "space-between"
        /// Lines are evenly distributed in the flex container, with half-size spaces on either end.
        static member inline spaceAround = Interop.mkStyle "alignContent" "space-around"

    [<Erase>]
    type textAlign =
        /// Aligns the text to the left.
        ///
        /// See example https://www.w3schools.com/cssref/playit.asp?filename=playcss_text-align
        static member inline left = Interop.mkStyle "textAlign" "left"
        /// Aligns the text to the right.
        ///
        /// See example https://www.w3schools.com/cssref/playit.asp?filename=playcss_text-align&preval=right
        static member inline right = Interop.mkStyle "textAlign" "right"
        /// Centers the text.
        ///
        /// See example https://www.w3schools.com/cssref/playit.asp?filename=playcss_text-align&preval=center
        static member inline center = Interop.mkStyle "textAlign" "center"
        /// Stretches the lines so that each line has equal width (like in newspapers and magazines).
        ///
        /// See example https://www.w3schools.com/cssref/playit.asp?filename=playcss_text-align&preval=justify
        static member inline justify = Interop.mkStyle "textAlign" "justify"
        /// Sets this property to its default value.
        ///
        /// See example https://www.w3schools.com/cssref/playit.asp?filename=playcss_text-align&preval=initial
        static member inline initial = Interop.mkStyle "textAlign" "initial"
        /// Inherits this property from its parent element.
        ///
        /// See example https://www.w3schools.com/cssref/playit.asp?filename=playcss_text-align&preval=initial
        static member inline inheritFromParent = Interop.mkStyle "textAlign" "inheritFromParent"


    [<Erase>]
    type textDecorationLine =
        static member inline none = Interop.mkStyle "textDecorationLine" "none"
        static member inline underline = Interop.mkStyle "textDecorationLine" "underline"
        static member inline overline = Interop.mkStyle "textDecorationLine" "overline"
        static member inline lineThrough = Interop.mkStyle "textDecorationLine" "line-through"
        static member inline initial = Interop.mkStyle "textDecorationLine" "initial"
        static member inline inheritFromParent = Interop.mkStyle "textDecorationLine" "inherit"

    [<Erase>]
    type textDecoration =
        static member inline none = Interop.mkStyle "textDecoration" "none"
        static member inline underline = Interop.mkStyle "textDecoration" "underline"
        static member inline overline = Interop.mkStyle "textDecoration" "overline"
        static member inline lineThrough = Interop.mkStyle "textDecoration" "line-through"
        static member inline initial = Interop.mkStyle "textDecoration" "initial"
        static member inline inheritFromParent = Interop.mkStyle "textDecoration" "inherit"

    [<Erase>]
    type textDecorationStyle =
        /// Default value. The line will display as a single line.
        ///
        /// See example https://www.w3schools.com/cssref/playit.asp?filename=playcss_text-decoration-style&preval=solid
        static member inline solid = Interop.mkStyle "textDecorationStyle" "solid"
        /// The line will display as a double line.
        ///
        /// https://www.w3schools.com/cssref/playit.asp?filename=playcss_text-decoration-style&preval=double
        static member inline double = Interop.mkStyle "textDecorationStyle" "double"
        /// The line will display as a dotted line.
        ///
        /// See example https://www.w3schools.com/cssref/playit.asp?filename=playcss_text-decoration-style&preval=dotted
        static member inline dotted = Interop.mkStyle "textDecorationStyle" "dotted"
        /// The line will display as a dashed line.
        ///
        /// See example https://www.w3schools.com/cssref/playit.asp?filename=playcss_text-decoration-style&preval=dashed
        static member inline dashed = Interop.mkStyle "textDecorationStyle" "dashed"
        /// The line will display as a wavy line.
        ///
        /// https://www.w3schools.com/cssref/playit.asp?filename=playcss_text-decoration-style&preval=wavy
        static member inline wavy = Interop.mkStyle "textDecorationStyle" "wavy"
        /// Sets this property to its default value.
        ///
        /// See example https://www.w3schools.com/cssref/playit.asp?filename=playcss_text-decoration-style&preval=initial
        static member inline initial = Interop.mkStyle "textDecorationStyle" "initial"
        /// Inherits this property from its parent element.
        static member inline inheritFromParent = Interop.mkStyle "textDecorationStyle" "inherit"

    [<Erase>]
    type fontStretch =
        /// Makes the text as narrow as it gets.
        static member inline ultraCondensed = Interop.mkStyle "fontStretch" "ultra-condensed"
        /// Makes the text narrower than condensed, but not as narrow as ultra-condensed
        static member inline extraCondensed = Interop.mkStyle "fontStretch" "extra-condensed"
        /// Makes the text narrower than semi-condensed, but not as narrow as extra-condensed.
        static member inline condensed = Interop.mkStyle "fontStretch" "condensed"
        /// Makes the text narrower than normal, but not as narrow as condensed.
        static member inline semiCondensed = Interop.mkStyle "fontStretch" "semi-condensed"
        /// Default value. No font stretching
        static member inline normal = Interop.mkStyle "fontStretch" "normal"
        /// Makes the text wider than normal, but not as wide as expanded
        static member inline semiExpanded = Interop.mkStyle "fontStretch" "semi-expanded"
        /// Makes the text wider than semi-expanded, but not as wide as extra-expanded
        static member inline expanded = Interop.mkStyle "fontStretch" "expanded"
        /// Makes the text wider than expanded, but not as wide as ultra-expanded
        static member inline extraExpanded = Interop.mkStyle "fontStretch" "extra-expanded"
        /// Makes the text as wide as it gets.
        static member inline ultraExpanded = Interop.mkStyle "fontStretch" "ultra-expanded"
        /// Sets this property to its default value.
        static member inline initial = Interop.mkStyle "fontStretch" "initial"
        /// Inherits this property from its parent element.
        static member inline inheritFromParent = Interop.mkStyle "fontStretch" "inherit"

    [<Erase>]
    type borderStyle =
        /// Specifies a dotted border.
        ///
        /// See example https://www.w3schools.com/cssref/playit.asp?filename=playcss_border-style&preval=dotted
        static member inline dotted = Interop.mkStyle "borderStyle" "dotted"
        /// Specifies a dashed border.
        ///
        /// See example https://www.w3schools.com/cssref/playit.asp?filename=playcss_border-style&preval=dotted
        static member inline dashed = Interop.mkStyle "borderStyle" "dashed"
        /// Specifies a solid border.
        ///
        /// See example https://www.w3schools.com/cssref/playit.asp?filename=playcss_border-style&preval=dotted
        static member inline solid = Interop.mkStyle "borderStyle" "solid"
        /// Specifies a double border.
        ///
        /// See example https://www.w3schools.com/cssref/playit.asp?filename=playcss_border-style&preval=dotted
        static member inline double = Interop.mkStyle "borderStyle" "double"
        /// Specifies a 3D grooved border. The effect depends on the border-color value.
        ///
        /// See example https://www.w3schools.com/cssref/playit.asp?filename=playcss_border-style&preval=dotted
        static member inline groove = Interop.mkStyle "borderStyle" "groove"
        /// Specifies a 3D ridged border. The effect depends on the border-color value.
        ///
        /// See example https://www.w3schools.com/cssref/playit.asp?filename=playcss_border-style&preval=dotted
        static member inline ridge = Interop.mkStyle "borderStyle" "ridge"
        /// Specifies a 3D inset border. The effect depends on the border-color value.
        ///
        /// See example https://www.w3schools.com/cssref/playit.asp?filename=playcss_border-style&preval=dotted
        static member inline inset = Interop.mkStyle "borderStyle" "inset"
        /// Specifies a 3D outset border. The effect depends on the border-color value.
        ///
        /// See example https://www.w3schools.com/cssref/playit.asp?filename=playcss_border-style&preval=dotted
        static member inline outset = Interop.mkStyle "borderStyle" "outset"
        /// Default value. Specifies no border.
        ///
        /// See example https://www.w3schools.com/cssref/playit.asp?filename=playcss_border-style&preval=dotted
        static member inline none = Interop.mkStyle "borderStyle" "none"
        /// The same as "none", except in border conflict resolution for table elements.
        ///
        /// See example https://www.w3schools.com/cssref/playit.asp?filename=playcss_border-style&preval=hidden
        static member inline hidden = Interop.mkStyle "borderStyle" "hidden"
        /// Sets this property to its default value.
        ///
        /// See example https://www.w3schools.com/cssref/playit.asp?filename=playcss_border-style&preval=hidden
        ///
        /// Read about initial value https://www.w3schools.com/cssref/css_initial.asp
        static member inline initial = Interop.mkStyle "borderStyle" "initial"
        /// Inherits this property from its parent element.
        ///
        /// See example https://www.w3schools.com/cssref/playit.asp?filename=playcss_border-style&preval=hidden
        ///
        /// Read about inherit https://www.w3schools.com/cssref/css_inherit.asp
        static member inline inheritFromParent = Interop.mkStyle "borderStyle" "inherit"

    [<Erase>]
    type display =
        /// Displays an element as an inline element (like `<span>`). Any height and width properties will have no effect.
        static member inline inlineElement = Interop.mkStyle "display" "inline"
        /// Displays an element as a block element (like `<p>`). It starts on a new line, and takes up the whole width.
        static member inline block = Interop.mkStyle "display" "block"
        /// Makes the container disappear, making the child elements children of the element the next level up in the DOM.
        static member inline contents = Interop.mkStyle "display" "contents"
        /// Displays an element as a block-level flex container.
        static member inline flex = Interop.mkStyle "display" "flex"
        /// Displays an element as a block-level grid container.
        static member inline grid = Interop.mkStyle "display" "grid"
        /// Displays an element as an inline-level block container. The element itself is formatted as an inline element, but you can apply height and width values.
        static member inline inlineBlock = Interop.mkStyle "display" "inline-block"
        /// Displays an element as an inline-level flex container.
        static member inline inlineFlex = Interop.mkStyle "display" "inline-flex"
        /// Displays an element as an inline-level grid container
        static member inline inlineGrid = Interop.mkStyle "display" "inline-grid"
        /// The element is displayed as an inline-level table.
        static member inline inlineTable = Interop.mkStyle "display" "inline-table"
        /// Let the element behave like a `<li>` element
        static member inline listItem = Interop.mkStyle "display" "list-item"
        /// Displays an element as either block or inline, depending on context.
        static member inline runIn = Interop.mkStyle "display" "run-in"
        /// Let the element behave like a `<table>` element.
        static member inline table = Interop.mkStyle "display" "table"
        /// Let the element behave like a <caption> element.
        static member inline tableCaption = Interop.mkStyle "display" "table-caption"
        /// Let the element behave like a <colgroup> element.
        static member inline tableColumnGroup = Interop.mkStyle "display" "table-column-group"
        /// Let the element behave like a <thead> element.
        static member inline tableHeaderGroup = Interop.mkStyle "display" "table-header-group"
        /// Let the element behave like a <tfoot> element.
        static member inline tableFooterGroup = Interop.mkStyle "display" "table-footer-group"
        /// Let the element behave like a <tbody> element.
        static member inline tableRowGroup = Interop.mkStyle "display" "table-row-group"
        /// Let the element behave like a <td> element.
        static member inline tableCell = Interop.mkStyle "display" "table-cell"
        /// Let the element behave like a <col> element.
        static member inline tableColumn = Interop.mkStyle "display" "table-column"
        /// Let the element behave like a <tr> element.
        static member inline tableRow = Interop.mkStyle "display" "table-row"
        /// The element is completely removed.
        static member inline none = Interop.mkStyle "display" "none"
        /// Sets this property to its default value.
        static member inline initial = Interop.mkStyle "display" "initial"
        /// Inherits this property from its parent element.
        static member inline inheritFromParent = Interop.mkStyle "display" "inherit"

    [<Erase>]
    type backgroundRepeat =
        /// The background image is repeated both vertically and horizontally. This is default.
        static member inline repeat = Interop.mkStyle "backgroundRepeat" "repeat"
        /// The background image is only repeated horizontally.
        static member inline repeatX = Interop.mkStyle "backgroundRepeat" "repeat-x"
        /// The background image is only repeated vertically.
        static member inline repeatY = Interop.mkStyle "backgroundRepeat" "repeat-y"
        /// The background-image is not repeated.
        static member inline noRepeat = Interop.mkStyle "backgroundRepeat" "no-repeat"
        /// Sets this property to its default value.
        static member inline initial = Interop.mkStyle "backgroundRepeat" "initial"
        /// Inherits this property from its parent element.
        static member inline inheritFromParent = Interop.mkStyle "backgroundRepeat" "inherit"

    [<Erase>]
    type backgroundClip =
        /// Default value. The background is clipped to the border box.
        static member inline borderBox = Interop.mkStyle "backgroundClip" "border-box"
        /// The background is clipped to the padding box.
        static member inline paddingBox = Interop.mkStyle "backgroundClip" "padding-box"
        /// The background is clipped to the content box
        static member inline contentBox = Interop.mkStyle "backgroundClip" "content-box"
        /// Sets this property to its default value.
        static member inline initial = Interop.mkStyle "backgroundClip" "initial"
        /// Inherits this property from its parent element.
        static member inline inheritFromParent = Interop.mkStyle "backgroundClip" "inherit"

    [<Erase>]
    type position =

        /// Default value. Elements render in order, as they appear in the document flow.
        static member inline defaultStatic = Interop.mkStyle "position" "static"
        /// The element is positioned relative to its first positioned (not static) ancestor element.
        static member inline absolute = Interop.mkStyle "position" "absolute"
        /// The element is positioned relative to the browser window
        static member inline fixedRelativeToWindow = Interop.mkStyle "position" "fixed"
        /// The element is positioned relative to its normal position, so "left:20px" adds 20 pixels to the element's LEFT position.
        static member inline relative = Interop.mkStyle "position" "relative"
        /// The element is positioned based on the user's scroll position
        ///
        /// A sticky element toggles between relative and fixed, depending on the scroll position. It is positioned relative until a given offset position is met in the viewport - then it "sticks" in place (like position:fixed).
        ///
        /// Note: Not supported in IE/Edge 15 or earlier. Supported in Safari from version 6.1 with a -webkit- prefix.
        static member inline sticky = Interop.mkStyle "position" "sticky"
        static member inline initial = Interop.mkStyle "position" "initial"
        static member inline inheritFromParent = Interop.mkStyle "position" "inherit"

    [<Erase; RequireQualifiedAccess>]
    type backgroundColor =
        static member inline  indianRed = Interop.mkStyle "backgroundColor" "#CD5C5C"
        static member inline  lightCoral = Interop.mkStyle "backgroundColor" "#F08080"
        static member inline  salmon = Interop.mkStyle "backgroundColor" "#FA8072"
        static member inline  darkSalmon = Interop.mkStyle "backgroundColor" "#E9967A"
        static member inline  lightSalmon = Interop.mkStyle "backgroundColor" "#FFA07A"
        static member inline  crimson = Interop.mkStyle "backgroundColor" "#DC143C"
        static member inline  red = Interop.mkStyle "backgroundColor" "#FF0000"
        static member inline  fireBrick = Interop.mkStyle "backgroundColor" "#B22222"
        static member inline  darkred = Interop.mkStyle "backgroundColor" "#8B0000"
        static member inline  pink = Interop.mkStyle "backgroundColor" "#FFC0CB"
        static member inline  lightPink = Interop.mkStyle "backgroundColor" "#FFB6C1"
        static member inline  hotPink = Interop.mkStyle "backgroundColor" "#FF69B4"
        static member inline  deepPink = Interop.mkStyle "backgroundColor" "#FF1493"
        static member inline  mediumVioletRed = Interop.mkStyle "backgroundColor" "#C71585"
        static member inline  paleVioletRed = Interop.mkStyle "backgroundColor" "#DB7093"
        static member inline  coral = Interop.mkStyle "backgroundColor" "#FF7F50"
        static member inline  tomato = Interop.mkStyle "backgroundColor" "#FF6347"
        static member inline  orangeRed = Interop.mkStyle "backgroundColor" "#FF4500"
        static member inline  darkOrange = Interop.mkStyle "backgroundColor" "#FF8C00"
        static member inline  orange = Interop.mkStyle "backgroundColor" "#FFA500"
        static member inline  gold = Interop.mkStyle "backgroundColor" "#FFD700"
        static member inline  yellow = Interop.mkStyle "backgroundColor" "#FFFF00"
        static member inline  lightYellow = Interop.mkStyle "backgroundColor" "#FFFFE0"
        static member inline  limonChiffon = Interop.mkStyle "backgroundColor" "#FFFACD"
        static member inline  lightGoldenRodYellow = Interop.mkStyle "backgroundColor" "#FAFAD2"
        static member inline  papayaWhip = Interop.mkStyle "backgroundColor" "#FFEFD5"
        static member inline  moccasin = Interop.mkStyle "backgroundColor" "#FFE4B5"
        static member inline  peachPuff = Interop.mkStyle "backgroundColor" "#FFDAB9"
        static member inline  paleGoldenRod = Interop.mkStyle "backgroundColor" "#EEE8AA"
        static member inline  khaki = Interop.mkStyle "backgroundColor" "#F0E68C"
        static member inline  darkKhaki = Interop.mkStyle "backgroundColor" "#BDB76B"
        static member inline  lavender = Interop.mkStyle "backgroundColor" "#E6E6FA"
        static member inline  thistle = Interop.mkStyle "backgroundColor" "#D8BFD8"
        static member inline  plum = Interop.mkStyle "backgroundColor" "#DDA0DD"
        static member inline  violet = Interop.mkStyle "backgroundColor" "#EE82EE"
        static member inline  orchid = Interop.mkStyle "backgroundColor" "#DA70D6"
        static member inline  fuchsia = Interop.mkStyle "backgroundColor" "#FF00FF"
        static member inline  magenta = Interop.mkStyle "backgroundColor" "#FF00FF"
        static member inline  mediumOrchid = Interop.mkStyle "backgroundColor" "#BA55D3"
        static member inline  mediumPurple = Interop.mkStyle "backgroundColor" "#9370DB"
        static member inline  rebeccaPurple = Interop.mkStyle "backgroundColor" "#663399"
        static member inline  blueViolet = Interop.mkStyle "backgroundColor" "#8A2BE2"
        static member inline  darkViolet = Interop.mkStyle "backgroundColor" "#9400D3"
        static member inline  darkOrchid = Interop.mkStyle "backgroundColor" "#9932CC"
        static member inline  darkMagenta = Interop.mkStyle "backgroundColor" "#8B008B"
        static member inline  purple = Interop.mkStyle "backgroundColor" "#800080"
        static member inline  indigo = Interop.mkStyle "backgroundColor" "#4B0082"
        static member inline  slateBlue = Interop.mkStyle "backgroundColor" "#6A5ACD"
        static member inline  darkSlateBlue = Interop.mkStyle "backgroundColor" "#483D8B"
        static member inline  mediumSlateBlue = Interop.mkStyle "backgroundColor" "#7B68EE"
        static member inline  greenYellow = Interop.mkStyle "backgroundColor" "#ADFF2F"
        static member inline  chartreuse = Interop.mkStyle "backgroundColor" "#7FFF00"
        static member inline  lawnGreen = Interop.mkStyle "backgroundColor" "#7CFC00"
        static member inline  lime = Interop.mkStyle "backgroundColor" "#00FF00"
        static member inline  limeGreen = Interop.mkStyle "backgroundColor" "#32CD32"
        static member inline  paleGreen = Interop.mkStyle "backgroundColor" "#98FB98"
        static member inline  lightGreen = Interop.mkStyle "backgroundColor" "#90EE90"
        static member inline  mediumSpringGreen = Interop.mkStyle "backgroundColor" "#00FA9A"
        static member inline  springGreen = Interop.mkStyle "backgroundColor" "#00FF7F"
        static member inline  mediumSeaGreen = Interop.mkStyle "backgroundColor" "#3CB371"
        static member inline  seaGreen = Interop.mkStyle "backgroundColor" "#2E8B57"
        static member inline  forestGreen = Interop.mkStyle "backgroundColor" "#228B22"
        static member inline  green = Interop.mkStyle "backgroundColor" "#008000"
        static member inline  darkGreen = Interop.mkStyle "backgroundColor" "#006400"
        static member inline  yellowGreen = Interop.mkStyle "backgroundColor" "#9ACD32"
        static member inline  oliveDrab = Interop.mkStyle "backgroundColor" "#6B8E23"
        static member inline  olive = Interop.mkStyle "backgroundColor" "#808000"
        static member inline  darkOliveGreen = Interop.mkStyle "backgroundColor" "#556B2F"
        static member inline  mediumAquamarine = Interop.mkStyle "backgroundColor" "#66CDAA"
        static member inline  darkSeaGreen = Interop.mkStyle "backgroundColor" "#8FBC8B"
        static member inline  lightSeaGreen = Interop.mkStyle "backgroundColor" "#20B2AA"
        static member inline  darkCyan = Interop.mkStyle "backgroundColor" "#008B8B"
        static member inline  teal = Interop.mkStyle "backgroundColor" "#008080"
        static member inline  aqua = Interop.mkStyle "backgroundColor" "#00FFFF"
        static member inline  cyan = Interop.mkStyle "backgroundColor" "#00FFFF"
        static member inline  lightCyan = Interop.mkStyle "backgroundColor" "#E0FFFF"
        static member inline  paleTurqouise = Interop.mkStyle "backgroundColor" "#AFEEEE"
        static member inline  aquaMarine = Interop.mkStyle "backgroundColor" "#7FFFD4"
        static member inline  turqouise = Interop.mkStyle "backgroundColor" "#AFEEEE"
        static member inline  mediumTurqouise = Interop.mkStyle "backgroundColor" "#48D1CC"
        static member inline  darkTurqouise = Interop.mkStyle "backgroundColor" "#00CED1"
        static member inline  cadetBlue = Interop.mkStyle "backgroundColor" "#5F9EA0"
        static member inline  steelBlue = Interop.mkStyle "backgroundColor" "#4682B4"
        static member inline  lightSteelBlue = Interop.mkStyle "backgroundColor" "#B0C4DE"
        static member inline  powederBlue = Interop.mkStyle "backgroundColor" "#B0E0E6"
        static member inline  lightBlue = Interop.mkStyle "backgroundColor" "#ADD8E6"
        static member inline  skyBlue = Interop.mkStyle "backgroundColor" "#87CEEB"
        static member inline  lightSkyBlue = Interop.mkStyle "backgroundColor" "#87CEFA"
        static member inline  deepSkyBlue = Interop.mkStyle "backgroundColor" "#00BFFF"
        static member inline  dodgerBlue = Interop.mkStyle "backgroundColor" "#1E90FF"
        static member inline  cornFlowerBlue = Interop.mkStyle "backgroundColor" "#6495ED"
        static member inline  royalBlue = Interop.mkStyle "backgroundColor" "#4169E1"
        static member inline  blue = Interop.mkStyle "backgroundColor" "#0000FF"
        static member inline  mediumBlue = Interop.mkStyle "backgroundColor" "#0000CD"
        static member inline  darkBlue = Interop.mkStyle "backgroundColor" "#00008B"
        static member inline  navy = Interop.mkStyle "backgroundColor" "#000080"
        static member inline  midnightBlue = Interop.mkStyle "backgroundColor" "#191970"
        static member inline  cornSilk = Interop.mkStyle "backgroundColor" "#FFF8DC"
        static member inline  blanchedAlmond = Interop.mkStyle "backgroundColor" "#FFEBCD"
        static member inline  bisque = Interop.mkStyle "backgroundColor" "#FFE4C4"
        static member inline  navajoWhite = Interop.mkStyle "backgroundColor" "#FFDEAD"
        static member inline  wheat = Interop.mkStyle "backgroundColor" "#F5DEB3"
        static member inline  burlyWood = Interop.mkStyle "backgroundColor" "#DEB887"
        static member inline  tan = Interop.mkStyle "backgroundColor" "#D2B48C"
        static member inline  rosyBrown = Interop.mkStyle "backgroundColor" "#BC8F8F"
        static member inline  sandyBrown = Interop.mkStyle "backgroundColor" "#F4A460"
        static member inline  goldenRod = Interop.mkStyle "backgroundColor" "#DAA520"
        static member inline  darkGoldenRod = Interop.mkStyle "backgroundColor" "#B8860B"
        static member inline  peru = Interop.mkStyle "backgroundColor" "#CD853F"
        static member inline  chocolate = Interop.mkStyle "backgroundColor" "#D2691E"
        static member inline  saddleBrown = Interop.mkStyle "backgroundColor" "#8B4513"
        static member inline  sienna = Interop.mkStyle "backgroundColor" "#A0522D"
        static member inline  brown = Interop.mkStyle "backgroundColor" "#A52A2A"
        static member inline  maroon = Interop.mkStyle "backgroundColor" "#A52A2A"
        static member inline  white = Interop.mkStyle "backgroundColor" "#FFFFFF"
        static member inline  snow = Interop.mkStyle "backgroundColor" "#FFFAFA"
        static member inline  honeyDew = Interop.mkStyle "backgroundColor" "#F0FFF0"
        static member inline  mintCream = Interop.mkStyle "backgroundColor" "#F5FFFA"
        static member inline  azure = Interop.mkStyle "backgroundColor" "#F0FFFF"
        static member inline  aliceBlue = Interop.mkStyle "backgroundColor" "#F0F8FF"
        static member inline  ghostWhite = Interop.mkStyle "backgroundColor" "#F8F8FF"
        static member inline  whiteSmoke = Interop.mkStyle "backgroundColor" "#F5F5F5"
        static member inline  seaShell = Interop.mkStyle "backgroundColor" "#FFF5EE"
        static member inline  beige = Interop.mkStyle "backgroundColor" "#F5F5DC"
        static member inline  oldLace = Interop.mkStyle "backgroundColor" "#FDF5E6"
        static member inline  floralWhite = Interop.mkStyle "backgroundColor" "#FFFAF0"
        static member inline  ivory = Interop.mkStyle "backgroundColor" "#FFFFF0"
        static member inline  antiqueWhite = Interop.mkStyle "backgroundColor" "#FAEBD7"
        static member inline  linen = Interop.mkStyle "backgroundColor" "#FAF0E6"
        static member inline  lavenderBlush = Interop.mkStyle "backgroundColor" "#FFF0F5"
        static member inline  mistyRose = Interop.mkStyle "backgroundColor" "#FFE4E1"
        static member inline  gainsBoro = Interop.mkStyle "backgroundColor" "#DCDCDC"
        static member inline  lightGray = Interop.mkStyle "backgroundColor" "#D3D3D3"
        static member inline  silver = Interop.mkStyle "backgroundColor" "#C0C0C0"
        static member inline  darkGray = Interop.mkStyle "backgroundColor" "#A9A9A9"
        static member inline  gray = Interop.mkStyle "backgroundColor" "#808080"
        static member inline  dimGray = Interop.mkStyle "backgroundColor" "#696969"
        static member inline  lightSlateGray = Interop.mkStyle "backgroundColor" "#778899"
        static member inline  slateGray = Interop.mkStyle "backgroundColor" "#708090"
        static member inline  darkSlateGray = Interop.mkStyle "backgroundColor" "#2F4F4F"
        static member inline  black = Interop.mkStyle "backgroundColor" "#000000"
        static member inline  transparent = Interop.mkStyle "backgroundColor" "transparent"


    [<Erase; RequireQualifiedAccess>]
    type borderColor =
        static member inline  indianRed = Interop.mkStyle "borderColor" "#CD5C5C"
        static member inline  lightCoral = Interop.mkStyle "borderColor" "#F08080"
        static member inline  salmon = Interop.mkStyle "borderColor" "#FA8072"
        static member inline  darkSalmon = Interop.mkStyle "borderColor" "#E9967A"
        static member inline  lightSalmon = Interop.mkStyle "borderColor" "#FFA07A"
        static member inline  crimson = Interop.mkStyle "borderColor" "#DC143C"
        static member inline  red = Interop.mkStyle "borderColor" "#FF0000"
        static member inline  fireBrick = Interop.mkStyle "borderColor" "#B22222"
        static member inline  darkred = Interop.mkStyle "borderColor" "#8B0000"
        static member inline  pink = Interop.mkStyle "borderColor" "#FFC0CB"
        static member inline  lightPink = Interop.mkStyle "borderColor" "#FFB6C1"
        static member inline  hotPink = Interop.mkStyle "borderColor" "#FF69B4"
        static member inline  deepPink = Interop.mkStyle "borderColor" "#FF1493"
        static member inline  mediumVioletRed = Interop.mkStyle "borderColor" "#C71585"
        static member inline  paleVioletRed = Interop.mkStyle "borderColor" "#DB7093"
        static member inline  coral = Interop.mkStyle "borderColor" "#FF7F50"
        static member inline  tomato = Interop.mkStyle "borderColor" "#FF6347"
        static member inline  orangeRed = Interop.mkStyle "borderColor" "#FF4500"
        static member inline  darkOrange = Interop.mkStyle "borderColor" "#FF8C00"
        static member inline  orange = Interop.mkStyle "borderColor" "#FFA500"
        static member inline  gold = Interop.mkStyle "borderColor" "#FFD700"
        static member inline  yellow = Interop.mkStyle "borderColor" "#FFFF00"
        static member inline  lightYellow = Interop.mkStyle "borderColor" "#FFFFE0"
        static member inline  limonChiffon = Interop.mkStyle "borderColor" "#FFFACD"
        static member inline  lightGoldenRodYellow = Interop.mkStyle "borderColor" "#FAFAD2"
        static member inline  papayaWhip = Interop.mkStyle "borderColor" "#FFEFD5"
        static member inline  moccasin = Interop.mkStyle "borderColor" "#FFE4B5"
        static member inline  peachPuff = Interop.mkStyle "borderColor" "#FFDAB9"
        static member inline  paleGoldenRod = Interop.mkStyle "borderColor" "#EEE8AA"
        static member inline  khaki = Interop.mkStyle "borderColor" "#F0E68C"
        static member inline  darkKhaki = Interop.mkStyle "borderColor" "#BDB76B"
        static member inline  lavender = Interop.mkStyle "borderColor" "#E6E6FA"
        static member inline  thistle = Interop.mkStyle "borderColor" "#D8BFD8"
        static member inline  plum = Interop.mkStyle "borderColor" "#DDA0DD"
        static member inline  violet = Interop.mkStyle "borderColor" "#EE82EE"
        static member inline  orchid = Interop.mkStyle "borderColor" "#DA70D6"
        static member inline  fuchsia = Interop.mkStyle "borderColor" "#FF00FF"
        static member inline  magenta = Interop.mkStyle "borderColor" "#FF00FF"
        static member inline  mediumOrchid = Interop.mkStyle "borderColor" "#BA55D3"
        static member inline  mediumPurple = Interop.mkStyle "borderColor" "#9370DB"
        static member inline  rebeccaPurple = Interop.mkStyle "borderColor" "#663399"
        static member inline  blueViolet = Interop.mkStyle "borderColor" "#8A2BE2"
        static member inline  darkViolet = Interop.mkStyle "borderColor" "#9400D3"
        static member inline  darkOrchid = Interop.mkStyle "borderColor" "#9932CC"
        static member inline  darkMagenta = Interop.mkStyle "borderColor" "#8B008B"
        static member inline  purple = Interop.mkStyle "borderColor" "#800080"
        static member inline  indigo = Interop.mkStyle "borderColor" "#4B0082"
        static member inline  slateBlue = Interop.mkStyle "borderColor" "#6A5ACD"
        static member inline  darkSlateBlue = Interop.mkStyle "borderColor" "#483D8B"
        static member inline  mediumSlateBlue = Interop.mkStyle "borderColor" "#7B68EE"
        static member inline  greenYellow = Interop.mkStyle "borderColor" "#ADFF2F"
        static member inline  chartreuse = Interop.mkStyle "borderColor" "#7FFF00"
        static member inline  lawnGreen = Interop.mkStyle "borderColor" "#7CFC00"
        static member inline  lime = Interop.mkStyle "borderColor" "#00FF00"
        static member inline  limeGreen = Interop.mkStyle "borderColor" "#32CD32"
        static member inline  paleGreen = Interop.mkStyle "borderColor" "#98FB98"
        static member inline  lightGreen = Interop.mkStyle "borderColor" "#90EE90"
        static member inline  mediumSpringGreen = Interop.mkStyle "borderColor" "#00FA9A"
        static member inline  springGreen = Interop.mkStyle "borderColor" "#00FF7F"
        static member inline  mediumSeaGreen = Interop.mkStyle "borderColor" "#3CB371"
        static member inline  seaGreen = Interop.mkStyle "borderColor" "#2E8B57"
        static member inline  forestGreen = Interop.mkStyle "borderColor" "#228B22"
        static member inline  green = Interop.mkStyle "borderColor" "#008000"
        static member inline  darkGreen = Interop.mkStyle "borderColor" "#006400"
        static member inline  yellowGreen = Interop.mkStyle "borderColor" "#9ACD32"
        static member inline  oliveDrab = Interop.mkStyle "borderColor" "#6B8E23"
        static member inline  olive = Interop.mkStyle "borderColor" "#808000"
        static member inline  darkOliveGreen = Interop.mkStyle "borderColor" "#556B2F"
        static member inline  mediumAquamarine = Interop.mkStyle "borderColor" "#66CDAA"
        static member inline  darkSeaGreen = Interop.mkStyle "borderColor" "#8FBC8B"
        static member inline  lightSeaGreen = Interop.mkStyle "borderColor" "#20B2AA"
        static member inline  darkCyan = Interop.mkStyle "borderColor" "#008B8B"
        static member inline  teal = Interop.mkStyle "borderColor" "#008080"
        static member inline  aqua = Interop.mkStyle "borderColor" "#00FFFF"
        static member inline  cyan = Interop.mkStyle "borderColor" "#00FFFF"
        static member inline  lightCyan = Interop.mkStyle "borderColor" "#E0FFFF"
        static member inline  paleTurqouise = Interop.mkStyle "borderColor" "#AFEEEE"
        static member inline  aquaMarine = Interop.mkStyle "borderColor" "#7FFFD4"
        static member inline  turqouise = Interop.mkStyle "borderColor" "#AFEEEE"
        static member inline  mediumTurqouise = Interop.mkStyle "borderColor" "#48D1CC"
        static member inline  darkTurqouise = Interop.mkStyle "borderColor" "#00CED1"
        static member inline  cadetBlue = Interop.mkStyle "borderColor" "#5F9EA0"
        static member inline  steelBlue = Interop.mkStyle "borderColor" "#4682B4"
        static member inline  lightSteelBlue = Interop.mkStyle "borderColor" "#B0C4DE"
        static member inline  powederBlue = Interop.mkStyle "borderColor" "#B0E0E6"
        static member inline  lightBlue = Interop.mkStyle "borderColor" "#ADD8E6"
        static member inline  skyBlue = Interop.mkStyle "borderColor" "#87CEEB"
        static member inline  lightSkyBlue = Interop.mkStyle "borderColor" "#87CEFA"
        static member inline  deepSkyBlue = Interop.mkStyle "borderColor" "#00BFFF"
        static member inline  dodgerBlue = Interop.mkStyle "borderColor" "#1E90FF"
        static member inline  cornFlowerBlue = Interop.mkStyle "borderColor" "#6495ED"
        static member inline  royalBlue = Interop.mkStyle "borderColor" "#4169E1"
        static member inline  blue = Interop.mkStyle "borderColor" "#0000FF"
        static member inline  mediumBlue = Interop.mkStyle "borderColor" "#0000CD"
        static member inline  darkBlue = Interop.mkStyle "borderColor" "#00008B"
        static member inline  navy = Interop.mkStyle "borderColor" "#000080"
        static member inline  midnightBlue = Interop.mkStyle "borderColor" "#191970"
        static member inline  cornSilk = Interop.mkStyle "borderColor" "#FFF8DC"
        static member inline  blanchedAlmond = Interop.mkStyle "borderColor" "#FFEBCD"
        static member inline  bisque = Interop.mkStyle "borderColor" "#FFE4C4"
        static member inline  navajoWhite = Interop.mkStyle "borderColor" "#FFDEAD"
        static member inline  wheat = Interop.mkStyle "borderColor" "#F5DEB3"
        static member inline  burlyWood = Interop.mkStyle "borderColor" "#DEB887"
        static member inline  tan = Interop.mkStyle "borderColor" "#D2B48C"
        static member inline  rosyBrown = Interop.mkStyle "borderColor" "#BC8F8F"
        static member inline  sandyBrown = Interop.mkStyle "borderColor" "#F4A460"
        static member inline  goldenRod = Interop.mkStyle "borderColor" "#DAA520"
        static member inline  darkGoldenRod = Interop.mkStyle "borderColor" "#B8860B"
        static member inline  peru = Interop.mkStyle "borderColor" "#CD853F"
        static member inline  chocolate = Interop.mkStyle "borderColor" "#D2691E"
        static member inline  saddleBrown = Interop.mkStyle "borderColor" "#8B4513"
        static member inline  sienna = Interop.mkStyle "borderColor" "#A0522D"
        static member inline  brown = Interop.mkStyle "borderColor" "#A52A2A"
        static member inline  maroon = Interop.mkStyle "borderColor" "#A52A2A"
        static member inline  white = Interop.mkStyle "borderColor" "#FFFFFF"
        static member inline  snow = Interop.mkStyle "borderColor" "#FFFAFA"
        static member inline  honeyDew = Interop.mkStyle "borderColor" "#F0FFF0"
        static member inline  mintCream = Interop.mkStyle "borderColor" "#F5FFFA"
        static member inline  azure = Interop.mkStyle "borderColor" "#F0FFFF"
        static member inline  aliceBlue = Interop.mkStyle "borderColor" "#F0F8FF"
        static member inline  ghostWhite = Interop.mkStyle "borderColor" "#F8F8FF"
        static member inline  whiteSmoke = Interop.mkStyle "borderColor" "#F5F5F5"
        static member inline  seaShell = Interop.mkStyle "borderColor" "#FFF5EE"
        static member inline  beige = Interop.mkStyle "borderColor" "#F5F5DC"
        static member inline  oldLace = Interop.mkStyle "borderColor" "#FDF5E6"
        static member inline  floralWhite = Interop.mkStyle "borderColor" "#FFFAF0"
        static member inline  ivory = Interop.mkStyle "borderColor" "#FFFFF0"
        static member inline  antiqueWhite = Interop.mkStyle "borderColor" "#FAEBD7"
        static member inline  linen = Interop.mkStyle "borderColor" "#FAF0E6"
        static member inline  lavenderBlush = Interop.mkStyle "borderColor" "#FFF0F5"
        static member inline  mistyRose = Interop.mkStyle "borderColor" "#FFE4E1"
        static member inline  gainsBoro = Interop.mkStyle "borderColor" "#DCDCDC"
        static member inline  lightGray = Interop.mkStyle "borderColor" "#D3D3D3"
        static member inline  silver = Interop.mkStyle "borderColor" "#C0C0C0"
        static member inline  darkGray = Interop.mkStyle "borderColor" "#A9A9A9"
        static member inline  gray = Interop.mkStyle "borderColor" "#808080"
        static member inline  dimGray = Interop.mkStyle "borderColor" "#696969"
        static member inline  lightSlateGray = Interop.mkStyle "borderColor" "#778899"
        static member inline  slateGray = Interop.mkStyle "borderColor" "#708090"
        static member inline  darkSlateGray = Interop.mkStyle "borderColor" "#2F4F4F"
        static member inline  black = Interop.mkStyle "borderColor" "#000000"
        static member inline  transparent = Interop.mkStyle "borderColor" "transparent"

    [<Erase; RequireQualifiedAccess>]
    type color =
        static member inline  indianRed = Interop.mkStyle "color" "#CD5C5C"
        static member inline  lightCoral = Interop.mkStyle "color" "#F08080"
        static member inline  salmon = Interop.mkStyle "color" "#FA8072"
        static member inline  darkSalmon = Interop.mkStyle "color" "#E9967A"
        static member inline  lightSalmon = Interop.mkStyle "color" "#FFA07A"
        static member inline  crimson = Interop.mkStyle "color" "#DC143C"
        static member inline  red = Interop.mkStyle "color" "#FF0000"
        static member inline  fireBrick = Interop.mkStyle "color" "#B22222"
        static member inline  darkred = Interop.mkStyle "color" "#8B0000"
        static member inline  pink = Interop.mkStyle "color" "#FFC0CB"
        static member inline  lightPink = Interop.mkStyle "color" "#FFB6C1"
        static member inline  hotPink = Interop.mkStyle "color" "#FF69B4"
        static member inline  deepPink = Interop.mkStyle "color" "#FF1493"
        static member inline  mediumVioletRed = Interop.mkStyle "color" "#C71585"
        static member inline  paleVioletRed = Interop.mkStyle "color" "#DB7093"
        static member inline  coral = Interop.mkStyle "color" "#FF7F50"
        static member inline  tomato = Interop.mkStyle "color" "#FF6347"
        static member inline  orangeRed = Interop.mkStyle "color" "#FF4500"
        static member inline  darkOrange = Interop.mkStyle "color" "#FF8C00"
        static member inline  orange = Interop.mkStyle "color" "#FFA500"
        static member inline  gold = Interop.mkStyle "color" "#FFD700"
        static member inline  yellow = Interop.mkStyle "color" "#FFFF00"
        static member inline  lightYellow = Interop.mkStyle "color" "#FFFFE0"
        static member inline  limonChiffon = Interop.mkStyle "color" "#FFFACD"
        static member inline  lightGoldenRodYellow = Interop.mkStyle "color" "#FAFAD2"
        static member inline  papayaWhip = Interop.mkStyle "color" "#FFEFD5"
        static member inline  moccasin = Interop.mkStyle "color" "#FFE4B5"
        static member inline  peachPuff = Interop.mkStyle "color" "#FFDAB9"
        static member inline  paleGoldenRod = Interop.mkStyle "color" "#EEE8AA"
        static member inline  khaki = Interop.mkStyle "color" "#F0E68C"
        static member inline  darkKhaki = Interop.mkStyle "color" "#BDB76B"
        static member inline  lavender = Interop.mkStyle "color" "#E6E6FA"
        static member inline  thistle = Interop.mkStyle "color" "#D8BFD8"
        static member inline  plum = Interop.mkStyle "color" "#DDA0DD"
        static member inline  violet = Interop.mkStyle "color" "#EE82EE"
        static member inline  orchid = Interop.mkStyle "color" "#DA70D6"
        static member inline  fuchsia = Interop.mkStyle "color" "#FF00FF"
        static member inline  magenta = Interop.mkStyle "color" "#FF00FF"
        static member inline  mediumOrchid = Interop.mkStyle "color" "#BA55D3"
        static member inline  mediumPurple = Interop.mkStyle "color" "#9370DB"
        static member inline  rebeccaPurple = Interop.mkStyle "color" "#663399"
        static member inline  blueViolet = Interop.mkStyle "color" "#8A2BE2"
        static member inline  darkViolet = Interop.mkStyle "color" "#9400D3"
        static member inline  darkOrchid = Interop.mkStyle "color" "#9932CC"
        static member inline  darkMagenta = Interop.mkStyle "color" "#8B008B"
        static member inline  purple = Interop.mkStyle "color" "#800080"
        static member inline  indigo = Interop.mkStyle "color" "#4B0082"
        static member inline  slateBlue = Interop.mkStyle "color" "#6A5ACD"
        static member inline  darkSlateBlue = Interop.mkStyle "color" "#483D8B"
        static member inline  mediumSlateBlue = Interop.mkStyle "color" "#7B68EE"
        static member inline  greenYellow = Interop.mkStyle "color" "#ADFF2F"
        static member inline  chartreuse = Interop.mkStyle "color" "#7FFF00"
        static member inline  lawnGreen = Interop.mkStyle "color" "#7CFC00"
        static member inline  lime = Interop.mkStyle "color" "#00FF00"
        static member inline  limeGreen = Interop.mkStyle "color" "#32CD32"
        static member inline  paleGreen = Interop.mkStyle "color" "#98FB98"
        static member inline  lightGreen = Interop.mkStyle "color" "#90EE90"
        static member inline  mediumSpringGreen = Interop.mkStyle "color" "#00FA9A"
        static member inline  springGreen = Interop.mkStyle "color" "#00FF7F"
        static member inline  mediumSeaGreen = Interop.mkStyle "color" "#3CB371"
        static member inline  seaGreen = Interop.mkStyle "color" "#2E8B57"
        static member inline  forestGreen = Interop.mkStyle "color" "#228B22"
        static member inline  green = Interop.mkStyle "color" "#008000"
        static member inline  darkGreen = Interop.mkStyle "color" "#006400"
        static member inline  yellowGreen = Interop.mkStyle "color" "#9ACD32"
        static member inline  oliveDrab = Interop.mkStyle "color" "#6B8E23"
        static member inline  olive = Interop.mkStyle "color" "#808000"
        static member inline  darkOliveGreen = Interop.mkStyle "color" "#556B2F"
        static member inline  mediumAquamarine = Interop.mkStyle "color" "#66CDAA"
        static member inline  darkSeaGreen = Interop.mkStyle "color" "#8FBC8B"
        static member inline  lightSeaGreen = Interop.mkStyle "color" "#20B2AA"
        static member inline  darkCyan = Interop.mkStyle "color" "#008B8B"
        static member inline  teal = Interop.mkStyle "color" "#008080"
        static member inline  aqua = Interop.mkStyle "color" "#00FFFF"
        static member inline  cyan = Interop.mkStyle "color" "#00FFFF"
        static member inline  lightCyan = Interop.mkStyle "color" "#E0FFFF"
        static member inline  paleTurqouise = Interop.mkStyle "color" "#AFEEEE"
        static member inline  aquaMarine = Interop.mkStyle "color" "#7FFFD4"
        static member inline  turqouise = Interop.mkStyle "color" "#AFEEEE"
        static member inline  mediumTurqouise = Interop.mkStyle "color" "#48D1CC"
        static member inline  darkTurqouise = Interop.mkStyle "color" "#00CED1"
        static member inline  cadetBlue = Interop.mkStyle "color" "#5F9EA0"
        static member inline  steelBlue = Interop.mkStyle "color" "#4682B4"
        static member inline  lightSteelBlue = Interop.mkStyle "color" "#B0C4DE"
        static member inline  powederBlue = Interop.mkStyle "color" "#B0E0E6"
        static member inline  lightBlue = Interop.mkStyle "color" "#ADD8E6"
        static member inline  skyBlue = Interop.mkStyle "color" "#87CEEB"
        static member inline  lightSkyBlue = Interop.mkStyle "color" "#87CEFA"
        static member inline  deepSkyBlue = Interop.mkStyle "color" "#00BFFF"
        static member inline  dodgerBlue = Interop.mkStyle "color" "#1E90FF"
        static member inline  cornFlowerBlue = Interop.mkStyle "color" "#6495ED"
        static member inline  royalBlue = Interop.mkStyle "color" "#4169E1"
        static member inline  blue = Interop.mkStyle "color" "#0000FF"
        static member inline  mediumBlue = Interop.mkStyle "color" "#0000CD"
        static member inline  darkBlue = Interop.mkStyle "color" "#00008B"
        static member inline  navy = Interop.mkStyle "color" "#000080"
        static member inline  midnightBlue = Interop.mkStyle "color" "#191970"
        static member inline  cornSilk = Interop.mkStyle "color" "#FFF8DC"
        static member inline  blanchedAlmond = Interop.mkStyle "color" "#FFEBCD"
        static member inline  bisque = Interop.mkStyle "color" "#FFE4C4"
        static member inline  navajoWhite = Interop.mkStyle "color" "#FFDEAD"
        static member inline  wheat = Interop.mkStyle "color" "#F5DEB3"
        static member inline  burlyWood = Interop.mkStyle "color" "#DEB887"
        static member inline  tan = Interop.mkStyle "color" "#D2B48C"
        static member inline  rosyBrown = Interop.mkStyle "color" "#BC8F8F"
        static member inline  sandyBrown = Interop.mkStyle "color" "#F4A460"
        static member inline  goldenRod = Interop.mkStyle "color" "#DAA520"
        static member inline  darkGoldenRod = Interop.mkStyle "color" "#B8860B"
        static member inline  peru = Interop.mkStyle "color" "#CD853F"
        static member inline  chocolate = Interop.mkStyle "color" "#D2691E"
        static member inline  saddleBrown = Interop.mkStyle "color" "#8B4513"
        static member inline  sienna = Interop.mkStyle "color" "#A0522D"
        static member inline  brown = Interop.mkStyle "color" "#A52A2A"
        static member inline  maroon = Interop.mkStyle "color" "#A52A2A"
        static member inline  white = Interop.mkStyle "color" "#FFFFFF"
        static member inline  snow = Interop.mkStyle "color" "#FFFAFA"
        static member inline  honeyDew = Interop.mkStyle "color" "#F0FFF0"
        static member inline  mintCream = Interop.mkStyle "color" "#F5FFFA"
        static member inline  azure = Interop.mkStyle "color" "#F0FFFF"
        static member inline  aliceBlue = Interop.mkStyle "color" "#F0F8FF"
        static member inline  ghostWhite = Interop.mkStyle "color" "#F8F8FF"
        static member inline  whiteSmoke = Interop.mkStyle "color" "#F5F5F5"
        static member inline  seaShell = Interop.mkStyle "color" "#FFF5EE"
        static member inline  beige = Interop.mkStyle "color" "#F5F5DC"
        static member inline  oldLace = Interop.mkStyle "color" "#FDF5E6"
        static member inline  floralWhite = Interop.mkStyle "color" "#FFFAF0"
        static member inline  ivory = Interop.mkStyle "color" "#FFFFF0"
        static member inline  antiqueWhite = Interop.mkStyle "color" "#FAEBD7"
        static member inline  linen = Interop.mkStyle "color" "#FAF0E6"
        static member inline  lavenderBlush = Interop.mkStyle "color" "#FFF0F5"
        static member inline  mistyRose = Interop.mkStyle "color" "#FFE4E1"
        static member inline  gainsBoro = Interop.mkStyle "color" "#DCDCDC"
        static member inline  lightGray = Interop.mkStyle "color" "#D3D3D3"
        static member inline  silver = Interop.mkStyle "color" "#C0C0C0"
        static member inline  darkGray = Interop.mkStyle "color" "#A9A9A9"
        static member inline  gray = Interop.mkStyle "color" "#808080"
        static member inline  dimGray = Interop.mkStyle "color" "#696969"
        static member inline  lightSlateGray = Interop.mkStyle "color" "#778899"
        static member inline  slateGray = Interop.mkStyle "color" "#708090"
        static member inline  darkSlateGray = Interop.mkStyle "color" "#2F4F4F"
        static member inline  black = Interop.mkStyle "color" "#000000"
        static member inline  transparent = Interop.mkStyle "color" "transparent"

    [<Erase; RequireQualifiedAccess>]
    type textDecorationColor =
        static member inline  indianRed = Interop.mkStyle "textDecorationColor" "#CD5C5C"
        static member inline  lightCoral = Interop.mkStyle "textDecorationColor" "#F08080"
        static member inline  salmon = Interop.mkStyle "textDecorationColor" "#FA8072"
        static member inline  darkSalmon = Interop.mkStyle "textDecorationColor" "#E9967A"
        static member inline  lightSalmon = Interop.mkStyle "textDecorationColor" "#FFA07A"
        static member inline  crimson = Interop.mkStyle "textDecorationColor" "#DC143C"
        static member inline  red = Interop.mkStyle "textDecorationColor" "#FF0000"
        static member inline  fireBrick = Interop.mkStyle "textDecorationColor" "#B22222"
        static member inline  darkred = Interop.mkStyle "textDecorationColor" "#8B0000"
        static member inline  pink = Interop.mkStyle "textDecorationColor" "#FFC0CB"
        static member inline  lightPink = Interop.mkStyle "textDecorationColor" "#FFB6C1"
        static member inline  hotPink = Interop.mkStyle "textDecorationColor" "#FF69B4"
        static member inline  deepPink = Interop.mkStyle "textDecorationColor" "#FF1493"
        static member inline  mediumVioletRed = Interop.mkStyle "textDecorationColor" "#C71585"
        static member inline  paleVioletRed = Interop.mkStyle "textDecorationColor" "#DB7093"
        static member inline  coral = Interop.mkStyle "textDecorationColor" "#FF7F50"
        static member inline  tomato = Interop.mkStyle "textDecorationColor" "#FF6347"
        static member inline  orangeRed = Interop.mkStyle "textDecorationColor" "#FF4500"
        static member inline  darkOrange = Interop.mkStyle "textDecorationColor" "#FF8C00"
        static member inline  orange = Interop.mkStyle "textDecorationColor" "#FFA500"
        static member inline  gold = Interop.mkStyle "textDecorationColor" "#FFD700"
        static member inline  yellow = Interop.mkStyle "textDecorationColor" "#FFFF00"
        static member inline  lightYellow = Interop.mkStyle "textDecorationColor" "#FFFFE0"
        static member inline  limonChiffon = Interop.mkStyle "textDecorationColor" "#FFFACD"
        static member inline  lightGoldenRodYellow = Interop.mkStyle "textDecorationColor" "#FAFAD2"
        static member inline  papayaWhip = Interop.mkStyle "textDecorationColor" "#FFEFD5"
        static member inline  moccasin = Interop.mkStyle "textDecorationColor" "#FFE4B5"
        static member inline  peachPuff = Interop.mkStyle "textDecorationColor" "#FFDAB9"
        static member inline  paleGoldenRod = Interop.mkStyle "textDecorationColor" "#EEE8AA"
        static member inline  khaki = Interop.mkStyle "textDecorationColor" "#F0E68C"
        static member inline  darkKhaki = Interop.mkStyle "textDecorationColor" "#BDB76B"
        static member inline  lavender = Interop.mkStyle "textDecorationColor" "#E6E6FA"
        static member inline  thistle = Interop.mkStyle "textDecorationColor" "#D8BFD8"
        static member inline  plum = Interop.mkStyle "textDecorationColor" "#DDA0DD"
        static member inline  violet = Interop.mkStyle "textDecorationColor" "#EE82EE"
        static member inline  orchid = Interop.mkStyle "textDecorationColor" "#DA70D6"
        static member inline  fuchsia = Interop.mkStyle "textDecorationColor" "#FF00FF"
        static member inline  magenta = Interop.mkStyle "textDecorationColor" "#FF00FF"
        static member inline  mediumOrchid = Interop.mkStyle "textDecorationColor" "#BA55D3"
        static member inline  mediumPurple = Interop.mkStyle "textDecorationColor" "#9370DB"
        static member inline  rebeccaPurple = Interop.mkStyle "textDecorationColor" "#663399"
        static member inline  blueViolet = Interop.mkStyle "textDecorationColor" "#8A2BE2"
        static member inline  darkViolet = Interop.mkStyle "textDecorationColor" "#9400D3"
        static member inline  darkOrchid = Interop.mkStyle "textDecorationColor" "#9932CC"
        static member inline  darkMagenta = Interop.mkStyle "textDecorationColor" "#8B008B"
        static member inline  purple = Interop.mkStyle "textDecorationColor" "#800080"
        static member inline  indigo = Interop.mkStyle "textDecorationColor" "#4B0082"
        static member inline  slateBlue = Interop.mkStyle "textDecorationColor" "#6A5ACD"
        static member inline  darkSlateBlue = Interop.mkStyle "textDecorationColor" "#483D8B"
        static member inline  mediumSlateBlue = Interop.mkStyle "textDecorationColor" "#7B68EE"
        static member inline  greenYellow = Interop.mkStyle "textDecorationColor" "#ADFF2F"
        static member inline  chartreuse = Interop.mkStyle "textDecorationColor" "#7FFF00"
        static member inline  lawnGreen = Interop.mkStyle "textDecorationColor" "#7CFC00"
        static member inline  lime = Interop.mkStyle "textDecorationColor" "#00FF00"
        static member inline  limeGreen = Interop.mkStyle "textDecorationColor" "#32CD32"
        static member inline  paleGreen = Interop.mkStyle "textDecorationColor" "#98FB98"
        static member inline  lightGreen = Interop.mkStyle "textDecorationColor" "#90EE90"
        static member inline  mediumSpringGreen = Interop.mkStyle "textDecorationColor" "#00FA9A"
        static member inline  springGreen = Interop.mkStyle "textDecorationColor" "#00FF7F"
        static member inline  mediumSeaGreen = Interop.mkStyle "textDecorationColor" "#3CB371"
        static member inline  seaGreen = Interop.mkStyle "textDecorationColor" "#2E8B57"
        static member inline  forestGreen = Interop.mkStyle "textDecorationColor" "#228B22"
        static member inline  green = Interop.mkStyle "textDecorationColor" "#008000"
        static member inline  darkGreen = Interop.mkStyle "textDecorationColor" "#006400"
        static member inline  yellowGreen = Interop.mkStyle "textDecorationColor" "#9ACD32"
        static member inline  oliveDrab = Interop.mkStyle "textDecorationColor" "#6B8E23"
        static member inline  olive = Interop.mkStyle "textDecorationColor" "#808000"
        static member inline  darkOliveGreen = Interop.mkStyle "textDecorationColor" "#556B2F"
        static member inline  mediumAquamarine = Interop.mkStyle "textDecorationColor" "#66CDAA"
        static member inline  darkSeaGreen = Interop.mkStyle "textDecorationColor" "#8FBC8B"
        static member inline  lightSeaGreen = Interop.mkStyle "textDecorationColor" "#20B2AA"
        static member inline  darkCyan = Interop.mkStyle "textDecorationColor" "#008B8B"
        static member inline  teal = Interop.mkStyle "textDecorationColor" "#008080"
        static member inline  aqua = Interop.mkStyle "textDecorationColor" "#00FFFF"
        static member inline  cyan = Interop.mkStyle "textDecorationColor" "#00FFFF"
        static member inline  lightCyan = Interop.mkStyle "textDecorationColor" "#E0FFFF"
        static member inline  paleTurqouise = Interop.mkStyle "textDecorationColor" "#AFEEEE"
        static member inline  aquaMarine = Interop.mkStyle "textDecorationColor" "#7FFFD4"
        static member inline  turqouise = Interop.mkStyle "textDecorationColor" "#AFEEEE"
        static member inline  mediumTurqouise = Interop.mkStyle "textDecorationColor" "#48D1CC"
        static member inline  darkTurqouise = Interop.mkStyle "textDecorationColor" "#00CED1"
        static member inline  cadetBlue = Interop.mkStyle "textDecorationColor" "#5F9EA0"
        static member inline  steelBlue = Interop.mkStyle "textDecorationColor" "#4682B4"
        static member inline  lightSteelBlue = Interop.mkStyle "textDecorationColor" "#B0C4DE"
        static member inline  powederBlue = Interop.mkStyle "textDecorationColor" "#B0E0E6"
        static member inline  lightBlue = Interop.mkStyle "textDecorationColor" "#ADD8E6"
        static member inline  skyBlue = Interop.mkStyle "textDecorationColor" "#87CEEB"
        static member inline  lightSkyBlue = Interop.mkStyle "textDecorationColor" "#87CEFA"
        static member inline  deepSkyBlue = Interop.mkStyle "textDecorationColor" "#00BFFF"
        static member inline  dodgerBlue = Interop.mkStyle "textDecorationColor" "#1E90FF"
        static member inline  cornFlowerBlue = Interop.mkStyle "textDecorationColor" "#6495ED"
        static member inline  royalBlue = Interop.mkStyle "textDecorationColor" "#4169E1"
        static member inline  blue = Interop.mkStyle "textDecorationColor" "#0000FF"
        static member inline  mediumBlue = Interop.mkStyle "textDecorationColor" "#0000CD"
        static member inline  darkBlue = Interop.mkStyle "textDecorationColor" "#00008B"
        static member inline  navy = Interop.mkStyle "textDecorationColor" "#000080"
        static member inline  midnightBlue = Interop.mkStyle "textDecorationColor" "#191970"
        static member inline  cornSilk = Interop.mkStyle "textDecorationColor" "#FFF8DC"
        static member inline  blanchedAlmond = Interop.mkStyle "textDecorationColor" "#FFEBCD"
        static member inline  bisque = Interop.mkStyle "textDecorationColor" "#FFE4C4"
        static member inline  navajoWhite = Interop.mkStyle "textDecorationColor" "#FFDEAD"
        static member inline  wheat = Interop.mkStyle "textDecorationColor" "#F5DEB3"
        static member inline  burlyWood = Interop.mkStyle "textDecorationColor" "#DEB887"
        static member inline  tan = Interop.mkStyle "textDecorationColor" "#D2B48C"
        static member inline  rosyBrown = Interop.mkStyle "textDecorationColor" "#BC8F8F"
        static member inline  sandyBrown = Interop.mkStyle "textDecorationColor" "#F4A460"
        static member inline  goldenRod = Interop.mkStyle "textDecorationColor" "#DAA520"
        static member inline  darkGoldenRod = Interop.mkStyle "textDecorationColor" "#B8860B"
        static member inline  peru = Interop.mkStyle "textDecorationColor" "#CD853F"
        static member inline  chocolate = Interop.mkStyle "textDecorationColor" "#D2691E"
        static member inline  saddleBrown = Interop.mkStyle "textDecorationColor" "#8B4513"
        static member inline  sienna = Interop.mkStyle "textDecorationColor" "#A0522D"
        static member inline  brown = Interop.mkStyle "textDecorationColor" "#A52A2A"
        static member inline  maroon = Interop.mkStyle "textDecorationColor" "#A52A2A"
        static member inline  white = Interop.mkStyle "textDecorationColor" "#FFFFFF"
        static member inline  snow = Interop.mkStyle "textDecorationColor" "#FFFAFA"
        static member inline  honeyDew = Interop.mkStyle "textDecorationColor" "#F0FFF0"
        static member inline  mintCream = Interop.mkStyle "textDecorationColor" "#F5FFFA"
        static member inline  azure = Interop.mkStyle "textDecorationColor" "#F0FFFF"
        static member inline  aliceBlue = Interop.mkStyle "textDecorationColor" "#F0F8FF"
        static member inline  ghostWhite = Interop.mkStyle "textDecorationColor" "#F8F8FF"
        static member inline  whiteSmoke = Interop.mkStyle "textDecorationColor" "#F5F5F5"
        static member inline  seaShell = Interop.mkStyle "textDecorationColor" "#FFF5EE"
        static member inline  beige = Interop.mkStyle "textDecorationColor" "#F5F5DC"
        static member inline  oldLace = Interop.mkStyle "textDecorationColor" "#FDF5E6"
        static member inline  floralWhite = Interop.mkStyle "textDecorationColor" "#FFFAF0"
        static member inline  ivory = Interop.mkStyle "textDecorationColor" "#FFFFF0"
        static member inline  antiqueWhite = Interop.mkStyle "textDecorationColor" "#FAEBD7"
        static member inline  linen = Interop.mkStyle "textDecorationColor" "#FAF0E6"
        static member inline  lavenderBlush = Interop.mkStyle "textDecorationColor" "#FFF0F5"
        static member inline  mistyRose = Interop.mkStyle "textDecorationColor" "#FFE4E1"
        static member inline  gainsBoro = Interop.mkStyle "textDecorationColor" "#DCDCDC"
        static member inline  lightGray = Interop.mkStyle "textDecorationColor" "#D3D3D3"
        static member inline  silver = Interop.mkStyle "textDecorationColor" "#C0C0C0"
        static member inline  darkGray = Interop.mkStyle "textDecorationColor" "#A9A9A9"
        static member inline  gray = Interop.mkStyle "textDecorationColor" "#808080"
        static member inline  dimGray = Interop.mkStyle "textDecorationColor" "#696969"
        static member inline  lightSlateGray = Interop.mkStyle "textDecorationColor" "#778899"
        static member inline  slateGray = Interop.mkStyle "textDecorationColor" "#708090"
        static member inline  darkSlateGray = Interop.mkStyle "textDecorationColor" "#2F4F4F"
        static member inline  black = Interop.mkStyle "textDecorationColor" "#000000"
        static member inline  transparent = Interop.mkStyle "textDecorationColor" "transparent"