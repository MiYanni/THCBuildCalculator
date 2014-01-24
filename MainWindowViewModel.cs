using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Composition;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows;
using System.Xml.Serialization;
using Cinch;
using MEFedMVVM.ViewModelLocator;

namespace THCBuildCalculator
{
    [ExportViewModel("MainWindowViewModel")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    internal class MainWindowViewModel : ViewModelBase
    {
        public const string UiServiceKey = "MainWindowView";

        #region Property LoginMessage

        private string _loginMessage;
        private static readonly PropertyChangedEventArgs LoginMessageEventArgs = ObservableHelper.CreateArgs<MainWindowViewModel>(x => x.LoginMessage);

        public string LoginMessage
        {
            get { return _loginMessage; }
            set
            {
                if (_loginMessage == value) return;
                _loginMessage = value;
                NotifyPropertyChanged(LoginMessageEventArgs);
            }
        }

        #endregion Property LoginMessage

        #region Property EnableControls

        private bool _enableControls = true;
        private static readonly PropertyChangedEventArgs EnableFieldsEventArgs = ObservableHelper.CreateArgs<MainWindowViewModel>(x => x.EnableControls);

        public bool EnableControls
        {
            get { return _enableControls; }
            set
            {
                if (_enableControls == value) return;
                _enableControls = value;
                NotifyPropertyChanged(EnableFieldsEventArgs);
            }
        }

        #endregion Property EnableControls

        public string Username { get; set; }

        public string Password { get; set; }

        public event EventHandler LoggedIn;

        public SimpleCommand<object, EventToCommandArgs> LoginCommand { get; private set; }

        public SimpleCommand<object, EventToCommandArgs> MouseLeftButtonDownCommand { get; private set; }

        //public ConnectionManagerViewModel Server { get; private set; }

        private const string SettingsFilePath = "THCSettings.xml";

        //private readonly ManualResetEvent _serverConnect;

        //[ImportingConstructor]
        //public MainWindowViewModel(IUIVisualizerService uiVisualizerService)
        //    : base(uiVisualizerService, UiServiceKey)
        //{
        [ImportingConstructor]
        public MainWindowViewModel()
        {
            //_serverConnect = new ManualResetEvent(false);
            //var connectionSettings = File.Exists(SettingsFilePath) ? ReadConnectionSettings() : new ConnectionSettings { HostDesignation = "127.0.0.1", IpPort = 2001, IsAutoConnectEnabled = true };
            //Server = new ConnectionManagerViewModel(connectionSettings);
            //Server.Connected += (s, e) => _serverConnect.Set();

            LoginCommand = new SimpleCommand<object, EventToCommandArgs>(e => PerformLoginCommand());
            MouseLeftButtonDownCommand = new SimpleCommand<object, EventToCommandArgs>(e => ((Window)e.Sender).DragMove());
        }

        private void PerformLoginCommand()
        {
            EnableControls = false;

            //if (ConnectToServer())
            //{
            //    if (!RequestRepository().GetAll().FirstOrDefault(u => u.Username == Username && u.Password == Password).IsNull())
            //    {
            LoginMessage = String.Empty;
            //LoggedIn.Raise(this);
            //    }
            //    else
            //    {
            //        LoginMessage = "Incorrect Login/Username and/or Password";
            //    }
            //}
            //else
            //{
            //    LoginMessage = "Server failed to connect.";
            //}

            EnableControls = true;
        }

        //private static Upgrade ReadConnectionSettings()
        //{
        //    var serializer = new XmlSerializer(typeof(Upgrade));
        //    using (var reader = new StreamReader(SettingsFilePath))
        //    {
        //        return (Upgrade)serializer.Deserialize(reader);
        //    }
        //}

        //private static void WriteConnectionSettings(Upgrade settings)
        //{
        //    var serializer = new XmlSerializer(typeof(Upgrade));
        //    using (var writer = new StreamWriter(SettingsFilePath))
        //    {
        //        serializer.Serialize(writer, settings);
        //    }
        //}

        //private bool ConnectToServer()
        //{
        //    if (Server.IsConnected) return true;

        //    _serverConnect.Reset();
        //    Server.PerformConnect();
        //    return _serverConnect.WaitOne(5000);
        //}

        //private static ConnectionSettings ReadConnectionSettings()
        //{
        //    var serializer = new XmlSerializer(typeof(ConnectionSettings));
        //    using (var reader = new StreamReader(SettingsFilePath))
        //    {
        //        return (ConnectionSettings)serializer.Deserialize(reader);
        //    }
        //}

        ////private void InitializeUserRepository()
        ////{
        ////    Task.Factory.StartNew(() =>
        ////    {
        ////        repositoryViewModel.Initialize(RequestRepository<TR>().GetAll().OfType<AccessObjectBase>());
        ////    });
        ////}

        //private IUserRepository RequestRepository()
        //{
        //    Messenger messenger;
        //    if (!Server.GetMessageSender(out messenger))
        //    {
        //        throw new ExternalException(
        //            string.Format("Lost connection to server {0}:{1}.", Server.Settings.HostDesignation, Server.Settings.IpPort));
        //    }

        //    return (new DatabaseSetup(messenger)).GetRepository<IUserRepository>();
        //}
    }
}
