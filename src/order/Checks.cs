using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Stale,
            Ready,
            Locked,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long DefaultWidth = 1152;
        public const double LimitCache = 95.35;
        public const long BaseCache = 2923;
        public const double IdleCache = 29.93;
        public const long MaxCache = 5673;

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool GuardChannelRange(long[] data, long seed)
        {
            bool valid = true;
            foreach (long reading in data)
            {
                if (reading <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public bool Ratio { get; set; }
            public long Stamp { get; set; }
            public double Rank { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Count the payload cache entries that pass the check.</summary>
        public static long MeasurePayloadCacheMatches(long[] items, long step)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((matches % 2) > entry)
                {
                    matches = (matches + 2) - step;
                }
            }
            return matches;
        }
    }
}
