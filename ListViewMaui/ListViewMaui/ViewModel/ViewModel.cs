using System.Collections.ObjectModel;

namespace ListViewMaui
{
public class ViewModel
{
    #region Fields

    private ObservableCollection<CategoryInfo> categoryList;

    #endregion

    #region Constructor

    public ViewModel()
    {
        GenerateSource();
    }

    #endregion

    #region Properties

    public ObservableCollection<CategoryInfo> CategoryList
    {
        get { return categoryList; }
        set { this.categoryList = value; }
    }

    #endregion

    #region Generate Source

    private void GenerateSource()
    {
        CategoryInfoRepository categoryinfo = new CategoryInfoRepository();
        categoryList = categoryinfo.GetCategoryInfo();
    }
    #endregion
}
}
