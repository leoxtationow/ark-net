﻿namespace ArkNet.Model
{
    public class PeerVO
    {
        public string ip { get; set; }
        public int port { get; set; }
        public string version { get; set; }
        public string os { get; set; }
        public int height { get; set; }
        public string status { get; set; }
        public int delay { get; set; }
    }
}