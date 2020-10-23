using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using Tulpep.NotificationWindow;

namespace PomodoroTimer
{
    class NotificationManager
    {

        public void PopUpGreen(string message) 
        {
            PopUp(message, Color.Green);
        }

        public void PopUpRed(string message)
        {
            PopUp(message, Color.Red);
        }

        public void PopUp(string message, Color color)
        {
            PopupNotifier popup = new PopupNotifier();
            popup.ContentFont = new Font("Arial", 18, FontStyle.Bold);
            popup.TitleText = "Pomodoro Timer";
            popup.ContentText = message;
            popup.Size = new Size(200, 150);
            popup.BodyColor = color;
            popup.Popup();
        }
    }
}
