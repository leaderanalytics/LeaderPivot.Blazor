using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using LeaderAnalytics.LeaderPivot;

namespace LeaderPivot.Blazor
{
    public partial class LeaderPivot<T> : BaseComponent
    {
        [Parameter] public IList<Dimension<T>> Dimensions { get; set; }
        [Parameter] public IEnumerable<Measure<T>> Measures { get; set; }
        [Parameter] public bool DisplayGrandTotals { get; set; }
        [Parameter] public bool DisplayGrandTotalOption { get; set; }
        [Parameter] public bool DisplayDimensionButtons { get; set; }
        [Parameter] public bool DisplayMeasureSelectors { get; set; }
        [Parameter] public bool DisplayReloadDataButton { get; set; }
        [Parameter] public Func<Task<IEnumerable<T>>> DataSource { get; set; }

        public List<Dimension<T>> RowDimensions 
        {
            get => Dimensions.Where(x => x.IsEnabled && x.IsRow).OrderBy(x => x.Sequence).ToList(); 
            set => _ = value; 
        }

        public List<Dimension<T>> ColumnDimensions 
        { 
            get => Dimensions.Where(x => x.IsEnabled && !x.IsRow).OrderBy(x => x.Sequence).ToList(); 
            set => _ = value; 
        }

        public int MaxDimensionsPerAxis => Dimensions.Count == 2 ? 2 : Dimensions.Count - 1;

        public Matrix Matrix { get; set; }
        private MatrixBuilder<T> matrixBuilder;
        private IEnumerable<T> Data;

        public LeaderPivot()
        {
            NodeBuilder<T> nodeBuilder = new NodeBuilder<T>();
            Validator<T> validator = new Validator<T>();
            matrixBuilder = new MatrixBuilder<T>(nodeBuilder, validator);
        }

        protected override async Task OnInitializedAsync()
        {
            if (PivotStyle == null)
                PivotStyle = new LeaderPivotStyle();

            await ReloadData();
            await base.OnInitializedAsync();
        }

        public async Task ReloadData()
        {
            Data = await DataSource();
            RenderTable();
        }

        public void RenderTable()
        {
            Matrix = matrixBuilder.BuildMatrix(Data, Dimensions, Measures, DisplayGrandTotals);
        }

        public void ToggleNodeExpansion(string nodeID)
        {
            Matrix = matrixBuilder.ToggleNodeExpansion(nodeID);
        }

        public void MeasureCheckedChanged(Measure<T> measure, ChangeEventArgs e)
        {
            bool option = (bool)e.Value;

            if (!(!option && Measures.Count(x => x.IsEnabled) == 1))
            {
                measure.IsEnabled = option;
            }
            RenderTable();
        }

        public void GrandTotalsCheckedChanged()
        {
            DisplayGrandTotals = !DisplayGrandTotals;
            RenderTable();
        }

        public void DimensionsChanged(Tuple<List<Dimension<T>>, bool> args)
        {
            List<Dimension<T>> enabledDimensions = Dimensions.Where(x => x.IsEnabled).ToList();
            int sequence = 0;
            string draggedDim = null; 

            foreach (Dimension<T> dim in args.Item1)
            {
                if (dim.IsRow != args.Item2)
                    draggedDim = dim.ID; // this dimension was dragged across axis

                dim.Sequence = sequence++;
                dim.IsRow = args.Item2;
            }

            // if we have exactly two enabled dimensions, find the other dimension and make
            // sure it's axis is different than the dimension that was dragged.

            if (enabledDimensions.Count == 2 && ! string.IsNullOrEmpty(draggedDim))
            {
                Dimension<T> other = enabledDimensions.First(x => x.ID != draggedDim);
                other.IsRow = ! args.Item2;
            }
            RenderTable();
        }
    }
}
