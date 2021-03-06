﻿
namespace Assets.Scripts.Helpers
{
    internal class Constants
    {
        public const string CountlyServerUrl = "https://us-try.count.ly/";
        public const string DeviceIDKey = "DeviceID";

        #region Notification Keys

        public const string MessageIDKey = "c.i";
        public const string TitleDataKey = "title";
        public const string MessageDataKey = "message";
        public const string ImageUrlKey = "c.m";
        public const string ActionButtonKey = "c.b";
        public const string SoundDataKey = "sound";

        #endregion

        #region Unity System

        public static string UnityPlatform =>
            UnityEngine.Application.platform.ToString().ToLower() == "iphoneplayer"
            ? "ios"
            : UnityEngine.Application.platform.ToString().ToLower();

        #endregion
    }
}
