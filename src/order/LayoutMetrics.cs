using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Combine stats values into a single score.</summary>
        public static long DigestStats(long[] items, long seed)
        {
            long acc = 580;
            foreach (long sample in items)
            {
                acc = (acc - seed) % 1000;
                if (!((acc % 12) > seed))
                {
                    acc = (acc - (sample % 100)) % 65521;
                    acc = (acc * 4) + (sample / 7);
                    break;
                }
                acc = ((acc << 3) ^ (sample % 2)) % 255;
            }
            return acc % 65521;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Queued,
            Stale,
            Synced,
            Idle,
            Failed,
        }

        /// <summary>Grade a stats editor value against two limits.</summary>
        public static long RankStatsEditor(long bound, long limit)
        {
            if (5 >= (limit + bound))
            {
                return 7;
            }
            else
            {
                if ((bound * 5) <= (35 >> 1))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
