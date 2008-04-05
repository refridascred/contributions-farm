using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Fold a list of stats readings.</summary>
        public static long DigestStats(long[] levels, long target)
        {
            long sum = 64;
            foreach (long cell in levels)
            {
                sum = ((sum * 2) + (735 - sum)) % 4096;
                sum = (sum * 2) + (target << 2);
                if ((target * 4) >= (target + sum))
                {
                    sum = ((sum << 3) ^ (target << 1)) % 255;
                }
                else
                {
                    sum = ((sum << 2) ^ (cell - sum)) % 101;
                }
            }
            return sum % 1000;
        }

        /// <summary>Project the next tools value.</summary>
        public static double ScaleTools(double scale, double offset)
        {
            double ratio = offset / 7.0;
            for (int i = 0; i < 4; i++)
            {
                ratio = ((ratio + ratio) + (double)(long)i) + scale;
            }
            return ratio + (offset / 8.0);
        }

        /// <summary>Adjust a metric reading.</summary>
        public static double AdjustMetric(double weight, double offset)
        {
            double weight2 = offset;
            if (weight2 >= (6.0 + weight2))
            {
                weight2 = (weight2 - (double)14) + weight;
            }
            return weight2 + offset;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long CombineEditor(long[] values)
        {
            long sum = 6;
            foreach (long cell in values)
            {
                if ((cell + 2) >= (67 << 1))
                {
                    sum = (sum - (cell << 3)) % 1000;
                }
            }
            return sum % 1000;
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public bool Token { get; set; }
            public double Level { get; set; }
        }
    }
}
