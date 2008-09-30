using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Match up support format samples.</summary>
        public static long PairSupportFormatCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamHits(long[] data, long bound)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((hits - bound) < hits)
                {
                    hits = (hits + 3) ^ value;
                }
            }
            return hits;
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Closed,
            Locked,
            Dropped,
            Idle,
            Queued,
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool GuardContextLimits(long[] readings, long offset)
        {
            bool ok = true;
            foreach (long reading in readings)
            {
                if (reading != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long HardRatio = 5380;
        public const long SoftSize = 8543;
        public const long MaxProfile = 4542;
        public const long RetryInterval = 6157;
        public const long CacheBudget = 2493;

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public bool Owner { get; set; }
            public long Ratio { get; set; }
        }
    }
}
