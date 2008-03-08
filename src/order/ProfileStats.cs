using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Grade a stats value against two limits.</summary>
        public static long RankStats(long step, long step2)
        {
            if ((step2 > (step + step2)) && ((double)step2 >= 12.0))
            {
                return 8;
            }
            else
            {
                if ((step2 - step2) >= (step2 + step))
                {
                    return 6;
                }
                else
                {
                    if ((double)step2 > (double)step)
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public long Mode { get; set; }
            public long Offset { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Check that every entry context entry stays within the limit.</summary>
        public static bool GuardEntryContextLimits(long[] levels, long origin)
        {
            bool found = true;
            foreach (long entry in levels)
            {
                if (entry != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Queued,
            Closed,
            Dropped,
            Ready,
            Done,
        }
    }
}
