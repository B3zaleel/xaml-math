﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     GenAPI Version: 7.0.8.6004
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace XamlMath
{
    public partial class CharFont
    {
        public CharFont(char character, int fontId) { }
        public char Character { [System.Runtime.CompilerServices.CompilerGeneratedAttribute] get { throw null; } }
        public int FontId { [System.Runtime.CompilerServices.CompilerGeneratedAttribute] get { throw null; } }
    }
    public partial class CharInfo
    {
        public CharInfo(char character, XamlMath.Fonts.IFontTypeface font, double size, int fontId, XamlMath.TeXFontMetrics metrics) { }
        public char Character { [System.Runtime.CompilerServices.CompilerGeneratedAttribute] get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute] set { } }
        public XamlMath.Fonts.IFontTypeface Font { [System.Runtime.CompilerServices.CompilerGeneratedAttribute] get { throw null; } }
        public int FontId { [System.Runtime.CompilerServices.CompilerGeneratedAttribute] get { throw null; } }
        public XamlMath.TeXFontMetrics Metrics { [System.Runtime.CompilerServices.CompilerGeneratedAttribute] get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute] set { } }
        public double Size { [System.Runtime.CompilerServices.CompilerGeneratedAttribute] get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute] set { } }
        public XamlMath.CharFont GetCharacterFont() { throw null; }
    }
    public partial class DelimiterMappingNotFoundException : System.Exception
    {
        internal DelimiterMappingNotFoundException() { }
    }
    public partial class ExtensionChar
    {
        public ExtensionChar(XamlMath.CharInfo? top, XamlMath.CharInfo? middle, XamlMath.CharInfo? bottom, XamlMath.CharInfo? repeat) { }
        public XamlMath.CharInfo? Bottom { [System.Runtime.CompilerServices.CompilerGeneratedAttribute] get { throw null; } }
        public XamlMath.CharInfo? Middle { [System.Runtime.CompilerServices.CompilerGeneratedAttribute] get { throw null; } }
        public XamlMath.CharInfo? Repeat { [System.Runtime.CompilerServices.CompilerGeneratedAttribute] get { throw null; } }
        public XamlMath.CharInfo? Top { [System.Runtime.CompilerServices.CompilerGeneratedAttribute] get { throw null; } }
    }
    public partial class FormulaNotFoundException : System.Exception
    {
        internal FormulaNotFoundException() { }
    }
    public enum MatrixCellAlignment
    {
        Left = 0,
        Center = 1,
    }
    public partial class SourceSpan : System.IEquatable<XamlMath.SourceSpan>
    {
        public SourceSpan(string sourceName, string source, int start, int length) { }
        public int End { get { throw null; } }
        public char this[int index] { get { throw null; } }
        public int Length { [System.Runtime.CompilerServices.CompilerGeneratedAttribute] get { throw null; } }
        public string Source { [System.Runtime.CompilerServices.CompilerGeneratedAttribute] get { throw null; } }
        public string SourceName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute] get { throw null; } }
        public int Start { [System.Runtime.CompilerServices.CompilerGeneratedAttribute] get { throw null; } }
        public override bool Equals(object? obj) { throw null; }
        public bool Equals(XamlMath.SourceSpan? other) { throw null; }
        public override int GetHashCode() { throw null; }
        public XamlMath.SourceSpan Segment(int start) { throw null; }
        public XamlMath.SourceSpan Segment(int start, int length) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class SymbolMappingNotFoundException : System.Exception
    {
        internal SymbolMappingNotFoundException() { }
    }
    public partial class SymbolNotFoundException : System.Exception
    {
        internal SymbolNotFoundException() { }
    }
    public enum TexAlignment
    {
        Left = 0,
        Right = 1,
        Center = 2,
        Top = 3,
        Bottom = 4,
    }
    public enum TexAtomType
    {
        None = -1,
        Ordinary = 0,
        BigOperator = 1,
        BinaryOperator = 2,
        Relation = 3,
        Opening = 4,
        Closing = 5,
        Punctuation = 6,
        Inner = 7,
        Accent = 10,
    }
    public enum TexDelimeterType
    {
        Over = 0,
        Under = 1,
    }
    public enum TexDelimiter
    {
        Brace = 0,
        Parenthesis = 1,
        Bracket = 2,
        LeftArrow = 3,
        RightArrow = 4,
        LeftRightArrow = 5,
        DoubleLeftArrow = 6,
        DoubleRightArrow = 7,
        DoubleLeftRightArrow = 8,
        SingleLine = 9,
        DoubleLine = 10,
    }
    public sealed partial class TexEnvironment : System.IEquatable<XamlMath.TexEnvironment>
    {
        public TexEnvironment(XamlMath.TexStyle Style, XamlMath.Fonts.ITeXFont MathFont, XamlMath.Fonts.ITeXFont TextFont, XamlMath.Rendering.IBrush? Background = null, XamlMath.Rendering.IBrush? Foreground = null) { }
        public XamlMath.Rendering.IBrush? Background { [System.Runtime.CompilerServices.CompilerGeneratedAttribute] get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute] set { } }
        public XamlMath.Rendering.IBrush? Foreground { [System.Runtime.CompilerServices.CompilerGeneratedAttribute] get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute] set { } }
        public XamlMath.Fonts.ITeXFont MathFont { [System.Runtime.CompilerServices.CompilerGeneratedAttribute] get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute] set { } }
        public XamlMath.TexStyle Style { [System.Runtime.CompilerServices.CompilerGeneratedAttribute] get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute] set { } }
        public XamlMath.Fonts.ITeXFont TextFont { [System.Runtime.CompilerServices.CompilerGeneratedAttribute] get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute] set { } }
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute]
        public void Deconstruct(out XamlMath.TexStyle Style, out XamlMath.Fonts.ITeXFont MathFont, out XamlMath.Fonts.ITeXFont TextFont, out XamlMath.Rendering.IBrush? Background, out XamlMath.Rendering.IBrush? Foreground) { throw null; }
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute]
        public override bool Equals(object? obj) { throw null; }
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute]
        public bool Equals(XamlMath.TexEnvironment? other) { throw null; }
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute]
        public override int GetHashCode() { throw null; }
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute]
        public static bool operator ==(XamlMath.TexEnvironment? left, XamlMath.TexEnvironment? right) { throw null; }
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute]
        public static bool operator !=(XamlMath.TexEnvironment? left, XamlMath.TexEnvironment? right) { throw null; }
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute]
        public override string ToString() { throw null; }
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute]
        public XamlMath.TexEnvironment <Clone>$() { throw null; }
    }
    public partial class TeXFontMetrics
    {
        public TeXFontMetrics(double width, double height, double depth, double italicWidth, double scale) { }
        public double Depth { [System.Runtime.CompilerServices.CompilerGeneratedAttribute] get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute] set { } }
        public double Height { [System.Runtime.CompilerServices.CompilerGeneratedAttribute] get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute] set { } }
        public double Italic { [System.Runtime.CompilerServices.CompilerGeneratedAttribute] get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute] set { } }
        public double Width { [System.Runtime.CompilerServices.CompilerGeneratedAttribute] get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute] set { } }
    }
    public sealed partial class TexFormula
    {
        public TexFormula() { }
        public XamlMath.SourceSpan? Source { [System.Runtime.CompilerServices.CompilerGeneratedAttribute] get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute] set { } }
        public string? TextStyle { [System.Runtime.CompilerServices.CompilerGeneratedAttribute] get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute] set { } }
        public void Add(XamlMath.TexFormula formula, XamlMath.SourceSpan? source = null) { }
        public void SetBackground(XamlMath.Rendering.IBrush brush) { }
        public void SetForeground(XamlMath.Rendering.IBrush brush) { }
    }
    public partial class TexFormulaParser
    {
        public TexFormulaParser(System.Collections.Generic.IReadOnlyDictionary<string, XamlMath.Colors.IColorParser> colorModelParsers, XamlMath.Colors.IColorParser defaultColorParser, XamlMath.Rendering.IBrushFactory brushFactory, System.Collections.Generic.IReadOnlyDictionary<string, System.Func<XamlMath.SourceSpan, XamlMath.TexFormula?>> predefinedFormulae) { }
        public TexFormulaParser(XamlMath.Rendering.IBrushFactory brushFactory, System.Collections.Generic.IReadOnlyDictionary<string, System.Func<XamlMath.SourceSpan, XamlMath.TexFormula?>> predefinedFormulae) { }
        public XamlMath.TexFormula Parse(string value, string? textStyle = null) { throw null; }
        public XamlMath.TexFormula Parse(XamlMath.SourceSpan value, string? textStyle = null) { throw null; }
    }
    public enum TexStyle
    {
        Display = 0,
        Text = 2,
        Script = 4,
        ScriptScript = 6,
    }
    public enum TexUnit
    {
        Em = 0,
        Ex = 1,
        Pixel = 2,
        Point = 3,
        Pica = 4,
        Mu = 5,
    }
}
namespace XamlMath.Boxes
{
    public abstract partial class Box
    {
        protected Box() { }
        protected Box(XamlMath.Rendering.IBrush? foreground, XamlMath.Rendering.IBrush? background) { }
        public XamlMath.Rendering.IBrush? Background { [System.Runtime.CompilerServices.CompilerGeneratedAttribute] get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute] set { } }
        public System.Collections.ObjectModel.ReadOnlyCollection<XamlMath.Boxes.Box> Children { get { throw null; } }
        public double Depth { [System.Runtime.CompilerServices.CompilerGeneratedAttribute] get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute] set { } }
        public XamlMath.Rendering.IBrush? Foreground { [System.Runtime.CompilerServices.CompilerGeneratedAttribute] get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute] set { } }
        public double Height { [System.Runtime.CompilerServices.CompilerGeneratedAttribute] get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute] set { } }
        public double Italic { [System.Runtime.CompilerServices.CompilerGeneratedAttribute] get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute] set { } }
        public double Shift { [System.Runtime.CompilerServices.CompilerGeneratedAttribute] get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute] set { } }
        public XamlMath.SourceSpan? Source { [System.Runtime.CompilerServices.CompilerGeneratedAttribute] get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute] set { } }
        public double TotalHeight { get { throw null; } }
        public double TotalWidth { get { throw null; } }
        public double Width { [System.Runtime.CompilerServices.CompilerGeneratedAttribute] get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute] set { } }
        public virtual void Add(int position, XamlMath.Boxes.Box box) { }
        public virtual void Add(XamlMath.Boxes.Box box) { }
        public abstract int GetLastFontId();
        public abstract void RenderTo(XamlMath.Rendering.IElementRenderer renderer, double x, double y);
    }
}
namespace XamlMath.Colors
{
    public abstract partial class FixedComponentCountColorParser : XamlMath.Colors.IColorParser
    {
        protected FixedComponentCountColorParser(int componentCount) { }
        public XamlMath.Colors.RgbaColor? Parse(System.Collections.Generic.IReadOnlyList<string> components) { throw null; }
        protected abstract XamlMath.Colors.RgbaColor? ParseComponents(System.Collections.Generic.IReadOnlyList<string> components);
    }
    public partial interface IColorParser
    {
        XamlMath.Colors.RgbaColor? Parse(System.Collections.Generic.IReadOnlyList<string> components);
    }
    public partial class PredefinedColorParser : XamlMath.Colors.IColorParser
    {
        internal PredefinedColorParser() { }
        public static readonly XamlMath.Colors.PredefinedColorParser Instance;
        public XamlMath.Colors.RgbaColor? Parse(System.Collections.Generic.IReadOnlyList<string> components) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct RgbaColor : System.IEquatable<XamlMath.Colors.RgbaColor>
    {
        private object _dummy;
        private int _dummyPrimitive;
        public RgbaColor(byte R, byte G, byte B, byte A = (byte)255) { throw null; }
        public byte A { [System.Runtime.CompilerServices.CompilerGeneratedAttribute] get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute] set { } }
        public byte B { [System.Runtime.CompilerServices.CompilerGeneratedAttribute] get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute] set { } }
        public byte G { [System.Runtime.CompilerServices.CompilerGeneratedAttribute] get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute] set { } }
        public byte R { [System.Runtime.CompilerServices.CompilerGeneratedAttribute] get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute] set { } }
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute]
        public void Deconstruct(out byte R, out byte G, out byte B, out byte A) { throw null; }
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute]
        public override bool Equals(object obj) { throw null; }
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute]
        public bool Equals(XamlMath.Colors.RgbaColor other) { throw null; }
        public static XamlMath.Colors.RgbaColor FromArgb(byte a, byte r, byte g, byte b) { throw null; }
        public static XamlMath.Colors.RgbaColor FromRgb(byte r, byte g, byte b) { throw null; }
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute]
        public override int GetHashCode() { throw null; }
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute]
        public static bool operator ==(XamlMath.Colors.RgbaColor left, XamlMath.Colors.RgbaColor right) { throw null; }
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute]
        public static bool operator !=(XamlMath.Colors.RgbaColor left, XamlMath.Colors.RgbaColor right) { throw null; }
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute]
        public override string ToString() { throw null; }
    }
    public static partial class StandardColorParsers
    {
        public static System.Collections.Generic.IReadOnlyDictionary<string, XamlMath.Colors.IColorParser> Dictionary;
    }
}
namespace XamlMath.Exceptions
{
    public partial class TexCharacterMappingNotFoundException : XamlMath.Exceptions.TexException
    {
        public TexCharacterMappingNotFoundException(string message) { }
    }
    public abstract partial class TexException : System.Exception
    {
        public TexException() { }
        public TexException(string message) { }
        public TexException(string message, System.Exception innerException) { }
    }
    public partial class TexNotSupportedException : XamlMath.Exceptions.TexException
    {
        public TexNotSupportedException(string message) { }
    }
    public partial class TexParseException : XamlMath.Exceptions.TexException
    {
        internal TexParseException() { }
    }
    public partial class TextStyleMappingNotFoundException : XamlMath.Exceptions.TexException
    {
        internal TextStyleMappingNotFoundException() { }
    }
    public partial class TypeFaceNotFoundException : XamlMath.Exceptions.TexException
    {
        public TypeFaceNotFoundException(string message) { }
    }
}
namespace XamlMath.Fonts
{
    public partial interface IFontProvider
    {
        XamlMath.Fonts.IFontTypeface ReadFontFile(string fontFileName);
    }
    public partial interface IFontTypeface
    {
    }
    public partial interface ITeXFont
    {
        double Size { get; }
        bool SupportsMetrics { get; }
        double GetAxisHeight(XamlMath.TexStyle style);
        double GetBigOpSpacing1(XamlMath.TexStyle style);
        double GetBigOpSpacing2(XamlMath.TexStyle style);
        double GetBigOpSpacing3(XamlMath.TexStyle style);
        double GetBigOpSpacing4(XamlMath.TexStyle style);
        double GetBigOpSpacing5(XamlMath.TexStyle style);
        XamlMath.Utils.Result<XamlMath.CharInfo> GetCharInfo(char character, string textStyle, XamlMath.TexStyle style);
        XamlMath.Utils.Result<XamlMath.CharInfo> GetCharInfo(string name, XamlMath.TexStyle style);
        XamlMath.Utils.Result<XamlMath.CharInfo> GetCharInfo(XamlMath.CharFont charFont, XamlMath.TexStyle style);
        XamlMath.Utils.Result<XamlMath.CharInfo> GetDefaultCharInfo(char character, XamlMath.TexStyle style);
        double GetDefaultLineThickness(XamlMath.TexStyle style);
        double GetDenom1(XamlMath.TexStyle style);
        double GetDenom2(XamlMath.TexStyle style);
        XamlMath.ExtensionChar GetExtension(XamlMath.CharInfo charInfo, XamlMath.TexStyle style);
        double GetKern(XamlMath.CharFont leftChar, XamlMath.CharFont rightChar, XamlMath.TexStyle style);
        XamlMath.CharFont? GetLigature(XamlMath.CharFont leftChar, XamlMath.CharFont rightChar);
        int GetMuFontId();
        XamlMath.CharInfo GetNextLargerCharInfo(XamlMath.CharInfo charInfo, XamlMath.TexStyle style);
        double GetNum1(XamlMath.TexStyle style);
        double GetNum2(XamlMath.TexStyle style);
        double GetNum3(XamlMath.TexStyle style);
        double GetQuad(int fontId, XamlMath.TexStyle style);
        double GetSkew(XamlMath.CharFont charFont, XamlMath.TexStyle style);
        double GetSpace(XamlMath.TexStyle style);
        double GetSub1(XamlMath.TexStyle style);
        double GetSub2(XamlMath.TexStyle style);
        double GetSubDrop(XamlMath.TexStyle style);
        double GetSup1(XamlMath.TexStyle style);
        double GetSup2(XamlMath.TexStyle style);
        double GetSup3(XamlMath.TexStyle style);
        double GetSupDrop(XamlMath.TexStyle style);
        double GetXHeight(XamlMath.TexStyle style, int fontId);
        bool HasNextLarger(XamlMath.CharInfo charInfo);
        bool HasSpace(int fontId);
        bool IsExtensionChar(XamlMath.CharInfo charInfo);
    }
}
namespace XamlMath.Rendering
{
    public partial class GenericBrush<TBrush> : System.IEquatable<XamlMath.Rendering.GenericBrush<TBrush>>, XamlMath.Rendering.IBrush
    {
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute]
        protected GenericBrush(XamlMath.Rendering.GenericBrush<TBrush> original) { }
        public GenericBrush(TBrush Value) { }
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute]
        protected virtual System.Type EqualityContract { [System.Runtime.CompilerServices.CompilerGeneratedAttribute] get { throw null; } }
        public TBrush Value { [System.Runtime.CompilerServices.CompilerGeneratedAttribute] get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute] set { } }
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute]
        public void Deconstruct(out TBrush Value) { throw null; }
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute]
        public override bool Equals(object? obj) { throw null; }
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute]
        public virtual bool Equals(XamlMath.Rendering.GenericBrush<TBrush>? other) { throw null; }
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute]
        public override int GetHashCode() { throw null; }
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute]
        public static bool operator ==(XamlMath.Rendering.GenericBrush<TBrush>? left, XamlMath.Rendering.GenericBrush<TBrush>? right) { throw null; }
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute]
        public static bool operator !=(XamlMath.Rendering.GenericBrush<TBrush>? left, XamlMath.Rendering.GenericBrush<TBrush>? right) { throw null; }
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute]
        protected virtual bool PrintMembers(System.Text.StringBuilder builder) { throw null; }
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute]
        public override string ToString() { throw null; }
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute]
        public virtual XamlMath.Rendering.GenericBrush<TBrush> <Clone>$() { throw null; }
    }
    public partial interface IBrush
    {
    }
    public partial interface IBrushFactory
    {
        XamlMath.Rendering.IBrush FromColor(XamlMath.Colors.RgbaColor color);
    }
    public partial interface IElementRenderer
    {
        void FinishRendering();
        void RenderCharacter(XamlMath.CharInfo info, double x, double y, XamlMath.Rendering.IBrush? foreground);
        void RenderElement(XamlMath.Boxes.Box box, double x, double y);
        void RenderRectangle(XamlMath.Rendering.Rectangle rectangle, XamlMath.Rendering.IBrush? foreground);
        void RenderTransformed(XamlMath.Boxes.Box box, System.Collections.Generic.IEnumerable<XamlMath.Rendering.Transformations.Transformation> transforms, double x, double y);
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct Point : System.IEquatable<XamlMath.Rendering.Point>
    {
        private object _dummy;
        private int _dummyPrimitive;
        public Point(double X, double Y) { throw null; }
        public double X { [System.Runtime.CompilerServices.CompilerGeneratedAttribute] get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute] set { } }
        public double Y { [System.Runtime.CompilerServices.CompilerGeneratedAttribute] get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute] set { } }
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute]
        public void Deconstruct(out double X, out double Y) { throw null; }
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute]
        public override bool Equals(object obj) { throw null; }
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute]
        public bool Equals(XamlMath.Rendering.Point other) { throw null; }
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute]
        public override int GetHashCode() { throw null; }
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute]
        public static bool operator ==(XamlMath.Rendering.Point left, XamlMath.Rendering.Point right) { throw null; }
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute]
        public static bool operator !=(XamlMath.Rendering.Point left, XamlMath.Rendering.Point right) { throw null; }
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute]
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct Rectangle : System.IEquatable<XamlMath.Rendering.Rectangle>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public Rectangle(double x, double y, double width, double height) { throw null; }
        public Rectangle(XamlMath.Rendering.Point TopLeft, XamlMath.Rendering.Size Size) { throw null; }
        public double Height { get { throw null; } }
        public XamlMath.Rendering.Size Size { [System.Runtime.CompilerServices.CompilerGeneratedAttribute] get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute] set { } }
        public XamlMath.Rendering.Point TopLeft { [System.Runtime.CompilerServices.CompilerGeneratedAttribute] get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute] set { } }
        public double Width { get { throw null; } }
        public double X { get { throw null; } }
        public double Y { get { throw null; } }
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute]
        public void Deconstruct(out XamlMath.Rendering.Point TopLeft, out XamlMath.Rendering.Size Size) { throw null; }
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute]
        public override bool Equals(object obj) { throw null; }
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute]
        public bool Equals(XamlMath.Rendering.Rectangle other) { throw null; }
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute]
        public override int GetHashCode() { throw null; }
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute]
        public static bool operator ==(XamlMath.Rendering.Rectangle left, XamlMath.Rendering.Rectangle right) { throw null; }
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute]
        public static bool operator !=(XamlMath.Rendering.Rectangle left, XamlMath.Rendering.Rectangle right) { throw null; }
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute]
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct Size : System.IEquatable<XamlMath.Rendering.Size>
    {
        private object _dummy;
        private int _dummyPrimitive;
        public Size(double Width, double Height) { throw null; }
        public double Height { [System.Runtime.CompilerServices.CompilerGeneratedAttribute] get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute] set { } }
        public double Width { [System.Runtime.CompilerServices.CompilerGeneratedAttribute] get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute] set { } }
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute]
        public void Deconstruct(out double Width, out double Height) { throw null; }
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute]
        public override bool Equals(object obj) { throw null; }
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute]
        public bool Equals(XamlMath.Rendering.Size other) { throw null; }
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute]
        public override int GetHashCode() { throw null; }
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute]
        public static bool operator ==(XamlMath.Rendering.Size left, XamlMath.Rendering.Size right) { throw null; }
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute]
        public static bool operator !=(XamlMath.Rendering.Size left, XamlMath.Rendering.Size right) { throw null; }
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute]
        public override string ToString() { throw null; }
    }
    public static partial class TeXFormulaExtensions
    {
        public static void RenderTo(this XamlMath.TexFormula formula, XamlMath.Rendering.IElementRenderer renderer, XamlMath.TexEnvironment environment, double x, double y) { }
    }
}
namespace XamlMath.Rendering.Transformations
{
    public abstract partial class Transformation
    {
        internal Transformation() { }
        public abstract XamlMath.Rendering.Transformations.TransformationKind Kind { get; }
        public abstract XamlMath.Rendering.Transformations.Transformation Scale(double scale);
        public partial class Rotate : XamlMath.Rendering.Transformations.Transformation
        {
            public Rotate(double rotationDegrees) { }
            public override XamlMath.Rendering.Transformations.TransformationKind Kind { get { throw null; } }
            public double RotationDegrees { [System.Runtime.CompilerServices.CompilerGeneratedAttribute] get { throw null; } }
            public override XamlMath.Rendering.Transformations.Transformation Scale(double scale) { throw null; }
        }
        public partial class Translate : XamlMath.Rendering.Transformations.Transformation
        {
            public Translate(double x, double y) { }
            public override XamlMath.Rendering.Transformations.TransformationKind Kind { get { throw null; } }
            public double X { [System.Runtime.CompilerServices.CompilerGeneratedAttribute] get { throw null; } }
            public double Y { [System.Runtime.CompilerServices.CompilerGeneratedAttribute] get { throw null; } }
            public override XamlMath.Rendering.Transformations.Transformation Scale(double scale) { throw null; }
        }
    }
    public enum TransformationKind
    {
        Translate = 0,
        Rotate = 1,
    }
}
namespace XamlMath.Utils
{
    public static partial class Result
    {
        public static XamlMath.Utils.Result<TValue> Error<TValue>(System.Exception error) { throw null; }
        public static XamlMath.Utils.Result<TValue> Ok<TValue>(TValue value) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct Result<TValue>
    {
        private readonly TValue value;
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public Result(TValue value, System.Exception? error) { throw null; }
        public System.Exception? Error { [System.Runtime.CompilerServices.CompilerGeneratedAttribute] get { throw null; } }
        public bool IsSuccess { get { throw null; } }
        public TValue Value { get { throw null; } }
        public XamlMath.Utils.Result<TProduct> Map<TProduct>(System.Func<TValue, TProduct> mapper) { throw null; }
    }
}