﻿using Assets._Scripts.Dissonance;

namespace Synapse.Api.Events.SynapseEventArguments
{
    public class PlayerJoinEventArgs: EventHandler.ISynapseEventArgs
    {
        public Player Player { internal set; get; }
        
        public string Nickname { set; get; }
    }

    public class PlayerLeaveEventArgs : EventHandler.ISynapseEventArgs
    {
        public Player Player { get; internal set; }
    }

    public class PlayerBanEventArgs : EventHandler.ISynapseEventArgs
    {
        public bool Allow { get; set; } = true;
        
        public Player BannedPlayer { get; internal set; }
        
        public Player Issuer { get; internal set; }
        
        public int Duration { get; set; }
        
        public string Reason { get; set; }
    }

    public class PlayerSpeakEventArgs : EventHandler.ISynapseEventArgs
    {
        public Player Player { get; internal set; }
        
        public DissonanceUserSetup DissonanceUserSetup { get; internal set; }

        public bool Scp939Talk { get; set; }
        
        public bool IntercomTalk { get; set; }
        
        public bool RadioTalk { get; set; }
        
        public bool ScpChat { get; set; }
        
        public bool SpectatorChat { get; set; }
        
        public bool Allow { get; set; }
    }
}