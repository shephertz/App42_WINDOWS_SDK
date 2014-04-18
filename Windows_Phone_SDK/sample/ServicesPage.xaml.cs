using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;
using com.shephertz.app42.paas.sdk.windows;
using com.shephertz.app42.paas.sdk.windows.user;
using Newtonsoft.Json.Linq;
using com.shephertz.app42.paas.sdk.windows.storage;
using Microsoft.Phone.Tasks;
using System.Windows.Media.Imaging;
using com.shephertz.app42.paas.sdk.windows.upload;
using com.shephertz.app42.paas.sdk.windows.game;

namespace App42Sample
{
    public partial class ServicesPage : PhoneApplicationPage,App42Callback
    {
     
        UserService userService = null;
        StorageService storageService = null;
        UploadService uploadService = null;
        GameService gameService = null;
        ScoreBoardService scoreBoardService = null;      
        PhotoChooserTask photoChooserTask;
        PhotoChooserTask photoChooserTask2;
        String PhotoPath;
        public ServicesPage()
        {
            App42API.Initialize(Constants.apiKey,Constants.secretKey );
            App42Log.SetDebug(true);
            InitializeComponent();
            userService = App42API.BuildUserService();
            storageService = App42API.BuildStorageService();
            gameService = App42API.BuildGameService();
            scoreBoardService = App42API.BuildScoreBoardService();
            uploadService = App42API.BuildUploadService();          
            photoChooserTask = new PhotoChooserTask();
            photoChooserTask.Completed += new EventHandler<PhotoResult>(photoChooserTask_Completed);
            photoChooserTask2 = new PhotoChooserTask();
            photoChooserTask2.Completed += new EventHandler<PhotoResult>(photoChooserTask2_Completed);
        }
        public void OnSuccess(Object response)
        {
            Deployment.Current.Dispatcher.BeginInvoke(() => {
            switch (pivot.SelectedIndex)
            {
                case 0:
                    UserOutput.Text = "Successfull Response:-" + response;
                    break;
                case 1:
                    StorageOutput.Text = "Successfull Response:-" + response; 
                    break;
                case 2:
                    gameOutput.Text = "Successfull Response:-" + response;                   
                    break;
                case 3:
                    uploadOutput.Text = "Successfull Response:-" + response;
                    break;
            }
            });    
        }
        public void OnException(App42Exception exception)
        {
            Deployment.Current.Dispatcher.BeginInvoke(() => {
            switch (pivot.SelectedIndex)
            {
                case 0:
                    if (exception.GetAppErrorCode() == 1401)
                    {
                        MessageBox.Show("Please Enter valid api key and secret key getting from AppHQ Management Console!!!", "App42 Security Exception", MessageBoxButton.OK);
                    }
                    else
                    {
                        UserOutput.Text = "Exception Caught successfully:-" + exception.Message;
                    }

                    break;
                case 1:
                    if (exception.GetAppErrorCode() == 1401)
                    {
                        MessageBox.Show("Please Enter valid api key and secret key getting from AppHQ Management Console!!!", "App42 Security Exception", MessageBoxButton.OK);
                    }
                    else
                    {
                        StorageOutput.Text = "Exception Caught successfully:-" + exception.Message;
                    }
                    break;
                case 2:
                    if (exception.GetAppErrorCode() == 1401)
                    {
                        MessageBox.Show("Please Enter valid api key and secret key getting from AppHQ Management Console!!!", "App42 Security Exception", MessageBoxButton.OK);
                    }
                    else
                    {
                        gameOutput.Text = "Exception Caught successfully:-" + exception.Message;
                    }
                    break;
                case 3:
                    if (exception.GetAppErrorCode() == 1401)
                    {
                        MessageBox.Show("Please Enter valid api key and secret key getting from AppHQ Management Console!!!", "App42 Security Exception", MessageBoxButton.OK);
                    }
                    else 
                    {
                        uploadOutput.Text = "Exception Caught successfully:-" + exception.Message;
                    }
                    break;
            }
            });
        }

        private void createUser_Click(object sender, RoutedEventArgs e)
        {

            String userName = "Nick" + DateTime.Now.Millisecond;
            String password = "password";
            String email = "Nick" + DateTime.Now.Millisecond + "@gmail.com";
            userService.CreateUser(userName, password, email, this);
            Constants.uname = userName;
        }
        private void getUser_Click(object sender, RoutedEventArgs e)
        {
            userService.GetUser(Constants.uname, this);
        }

        private void authenticate_Click(object sender, RoutedEventArgs e)
        {
            userService.Authenticate(Constants.uname, "password", this);
         
        }
        private void deleteUser_Click(object sender, RoutedEventArgs e)
        {
            userService.DeleteUser(Constants.uname, this);
        }
        private void InsertJSONDocumentWithJsonObject_Click(object sender, RoutedEventArgs e)
        {
            JObject jsonObj = new JObject();
            jsonObj.Add("Name", "Nick");
            jsonObj.Add("Age", 30);
            storageService.InsertJSONDocument(Constants.dbName,Constants.collectionName, jsonObj, this);            
        }
        private void UpdateDocByKeyValueWithJsonString_Click(object sender, RoutedEventArgs e)
        {
            String key = "Name";
            String value = "Nick";
            JObject newJsonDoc = new JObject();
            newJsonDoc.Add("name", "John");
            newJsonDoc.Add("age", 20);
            storageService.UpdateDocumentByKeyValue(Constants.dbName, Constants.collectionName, key, value, newJsonDoc, this);
        }
        private void FindDocumentByKeyValue_Click(object sender, RoutedEventArgs e)
        {
            String key = "Name";
            String value = "Nick";
            storageService.FindDocumentByKeyValue(Constants.dbName, Constants.collectionName, key, value, this);
        }
        private void clear_Click(object sender, RoutedEventArgs e)
        {
            UserOutput.Text = string.Empty;
            StorageOutput.Text = string.Empty;
            gameOutput.Text = string.Empty;
            uploadOutput.Text = string.Empty;
        }

        private void clearStorage_Click(object sender, RoutedEventArgs e)
        {
            UserOutput.Text = string.Empty;
            StorageOutput.Text = string.Empty;
            gameOutput.Text = string.Empty;
            uploadOutput.Text = string.Empty;
        }
        private void clearGame_Click(object sender, RoutedEventArgs e)
        {
            UserOutput.Text = string.Empty;
            StorageOutput.Text = string.Empty;
            gameOutput.Text = string.Empty;
            uploadOutput.Text = string.Empty;
        }
        private void clearUpload_Click(object sender, RoutedEventArgs e)
        {
            UserOutput.Text = string.Empty;
            StorageOutput.Text = string.Empty;
            gameOutput.Text = string.Empty;
            uploadOutput.Text = string.Empty;
        }  
        private void UploadFile_Click(object sender, RoutedEventArgs e)
        {
            photoChooserTask.Show();
        }
        void photoChooserTask_Completed(object sender, PhotoResult e)
        {
            if (e.TaskResult == TaskResult.OK)
            {
                BitmapImage bmp = new BitmapImage();
                bmp.SetSource(e.ChosenPhoto);
                PhotoPath = e.OriginalFileName;
                String fileName = "windowsImage" + DateTime.Now.Millisecond + ".jpg";
                String description = "App42 Winbdows Upload Service";
                uploadService.UploadFile(fileName, e.ChosenPhoto, "IMAGE", description, this);
                Constants.fileName1 = fileName;
            }
        }
        private void UploadFileForUser_Click(object sender, RoutedEventArgs e)
        {
            photoChooserTask2.Show();
        }
        void photoChooserTask2_Completed(object sender, PhotoResult e)
        {
            if (e.TaskResult == TaskResult.OK)
            {
                BitmapImage bmp = new BitmapImage();
                bmp.SetSource(e.ChosenPhoto);
                PhotoPath = e.OriginalFileName;
                String fileName = "windowsImage" + DateTime.Now.Millisecond + ".jpg";
                 String description = "App42 Winbdows Upload Service";
                 uploadService.UploadFileForUser(fileName, Constants.userName, e.ChosenPhoto, "IMAGE", description, this);
                Constants.fileName2 = fileName;
            }
        }
        private void GetFileByName_Click(object sender, RoutedEventArgs e)
        {
            uploadService.GetFileByName(Constants.fileName1, this);
        }
        private void RemoveFileByName_Click(object sender, RoutedEventArgs e)
        {
            uploadService.RemoveFileByName(Constants.fileName1, this);
        }
        private void GetFileByUser_Click(object sender, RoutedEventArgs e)
        {
            uploadService.GetFileByUser(Constants.fileName2, Constants.userName, this);
        }

        private void CreateGame_Click(object sender, RoutedEventArgs e)
        {
            gameService.CreateGame(Constants.gameName, "game_Description", this);   
        }
        private void SaveUserScore_Click(object sender, RoutedEventArgs e)
        {
            scoreBoardService.SaveUserScore(Constants.gameName, Constants.gameUserName, 100000, this);
        }

        private void LeaderBoard_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/leaderboard.xaml", UriKind.Relative));
        }
    }
}