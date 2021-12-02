namespace LeaderAnalytics.LeaderPivot.Blazor;

public class LeaderPivotStyle
{
    private string _StyleName;
    private string _Container;
    private string _Table;
    private string _MeasureCell;
    private string _TotalCell;
    private string _GrandTotalCell;
    private string _GroupHeaderCell;
    private string _TotalHeaderCell;
    private string _GrandTotalHeaderCell;
    private string _MeasureHeaderCell;
    private string _DimensionButton;
    private string _ReloadButton;
    private string _GroupHeaderButton;
    private string _CheckBoxLabel;
    private string _CheckBox;
    private bool _UseResponsiveSizing;
    private string _CellPadding;
    private string _FontSize;
    private string _CellStyle;
    private string _TableStyle;

    public string StyleName
    {
        get => !string.IsNullOrEmpty(_StyleName) ? _StyleName : "Primary";
        set => _StyleName = value;
    }
    public string Container
    {
        get => !string.IsNullOrEmpty(_Container) ? _Container : "leader-pivot-container-primary";
        set => _Container = value;
    }
    public string Table
    {
        get => !string.IsNullOrEmpty(_Table) ? _Table : "leader-pivot-table";
        set => _Table = value;
    }
    public string MeasureCell
    {
        get => !string.IsNullOrEmpty(_MeasureCell) ? _MeasureCell : "leader-pivot-measure-cell";
        set => _MeasureCell = value;
    }
    public string TotalCell
    {
        get => !string.IsNullOrEmpty(_TotalCell) ? _TotalCell : "leader-pivot-measure-cell leader-pivot-total-cell-bg-default";
        set => _TotalCell = value;
    }
    public string GrandTotalCell
    {
        get => !string.IsNullOrEmpty(_GrandTotalCell) ? _GrandTotalCell : "leader-pivot-measure-cell leader-pivot-total-cell-bg-default";
        set => _GrandTotalCell = value;
    }
    public string GroupHeaderCell
    {
        get => !string.IsNullOrEmpty(_GroupHeaderCell) ? _GroupHeaderCell : "leader-pivot-header-cell";
        set => _GroupHeaderCell = value;
    }
    public string TotalHeaderCell
    {
        get => !string.IsNullOrEmpty(_TotalHeaderCell) ? _TotalHeaderCell : "leader-pivot-header-cell leader-pivot-total-cell-bg-default";
        set => _TotalHeaderCell = value;
    }
    public string GrandTotalHeaderCell
    {
        get => !string.IsNullOrEmpty(_GrandTotalHeaderCell) ? _GrandTotalHeaderCell : "leader-pivot-header-cell leader-pivot-total-cell-bg-default";
        set => _GrandTotalHeaderCell = value;
    }
    public string MeasureHeaderCell
    {
        get => !string.IsNullOrEmpty(_MeasureHeaderCell) ? _MeasureHeaderCell : "leader-pivot-header-cell";
        set => _MeasureHeaderCell = value;
    }
    public string DimensionButton
    {
        get => !string.IsNullOrEmpty(_DimensionButton) ? _DimensionButton : "leader-pivot-btn leader-pivot-btn-primary leader-pivot-btn-sm leader-pivot-shadow";
        set => _DimensionButton = value;
    }
    public string ReloadButton
    {
        get => !string.IsNullOrEmpty(_ReloadButton) ? _ReloadButton : "leader-pivot-btn leader-pivot-btn-primary leader-pivot-btn-sm leader-pivot-shadow";
        set => _ReloadButton = value;
    }

    public string GroupHeaderButton
    {
        get => !string.IsNullOrEmpty(_GroupHeaderButton) ? _GroupHeaderButton : "leader-pivot-btn leader-pivot-btn-sm leader-pivot-rounded-circle groupheader-button groupheader-button-black";
        set => _GroupHeaderButton = value;
    }

    public string CheckBoxLabel
    {
        get => !string.IsNullOrEmpty(_CheckBoxLabel) ? _CheckBoxLabel : "form-check-label";
        set => _CheckBoxLabel = value;
    }
    public string CheckBox
    {
        get => !string.IsNullOrEmpty(_CheckBox) ? _CheckBox : "slider round slider-default";
        set => _CheckBox = value;
    }

    public bool UseResponsiveSizing
    {
        get => _UseResponsiveSizing;
        set => _UseResponsiveSizing = value;
    }

    public string CellPadding
    {
        get => !string.IsNullOrEmpty(_CellPadding) ? _CellPadding : "6";
        set => _CellPadding = value;
    }

    public string FontSize
    {
        get => !string.IsNullOrEmpty(_FontSize) ? _FontSize : "11";
        set => _FontSize = value;
    }

    public string CellStyle
    {
        get => !string.IsNullOrEmpty(_CellStyle) ? _CellStyle : $"padding:{CellPadding}{(UseResponsiveSizing ? "vw" : "px")};";
        set => _CellStyle = value;
    }

    public string TableStyle
    {
        get => !string.IsNullOrEmpty(_TableStyle) ? _TableStyle : $"font-size:{(UseResponsiveSizing ? ("calc(5pt + " + FontSize + "vw)") : (FontSize + "pt"))};";
        set => _TableStyle = value;
    }
}
