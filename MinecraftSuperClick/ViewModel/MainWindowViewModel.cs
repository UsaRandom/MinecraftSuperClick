using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Windows.Input;

namespace MinecraftSuperClick.ViewModel
{

public class MainWindowViewModel : ViewModelBase
{

    /// <summary>
    /// Constructor for the Main Window View Model... For those who didn't know =p
    /// </summary>
    public MainWindowViewModel()
    {
        m_rightClickContent = "Enable Super \n Right Click";
        m_leftClickContent = "Enable Super \n Left Click";

        RaisePropertyChanged("RightClickContent");
        RaisePropertyChanged("LeftClickContent");
    }


    /// <summary>
    /// The Content of the Left Click Button.
    /// </summary>
    public string LeftClickContent
    {
        get
        {
            return m_leftClickContent;
        }
    }

    /// <summary>
    /// The Content of the Right Click Button.
    /// </summary>
    public string RightClickContent
    {
        get
        {
            return m_rightClickContent;
        }
    }


    /// <summary>
    /// The Command to toggle Super Right Click.
    /// </summary>
    public ICommand RightClickCommand
    {
        get
        {
            if(m_rightClickCommand == null)
            {
                m_rightClickCommand = new RelayCommand(() =>
                {
                    //Toggle Super Right Click
                });
            }

            return m_rightClickCommand;
        }
    }



    /// <summary>
    /// The Command to toggle Super Left Click.
    /// </summary>
    public ICommand LeftClickCommand
    {
        get
        {
            if (m_leftClickCommand == null)
            {
                m_leftClickCommand = new RelayCommand(() =>
                {
                    //Toggle Super Left Click
                });
            }

            return m_leftClickCommand;
        }
    }



    private string m_rightClickContent;
    private string m_leftClickContent;


    private RelayCommand m_rightClickCommand = null;
    private RelayCommand m_leftClickCommand = null;

}
}