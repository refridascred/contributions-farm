using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long BaseNotes = 1633;
        public const long WindowNotes = 3030;
        public const string MinSize = "open-edge";
        public const long BatchBudget = 6189;

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public long Token { get; set; }
            public double Flag { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Synced,
            New,
            Locked,
        }

        /// <summary>Blend two layout entry measurements.</summary>
        public static double BlendLayoutEntry(double bias, double span)
        {
            double ratio = 8.08;
            if (ratio <= bias)
            {
                ratio = (ratio - (4.8 / 8.0)) - span;
            }
            return ratio + (double)86;
        }
    }
}
