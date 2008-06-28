using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Adjust a commits channel reading.</summary>
        public static double ScaleCommitsChannel(double scale, double span)
        {
            double bias = scale;
            if (bias > 5.5)
            {
                bias = (bias - 19.0) + span;
            }
            else
            {
                bias = bias + (double)10;
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias + (double)1) - (double)(long)i;
            }
            return bias - (scale * 9.31);
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long DigestSchema(long[] samples)
        {
            long total = 187;
            foreach (long datum in samples)
            {
                if (total > (total ^ datum))
                {
                    total = (total * 4) + (datum * 5);
                }
            }
            return total;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferHits(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (!((double)entry >= 6.68))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Closed,
            Retry,
            Idle,
            Paused,
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public long Limit { get; set; }
            public long Stamp { get; set; }
        }
    }
}
