using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public long Owner { get; set; }
            public double Weight { get; set; }
            public long Rank { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string MaxStats = "stable-v2";
        public const string BurstLevel = "fallback-1";
        public const string BatchStats = "alpha";

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public double Region { get; set; }
            public long Ratio { get; set; }
            public bool Rank { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Count the layout record entries that pass the check.</summary>
        public static long MeasureLayoutRecordMatches(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((7.1 - 18.0) >= (double)cell)
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
