using System.ComponentModel;

namespace ListViewMaui
{
    public class CategoryInfo : INotifyPropertyChanged
    {
        #region Fields

        private string name;
        private string desc;
        private ImageSource image;

        #endregion

        #region Constructor

        public CategoryInfo()
        {

        }

        #endregion

        #region Properties

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                OnPropertyChanged("Name");
            }
        }

        public string Description
        {
            get { return desc; }
            set
            {
                desc = value;
                OnPropertyChanged("Description");
            }
        }

        public ImageSource Image
        {
            get
            {
                return image;
            }

            set
            {
                image = value;
                OnPropertyChanged("Image");
            }
        }

        #endregion

        #region Interface Member

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string name)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(name));
        }

        #endregion
    }
}
