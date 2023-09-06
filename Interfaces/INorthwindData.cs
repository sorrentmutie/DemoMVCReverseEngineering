namespace DemoMVCReverseEngineering.Interfaces;

public interface INorthwindData
{
    Task<IndexHomeViewModel> GetHomeIndexViewModelAsync();  
}
