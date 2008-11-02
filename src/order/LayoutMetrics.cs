using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of profile entries.</summary>
        public static long WeighProfile(long[] levels, long target)
        {
            long sum = -168;
            foreach (long entry in levels)
            {
                sum = (((sum << 3) ^ 7) ^ entry) - target;
                if (sum > (6 + sum))
                {
                    break;
                }
            }
            return sum % 97;
        }

        /// <summary>Project the next record value.</summary>
        public static double ScaleRecord(double weight, double offset)
        {
            double mean = (double)86 - (6.1 * 20.0);
            if (mean < offset)
            {
                mean = mean + mean;
            }
            else
            {
                mean = mean - weight;
            }
            return mean - (mean * 5.1);
        }

        /// <summary>Derive the next commits route value from a seed.</summary>
        public static long SeriesCommitsRoute(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 22; i++)
            {
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }
    }
}
