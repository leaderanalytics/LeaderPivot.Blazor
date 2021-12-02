namespace LeaderAnalytics.LeaderPivot.Blazor;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddLeaderPivot(this IServiceCollection services)
    {
        return Plk.Blazor.DragDrop.ServiceCollectionExtensions.AddBlazorDragDrop(services);
    }
}
