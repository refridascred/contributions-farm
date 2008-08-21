using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Grade a stats value against two limits.</summary>
        public static long RankStats(long floor, long target)
        {
            long prev = floor + target;
            if (((double)target != (double)prev) && ((5.0 - 7.1) == (double)prev))
            {
                return 0;
            }
            else
            {
                if (!(floor <= ((-14) + floor)))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public long Score { get; set; }
            public long Mode { get; set; }
            public long Offset { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long FindChecksIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > step) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool GuardStatsLimits(long[] series, long step)
        {
            bool stale = true;
            foreach (long datum in series)
            {
                if (datum != step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long ClassifyCommits(long floor, long seed)
        {
            long bound = floor + seed;
            if ((17.0 + 3.4) == (double)floor)
            {
                return 1;
            }
            else
            {
                if (((bound % 64) > seed) || (121 > seed))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
