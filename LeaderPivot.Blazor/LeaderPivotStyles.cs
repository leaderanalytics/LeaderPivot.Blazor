namespace LeaderAnalytics.LeaderPivot.Blazor;

public static class LeaderPivotStyles
{
    public static List<LeaderPivotStyle> Styles { get; private set; }

    static LeaderPivotStyles()
    {
        Styles = new List<LeaderPivotStyle>();
        CreateStyles();
    }

    private static void CreateStyles()
    {
        Styles.Add(new LeaderPivotStyle()); // Default

        LeaderPivotStyle light = new LeaderPivotStyle
        {
            StyleName = "Light",
            Container = "leader-pivot-container-light",
            Table = "leader-pivot-table-light leader-pivot-table",
            MeasureCell = "leader-pivot-measure-cell",
            TotalCell = "leader-pivot-measure-cell leader-pivot-total-cell-bg-light",
            GrandTotalCell = "leader-pivot-measure-cell leader-pivot-total-cell-bg-light",
            GroupHeaderCell = "leader-pivot-header-cell",
            TotalHeaderCell = "leader-pivot-header-cell leader-pivot-total-cell-bg-light",
            GrandTotalHeaderCell = "leader-pivot-header-cell leader-pivot-total-cell-bg-light",
            MeasureHeaderCell = "leader-pivot-header-cell",
            DimensionButton = "leader-pivot-btn leader-pivot-btn-outline-light leader-pivot-btn-sm leader-pivot-shadow",
            ReloadButton = "leader-pivot-btn leader-pivot-btn-outline-light leader-pivot-btn-sm leader-pivot-shadow",
            GroupHeaderButton = "leader-pivot-btn leader-pivot-btn-sm leader-pivot-rounded-circle groupheader-button groupheader-button-black",
            CheckBoxLabel = "leader-pivot-form-check-label",
            CheckBox = "slider round slider-light"
        };
        Styles.Add(light);


        LeaderPivotStyle secondary = new LeaderPivotStyle
        {
            StyleName = "Secondary",
            Container = "leader-pivot-container-secondary",
            Table = "leader-pivot-table-bordered-secondary leader-pivot-table",
            MeasureCell = "leader-pivot-measure-cell",
            TotalCell = "leader-pivot-measure-cell leader-pivot-total-cell-bg-secondary",
            GrandTotalCell = "leader-pivot-measure-cell leader-pivot-total-cell-bg-secondary",
            GroupHeaderCell = "leader-pivot-header-cell",
            TotalHeaderCell = "leader-pivot-header-cell leader-pivot-total-cell-bg-secondary",
            GrandTotalHeaderCell = "leader-pivot-header-cell leader-pivot-total-cell-bg-secondary",
            MeasureHeaderCell = "leader-pivot-header-cell",
            DimensionButton = "leader-pivot-btn leader-pivot-btn-secondary leader-pivot-btn-sm leader-pivot-shadow",
            ReloadButton = "leader-pivot-btn leader-pivot-btn-secondary leader-pivot-btn-sm leader-pivot-shadow",
            GroupHeaderButton = "leader-pivot-btn leader-pivot-btn-sm leader-pivot-rounded-circle groupheader-button groupheader-button-black",
            CheckBoxLabel = "leader-pivot-form-check-label",
            CheckBox = "slider round slider-secondary"
        };
        Styles.Add(secondary);


        LeaderPivotStyle dark = new LeaderPivotStyle
        {
            StyleName = "Dark",
            Container = "leader-pivot-container-dark",
            Table = "leader-pivot-table-bordered-dark leader-pivot-table",
            MeasureCell = "leader-pivot-measure-cell",
            TotalCell = "leader-pivot-measure-cell leader-pivot-total-cell-bg-dark",
            GrandTotalCell = "leader-pivot-measure-cell leader-pivot-total-cell-bg-dark",
            GroupHeaderCell = "leader-pivot-header-cell",
            TotalHeaderCell = "leader-pivot-header-cell leader-pivot-total-cell-bg-dark",
            GrandTotalHeaderCell = "leader-pivot-header-cell leader-pivot-total-cell-bg-dark",
            MeasureHeaderCell = "leader-pivot-header-cell",
            DimensionButton = "leader-pivot-btn leader-pivot-btn-dark leader-pivot-btn-sm leader-pivot-shadow-dark",
            ReloadButton = "leader-pivot-btn leader-pivot-btn-dark leader-pivot-btn-sm leader-pivot-shadow-dark",
            GroupHeaderButton = "leader-pivot-btn leader-pivot-btn-sm leader-pivot-rounded-circle groupheader-button groupheader-button-white",
            CheckBoxLabel = "leader-pivot-form-check-label",
            CheckBox = "slider round slider-secondary"
        };
        Styles.Add(dark);
    }
}
