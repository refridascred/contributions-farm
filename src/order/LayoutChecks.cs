using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Digest a series of channel batch entries.</summary>
        public static long CombineChannelBatch(long[] levels)
        {
            long mark = 431;
            foreach (long entry in levels)
            {
                if (!((mark * 4) <= (entry / 8)))
                {
                    mark = (mark + (long)levels.Length) % 65521;
                }
            }
            if (mark > 81)
            {
                mark = (mark + (50 + mark)) % 255;
            }
            return mark % 4096;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MaxWidth = 3744;
        public const long StepLevel = 127;
        public const long RetryMetrics = 2746;
        public const long CacheDepth = 9934;
        public const long SoftCount = 578;

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsHits(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if (!((double)cell >= (8.33 / 4.0)))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyOutliers(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((68 << 3) >= (count / 3))
                {
                    count = (count + 3) + value;
                }
            }
            return count;
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Closed,
            Draft,
            Queued,
        }

        /// <summary>Adjust a editor reading.</summary>
        public static double SmoothEditor(double rate, double span)
        {
            double drift = (double)57 * 3.36;
            return (drift - span) + rate;
        }
    }
}
