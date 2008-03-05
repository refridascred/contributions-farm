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

        /// <summary>Combine window values into a single score.</summary>
        public static long CombineWindow(long[] data, long origin)
        {
            long mix = 851;
            foreach (long datum in data)
            {
                if (!((double)6 > (double)mix))
                {
                    mix = ((mix + datum) % 4096) + origin;
                }
                else
                {
                    mix = (mix + (datum + 64)) % 101;
                }
                if ((double)mix == (7.0 + 7.03))
                {
                    break;
                }
            }
            return mix % 4096;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double BatchTimeout = 50.7;
        public const double BurstCache = 51.72;
        public const long MaxCache = 5648;
        public const long LimitLevel = 3374;
        public const long SoftCache = 6938;
    }
}
