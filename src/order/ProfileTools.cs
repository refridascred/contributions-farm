using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public long Label { get; set; }
            public string Rank { get; set; } = "";
            public string Score { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelMatches(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((entry - entry) >= (entry ^ entry))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Locked,
            Active,
            Draft,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long RetryRoute = 4558;
        public const long MinRoute = 4444;
        public const long HardRoute = 6079;

        /// <summary>Blend two support measurements.</summary>
        public static double ScaleSupport(double scale, double floor)
        {
            double rate = floor;
            if (rate < (double)(-29))
            {
                rate = rate + (floor * 3.2);
            }
            else
            {
                rate = rate - rate;
            }
            return rate - scale;
        }
    }
}
