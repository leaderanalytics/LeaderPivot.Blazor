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

        public IEnumerable<Dimension<T>> RowDimensions 
        { 
            get => Dimensions.Where(x => x.IsRow); 
            set => RenderTable(); 
        }

        public IEnumerable<Dimension<T>> ColumnDimensions 
        { 
            get => Dimensions.Where(x => !x.IsRow); 
            set => RenderTable(); 
        }

        private IEnumerable<Dimension<T>> _Dimensions;
        [Parameter] public IEnumerable<Dimension<T>> Dimensions 
        {
            get => _Dimensions;
            set
            {
                if (_Dimensions != value)
                {
                    _Dimensions = value;
                    RenderTable();
                }
            }
        }
        
        private IEnumerable<Measure<T>> _Measures;
        [Parameter] public IEnumerable<Measure<T>> Measures 
        {
            get => _Measures;
            set
            {
                if (_Measures != value)
                {
                    _Measures = value;
                    RenderTable();
                }
            }
        }
        
        private bool? _DisplayGrandTotals;
        [Parameter] public bool? DisplayGrandTotals
        {
            get => _DisplayGrandTotals;
            set
            {
                if (_DisplayGrandTotals != value)
                {
                    _DisplayGrandTotals = value;
                    RenderTable();
                }
            }
        }

        private Func<PagedQueryArgs, PagedQueryResult<T>> _DataSource;
        [Parameter] public Func<PagedQueryArgs, PagedQueryResult<T>> DataSource 
        {
            get => _DataSource;
            set
            {
                if (_DataSource != value)
                {
                    _DataSource = value;
                    RenderTable();
                }
            }
        }
        

        // -------------------------- Matrix -------------------------------

        public Matrix Matrix { get; set; }
        private MatrixBuilder<T> matrixBuilder;

        protected override async Task OnInitializedAsync()
        {
            NodeBuilder<T> nodeBuilder = new NodeBuilder<T>(NodeCache<T>.Instance);
            Validator<T> validator = new Validator<T>();
            matrixBuilder = new MatrixBuilder<T>(nodeBuilder, validator);
        }

        public void RenderTable()
        {
            if (DataSource == null || Dimensions == null || Measures == null || !DisplayGrandTotals.HasValue || matrixBuilder == null)
                return;

            List<T> Data = DataSource(new PagedQueryArgs()).Data;

            Matrix = matrixBuilder.BuildMatrix(Data, Dimensions, Measures, DisplayGrandTotals.Value);
        }

        public void ToggleNodeExpansion(string nodeID)
        {
            Matrix = matrixBuilder.ToggleNodeExpansion(nodeID);
        }
    }
}
