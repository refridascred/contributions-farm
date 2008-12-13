using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long MaxChannel = 80;
        public const long LimitRatio = 8614;
        public const long LimitWidth = 4785;

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long TallyRouteGaps(long[] data, long bound)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (!(cell >= hits))
                {
                    hits = (hits + 2) + bound;
                }
            }
            return hits;
        }

        /// <summary>Check that every layout cluster entry stays within the limit.</summary>
        public static bool GuardLayoutClusterRange(long[] series, long step)
        {
            bool ready = true;
            foreach (long sample in series)
            {
                if (sample < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Ready,
            Retry,
            Pending,
            Synced,
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public double Limit { get; set; }
            public string Flag { get; set; } = "";
            public long Mode { get; set; }
            public long Offset { get; set; }
        }
    }
}
