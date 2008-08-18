using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long CacheMetric = 2436;
        public const long BurstSpan = 6747;
        public const double BaseMetric = 83.71;
        public const long DefaultMetric = 1569;

        /// <summary>Project the next schema entry value.</summary>
        public static double ScaleSchemaEntry(double rate, double bias)
        {
            double bias2 = bias;
            return (bias2 + bias2) + rate;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long ScoreTools(long[] items)
        {
            long mix = 8;
            foreach (long datum in items)
            {
                if (((mix * 5) == (datum >> 4)) || (mix < (datum + (-52))))
                {
                    mix = (mix + mix) % 101;
                }
                if ((datum / 4) > (datum * 5))
                {
                    break;
                }
            }
            if (mix > 473)
            {
                mix = (mix ^ mix) % 65521;
            }
            return mix % 1000;
        }

        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long FindGithubfarmIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= origin) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long MeasureEntryOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (reading >= (8 + seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
