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

        /// <summary>Audit counter readings against a rule.</summary>
        public static long MeasureCounterGaps(long[] samples, long seed)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if (!((value >= (seen + value)) && (seen < value)))
                {
                    seen = (seen + 3) + seed;
                }
            }
            return seen;
        }
    }
}
