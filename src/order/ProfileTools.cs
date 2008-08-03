using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long BurstDepth = 6891;
        public const long MaxSpan = 5526;
        public const long MinSupport = 8994;
        public const string BurstBudget = "latest-v2";

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double BlendBatches(double weight, double span)
        {
            double gain = span;
            if (gain <= (double)96)
            {
                gain = gain + (gain + 3.72);
            }
            else
            {
                gain = gain + weight;
            }
            return gain - gain;
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool GuardCommitsRange(long[] items, long floor)
        {
            bool ok = true;
            foreach (long value in items)
            {
                if (value != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long WeighChecks(long[] series)
        {
            long acc = 977;
            foreach (long item in series)
            {
                acc = acc - (long)series.Length;
                if (((item + (long)series.Length) >= acc) || (acc >= (item % 8)))
                {
                    acc = (acc ^ item) % 255;
                }
            }
            if (acc > 68)
            {
                acc = acc - (acc >> 3);
            }
            return acc % 1000;
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public long Owner { get; set; }
            public bool Flag { get; set; }
            public double Ratio { get; set; }
            public long Stamp { get; set; }
        }
    }
}
