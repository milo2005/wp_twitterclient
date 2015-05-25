using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using TestTwitter.Resources;
using TestTwitter.Net;
using TestTwitter.Models;


namespace TestTwitter
{
    public partial class MainPage : PhoneApplicationPage, TwitterClient.TwitterClientI
    {

        //TOKENS
        String consumerKey = "nshMf9JK3d4ggXitEHsY89RHx";
        String consumerSecret = "350JARBf0l1Mmcb5I2y93HY8EvBasIQmGPZvsbJqZk7DUx2srj";
        String accessToken = "3019866874-F8WLd1y5nwWJYJMZAwH4qBdXEUnQuukH62KMs1Q";
        String accesstokenSecret = "XJBcVG6Dmf4gxSCAVhGgBAF8imoaHJJHbJEWul902hEkA";
        String verifier = "uw7NjWHT6OJ1MpJOXsHfNxoAhPKpgI8BlYDhxEjIBY";

        //Twitter Api
        const String screenName = "DarioFChV";
        const String count = "10";
        
        TwitterClient twitter;

        // Constructor
        public MainPage()
        {
            InitializeComponent();
            twitter = new TwitterClient() { ConsumerKey = consumerKey, ConsumerSecret = consumerSecret, AccessToken = accessToken, AccessTokenSecret = accesstokenSecret, OAuthVerifier = verifier };
            // Código de ejemplo para traducir ApplicationBar
            //BuildLocalizedApplicationBar();
        }

        private void prueba(object sender, RoutedEventArgs e)
        {

            twitter.getTweets(screenName, count, this);

        }

        private void pruebapost(object sender, RoutedEventArgs e)
        {
            twitter.postTweet(msg.Text);
        }




        // Código de ejemplo para compilar una ApplicationBar traducida
        //private void BuildLocalizedApplicationBar()
        //{
        //    // Establecer ApplicationBar de la página en una nueva instancia de ApplicationBar.
        //    ApplicationBar = new ApplicationBar();

        //    // Crear un nuevo botón y establecer el valor de texto en la cadena traducida de AppResources.
        //    ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
        //    appBarButton.Text = AppResources.AppBarButtonText;
        //    ApplicationBar.Buttons.Add(appBarButton);

        //    // Crear un nuevo elemento de menú con la cadena traducida de AppResources.
        //    ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
        //    ApplicationBar.MenuItems.Add(appBarMenuItem);
        //}

        public void userTweets(List<Tweet> tweets)
        {
            // Llega la lista completa de tweets :D
        }
    }
}