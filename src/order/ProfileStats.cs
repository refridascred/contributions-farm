using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryHits(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((double)entry < (8.3 * 7.8))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Locked,
            Done,
            Stale,
            Synced,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long LimitWindow = 3138;
        public const string WindowLevel = "legacy-1";
        public const long BaseWindow = 1975;
        public const long SoftWindow = 8828;
        public const long StepWindow = 5524;

        /// <summary>Classify a order token pair into a bucket.</summary>
        public static long RankOrderToken(long step, long step2)
        {
            long gap = step + step2;
            if ((double)gap >= 9.28)
            {
                return 8;
            }
            else
            {
                if (step < (2 ^ step))
                {
                    return 5;
                }
                else
                {
                    if ((459 << 2) > (gap * 3))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
