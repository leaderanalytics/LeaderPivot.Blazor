using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeaderAnalytics.LeaderPivot.Blazor
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddLeaderPivot(this IServiceCollection services)
        {
            return Plk.Blazor.DragDrop.ServiceCollectionExtensions.AddBlazorDragDrop(services);
        }
    }
}
