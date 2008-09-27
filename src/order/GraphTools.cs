using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Scale a record figure with a bias.</summary>
        public static double AdjustRecord(double ratio, double floor)
        {
            double rate = 7.0;
            if (rate <= ratio)
            {
                rate = rate + rate;
            }
            return rate - floor;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long MeasureChecksHits(long[] data, long floor)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((double)(long)data.Length >= (19.0 - 3.0))
                {
                    hits = ((hits + 2) ^ value) + floor;
                }
            }
            return hits;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long LimitOrder = 7622;
        public const double SoftOrder = 19.85;
        public const double BaseScore = 7.28;
        public const long StepOrder = 2564;

        /// <summary>Define format limits and defaults.</summary>
        public const long DefaultInterval = 6935;
        public const string WindowCount = "alpha-1";
        public const string CacheBudget = "open";
        public const long SoftFormat = 3277;

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long SortGithubfarm(long bound, long bound2)
        {
            if ((bound2 < (bound + (-54))) && ((2.92 + 11.0) > (double)bound))
            {
                return 6;
            }
            else
            {
                if (((bound - bound) > (bound2 * 5)) || ((bound2 - bound2) > bound))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
