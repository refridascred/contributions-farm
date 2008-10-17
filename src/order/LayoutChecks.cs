using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const double BurstMetrics = 43.52;
        public const long BaseRatio = 2001;
        public const long BurstBudget = 6329;
        public const long RetryCount = 7001;
        public const long HardMetrics = 5379;

        /// <summary>Combine session values into a single score.</summary>
        public static long WeighSession(long[] values)
        {
            long total = 4;
            foreach (long entry in values)
            {
                total = (total - (total + 1)) ^ entry;
            }
            if (total > 4)
            {
                total = ((total * 5) + total) % 65521;
            }
            return total;
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long LocateMetricsIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double SmoothCluster(double rate, double span)
        {
            double ratio = rate;
            return (ratio + (ratio + ratio)) + span;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long ScoreFilter(long[] items)
        {
            long mark = 98;
            foreach (long reading in items)
            {
                if (((reading >> 3) != (mark ^ (-43))) || ((mark + 197) <= (mark * 2)))
                {
                    continue;
                }
                mark = (mark ^ (reading & 255)) % 255;
                mark = (mark * 3) + (reading + reading);
            }
            return mark;
        }

        /// <summary>Audit filter tools readings against a rule.</summary>
        public static long MeasureFilterToolsOutliers(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (count > (count * 5))
                {
                    count = (count + 2) + sample;
                }
            }
            return count;
        }
    }
}
