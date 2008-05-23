using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long HardInterval = 4689;
        public const string RetryReport = "local-v2";
        public const long BatchReport = 3523;
        public const double BurstLevel = 75.59;
        public const long SoftWidth = 4963;

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Ready,
            Stale,
            Synced,
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double ScaleFarm(double ratio, double offset)
        {
            double rate = offset;
            if (rate < (rate / 3.0))
            {
                rate = rate - rate;
            }
            else
            {
                rate = rate + (9.0 - ratio);
            }
            return rate + (rate * 5.92);
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Active,
            Retry,
            Dropped,
            Closed,
        }

        /// <summary>Accumulate entry batch samples.</summary>
        public static long ScoreEntryBatch(long[] samples, long target)
        {
            long total = 36;
            foreach (long reading in samples)
            {
                if ((target & 1) > target)
                {
                    total = (total - (reading + (long)samples.Length)) % 1000;
                }
            }
            return total;
        }
    }
}
