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
        [Parameter] public Func<PagedQueryArgs, PagedQueryResult<T>> DataSource { get; set; }

        public List<Dimension<T>> RowDimensions 
        {
            get => Dimensions.Where(x => x.IsRow).OrderBy(x => x.Sequence).ToList(); 
            set => _ = value; 
        }

        public List<Dimension<T>> ColumnDimensions 
        { 
            get => Dimensions.Where(x => !x.IsRow).OrderBy(x => x.Sequence).ToList(); 
            set => _ = value; 
        }

        public int MaxDimensionsPerAxis => Dimensions.Count == 2 ? 2 : Dimensions.Count - 1;

        public Matrix Matrix { get; set; }
        private MatrixBuilder<T> matrixBuilder;
        private List<T> Data;

        public LeaderPivot()
        {
            NodeBuilder<T> nodeBuilder = new NodeBuilder<T>();
            Validator<T> validator = new Validator<T>();
            matrixBuilder = new MatrixBuilder<T>(nodeBuilder, validator);
        }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            await base.OnAfterRenderAsync(firstRender);

            if (firstRender)
            {
                if (PivotStyle == null)
                    PivotStyle = new LeaderPivotStyle();
                
                await ReloadData();
            }
        }

        public async Task ReloadData()
        {
            Data = DataSource(new PagedQueryArgs()).Data;
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
            foreach (Dimension<T> dim in args.Item1)
            {
                Dimension<T> target = Dimensions.First(x => x.ID == dim.ID);
                target.Sequence = dim.Sequence;
                target.IsRow = dim.IsRow;
            }
            
            RenderTable();
        }
    }
}
