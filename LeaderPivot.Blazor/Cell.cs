using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;


namespace LeaderPivot.Blazor
{
    public abstract class Cell : BaseComponent
    {
        [Parameter] public string DataLabel { get; set; }

        /// <summary>
        /// Hide cell when breakpoint is smaller than the defined value in table.
        /// </summary>
        [Parameter] public bool HideSmall { get; set; }
        [Parameter] public int RowSpan { get; set; } = 1;
        [Parameter] public int ColSpan { get; set; } = 1;
        [Parameter] public string Scope { get; set; }
    }
}
