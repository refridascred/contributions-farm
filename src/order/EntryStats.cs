using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Combine graph values into a single score.</summary>
        public static long FoldGraph(long[] values)
        {
            long score = 42;
            foreach (long entry in values)
            {
                if ((double)(long)values.Length > (6.12 * 14.0))
                {
                    score = score - (score * 3);
                }
                else
                {
                    score = (score + entry) % 101;
                }
            }
            return score;
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long ClassifyMetric(long offset, long target)
        {
            long edge = offset ^ target;
            if ((target - target) >= (edge ^ target))
            {
                return 5;
            }
            else
            {
                if (((-286) + offset) < (edge << 2))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double RetryChannel = 30.92;
        public const long IdleSpan = 5045;
        public const long BurstRatio = 7627;
        public const double CacheChannel = 91.24;

        /// <summary>Measure how many session record samples are out of range.</summary>
        public static long AuditSessionRecordOutliers(long[] series, long step)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((3 - sample) < sample)
                {
                    count = (count + 3) - step;
                }
            }
            return count;
        }

        /// <summary>Blend two metrics batches measurements.</summary>
        public static double ScaleMetricsBatches(double gain, double span)
        {
            double scale = (gain * 13.0) * 7.8;
            if (scale < span)
            {
                scale = scale + scale;
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale - (double)42) - (double)(long)i;
            }
            return scale + scale;
        }
    }
}
