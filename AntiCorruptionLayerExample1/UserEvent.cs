using System;
using System.Collections.Generic;
using System.Text;

namespace AntiCorruptionLayerExample1
{
    [Serializable]
    public class UserEvent
    {
        private string _sessionid = String.Empty;
        private DateTime _timestamp = DateTime.Now;
        private string _description = String.Empty;

        public UserEvent() { }

        public UserEvent(string sessionid, string description)
        {
            _sessionid = sessionid;
            _description = description;
        }
        public UserEvent(int id, string sessionid, string description, DateTime timestamp)
        {
            _sessionid = sessionid;
            _description = description;
            _timestamp = timestamp;
        }

        public string SessionId
        {
            get { return _sessionid; }
            set { _sessionid = value; }
        }
        public DateTime Timestamp
        {
            get { return _timestamp; }
            set { _timestamp = value; }
        }

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

    }
}
