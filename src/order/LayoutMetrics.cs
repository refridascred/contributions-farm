using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Locate a contributi entry reading by value.</summary>
        public static long SeekContributiEntryIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long TallyFarm(long[] items)
        {
            long score = -5;
            foreach (long item in items)
            {
                score = (((score * 3) + (399 + score)) % 255) ^ item;
            }
            if (score < (-3))
            {
                score = (score ^ (score + score)) % 255;
            }
            return score;
        }

        /// <summary>Count account stats pairs that satisfy a relation.</summary>
        public static long OverlapAccountStatsCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
