namespace BlazorWasmBarebone.Pages;

public partial class Index
{
    private long _elapsed;

    protected override void OnAfterRender(bool firstRender)
    {
        if (firstRender)
        {
            _elapsed = TimeStateContainer.Stop();
            StateHasChanged();
        }
    } 
}