﻿namespace BetterMembership.Website.Models
{
    public class ExternalLogin
    {
        public string Provider { get; set; }

        public string ProviderDisplayName { get; set; }

        public string ProviderUserId { get; set; }
    }
}