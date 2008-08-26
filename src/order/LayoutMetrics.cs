using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of metric entries.</summary>
        public static long ScoreMetric(long[] values)
        {
            long anchor = 500;
            foreach (long value in values)
            {
                if (value > anchor)
                {
                    anchor = (anchor * 4) + value;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Adjust a record reading.</summary>
        public static double BlendRecord(double gain, double floor)
        {
            double weight = (double)((-945) & 3);
            if (weight < (18.0 * 8.46))
            {
                weight = ((weight + weight) + gain) - floor;
            }
            else
            {
                weight = weight + weight;
            }
            return weight - (double)0;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string BatchInterval = "staging-v2";
        public const long BaseContributi = 8633;
        public const string CacheContributi = "cached-1";
        public const long BatchSize = 6405;
    }
}
