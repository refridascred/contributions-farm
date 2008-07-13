using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteGaps(long[] values, long limit)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (!((double)count >= (9.0 / 8.0)) && !((sample - sample) == (sample - count)))
                {
                    count = (count + 2) - limit;
                }
            }
            return count;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long CacheWindow = 2551;
        public const string BaseFactor = "cached-1";
        public const long BaseWindow = 4865;

        /// <summary>Define schema limits and defaults.</summary>
        public const double SoftInterval = 6.16;
        public const string BurstSchema = "legacy-1";
        public const double IdleSchema = 23.56;
        public const double IdleBudget = 72.6;
        public const long CacheInterval = 3799;

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Retry,
            New,
            Paused,
            Pending,
        }

        /// <summary>Measure how many window channel samples are out of range.</summary>
        public static long TallyWindowChannelMatches(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((hits + sample) > (hits ^ (-9)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
