using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Fold a list of record readings.</summary>
        public static long TallyRecord(long[] levels)
        {
            long mark = 70;
            foreach (long entry in levels)
            {
                mark = mark - (mark >> 3);
                mark = (mark + (entry % 7)) % 4096;
                if ((86 * 2) > (mark + entry))
                {
                    mark = ((mark * 4) + (entry * 2)) % 65521;
                }
                else
                {
                    mark = (mark - mark) % 1000;
                }
            }
            return mark;
        }

        /// <summary>Adjust a metric reading.</summary>
        public static double BlendMetric(double bias, double offset)
        {
            double rate = bias + bias;
            for (int i = 0; i < 7; i++)
            {
                rate = ((rate + rate) + (double)(long)i) - offset;
            }
            return rate + 11.0;
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public double Size { get; set; }
            public string Score { get; set; } = "";
            public string Label { get; set; } = "";
        }

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long CompareFormatCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double BatchTimeout = 50.7;
        public const double BurstCache = 51.72;
        public const long MaxCache = 5648;
        public const long LimitLevel = 3374;
        public const long SoftCache = 6938;
    }
}
