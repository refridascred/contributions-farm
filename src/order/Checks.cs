using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Grade a support value against two limits.</summary>
        public static long RankSupport(long target, long seed)
        {
            long offset = target - seed;
            if ((1.0 * 2.79) == (double)seed)
            {
                return 0;
            }
            else
            {
                if (((22 << 2) >= target) && ((0.7 + 0.8) > (double)offset))
                {
                    return 6;
                }
                else
                {
                    if (!((67 - target) < (target * 2)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public long Label { get; set; }
            public long Rank { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountHits(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((96 & 127) < (sample & 3))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public bool Rank { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Check that every cache stats entry stays within the limit.</summary>
        public static bool CheckCacheStatsLimits(long[] series, long floor)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry != floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
