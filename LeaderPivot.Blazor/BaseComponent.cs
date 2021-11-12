using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace LeaderAnalytics.LeaderPivot.Blazor
{
    public abstract class BaseComponent : ComponentBase
    {
        [Parameter] public LeaderPivotStyle PivotStyle { get; set; }
        [Parameter] public string Style { get; set; }
        [Parameter] public string ClassName { get; set; }
        [Parameter] public IEnumerable<KeyValuePair<string,object>> UserAttributes { get; set; }
        [Parameter] public RenderFragment ChildContent { get; set; }
    }
}
