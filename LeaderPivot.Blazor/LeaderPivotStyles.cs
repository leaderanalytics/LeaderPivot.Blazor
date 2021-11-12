using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaderAnalytics.LeaderPivot.Blazor
{
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
                Container = "leader-pivot-container leader-pivot-container-light",
                Table = "table table-light table-bordered",
                MeasureCell = "leader-pivot-measure-cell",
                TotalCell = "leader-pivot-measure-cell leader-pivot-total-cell-bg-light",
                GrandTotalCell = "leader-pivot-measure-cell leader-pivot-total-cell-bg-light",
                GroupHeaderCell = "leader-pivot-header-cell",
                TotalHeaderCell = "leader-pivot-header-cell leader-pivot-total-cell-bg-light",
                GrandTotalHeaderCell = "leader-pivot-header-cell leader-pivot-total-cell-bg-light",
                MeasureHeaderCell = "leader-pivot-header-cell",
                DimensionButton = "btn btn-outline-secondary btn-sm shadow",
                ReloadButton = "btn btn-outline-secondary btn-sm shadow",
                GroupHeaderButton = "btn btn-sm rounded-circle groupheader-button groupheader-button-black",
                CheckBoxLabel = "form-check-label",
                CheckBox = "slider round slider-light"
            };
            Styles.Add(light);


            LeaderPivotStyle secondary = new LeaderPivotStyle
            {
                StyleName = "Secondary",
                Container = "leader-pivot-container leader-pivot-container-secondary",
                Table = "table table-bordered-secondary",
                MeasureCell = "leader-pivot-measure-cell",
                TotalCell = "leader-pivot-measure-cell leader-pivot-total-cell-bg-secondary",
                GrandTotalCell = "leader-pivot-measure-cell leader-pivot-total-cell-bg-secondary",
                GroupHeaderCell = "leader-pivot-header-cell",
                TotalHeaderCell = "leader-pivot-header-cell leader-pivot-total-cell-bg-secondary",
                GrandTotalHeaderCell = "leader-pivot-header-cell leader-pivot-total-cell-bg-secondary",
                MeasureHeaderCell = "leader-pivot-header-cell",
                DimensionButton = "btn btn-secondary btn-sm shadow",
                ReloadButton = "btn btn-secondary btn-sm shadow",
                GroupHeaderButton = "btn btn-sm rounded-circle groupheader-button groupheader-button-black",
                CheckBoxLabel = "form-check-label",
                CheckBox = "slider round slider-secondary"
            };
            Styles.Add(secondary);


            LeaderPivotStyle dark = new LeaderPivotStyle
            {
                StyleName = "Dark",
                Container = "leader-pivot-container leader-pivot-container-dark",
                Table = "table table-bordered-dark",
                MeasureCell = "leader-pivot-measure-cell",
                TotalCell = "leader-pivot-measure-cell leader-pivot-total-cell-bg-dark",
                GrandTotalCell = "leader-pivot-measure-cell leader-pivot-total-cell-bg-dark",
                GroupHeaderCell = "leader-pivot-header-cell",
                TotalHeaderCell = "leader-pivot-header-cell leader-pivot-total-cell-bg-dark",
                GrandTotalHeaderCell = "leader-pivot-header-cell leader-pivot-total-cell-bg-dark",
                MeasureHeaderCell = "leader-pivot-header-cell",
                DimensionButton = "btn btn-dark btn-sm shadow",
                ReloadButton = "btn btn-dark btn-sm shadow",
                GroupHeaderButton = "btn btn-sm rounded-circle groupheader-button groupheader-button-white",
                CheckBoxLabel = "form-check-label",
                CheckBox = "slider round slider-secondary"
            };
            Styles.Add(dark);
        }
    }
}
