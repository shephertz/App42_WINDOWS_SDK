using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using com.shephertz.app42.paas.sdk.windows;
using com.shephertz.app42.paas.sdk.windows.game;
using System.Collections.ObjectModel;

namespace App42Sample
{
    public partial class leaderboard : PhoneApplicationPage
    {
        private static ScoreBoardService mScoreBoardService = null;
        ObservableCollection<ScoreListItem> _scorelist = new ObservableCollection<ScoreListItem>();
        public leaderboard()
        {
            InitializeComponent();
            lbxGlobalScore.DataContext = this;
            lbxGlobalScore.ItemsSource = _scorelist;    
            GetTopNGlobalScores(10, GetTopNRankersCallback);
        }

        public static void GetTopNGlobalScores(int count, App42Sample.App42ApiCallback.App42ApiResultCallback callBack)
        {
            try
            {
                App42ApiCallback _sCallback = new App42ApiCallback(callBack);
                if (mScoreBoardService == null)
                {
                    mScoreBoardService = App42API.BuildScoreBoardService();
                }
                mScoreBoardService.GetTopNRankers(Constants.gameName, count, _sCallback);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        private void GetTopNRankersCallback(object response, bool IsException)
        {
            if (IsException)
            {
                App42Exception exception = (App42Exception)response;
                MessageBox.Show(exception.GetMessage());               
            }
            else
            {             
                com.shephertz.app42.paas.sdk.windows.game.Game game = (com.shephertz.app42.paas.sdk.windows.game.Game)response;
                if (game.IsResponseSuccess())
                {
                    for (int i = 0; i < game.GetScoreList().Count; i++)
                    {
                        ScoreListItem item = new ScoreListItem();
                        item.Rank = (i + 1).ToString();
                        item.Score = game.GetScoreList()[i].GetValue().ToString();
                        item.UserName = game.GetScoreList()[i].GetUserName();
                        _scorelist.Add(item);
                    }
                    lbxGlobalScore.ItemsSource = _scorelist;               
                }
                else
                {
                   // lbxGlobalScoremessageTB.Text = "Error,Please try again later";
                }
            }
        }
    }
}