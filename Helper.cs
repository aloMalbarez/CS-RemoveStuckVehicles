using ColossalFramework.Plugins;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace RemoveStuckVehicles
{
    internal sealed class Helper
    {
        private Helper()
        {
            GameLoaded = false;
            ManualRemovalRequests = new HashSet<ushort>();
        }

        private static readonly Helper _Instance = new Helper();
        public static Helper Instance { get { return _Instance; } }

        internal bool GameLoaded;
        internal HashSet<ushort> ManualRemovalRequests;

        public void Log(string message)
        {
            Debug.Log(String.Format("{0}: {1}", Settings.Instance.Tag, message));
        }

        public void NotifyPlayer(string message)
        {
            DebugOutputPanel.AddMessage(PluginManager.MessageType.Message, String.Format("{0}: {1}", Settings.Instance.Tag, message));
            Log(message);
        }
    }
}