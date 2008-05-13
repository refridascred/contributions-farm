using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long TallyCacheHits(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((sample / 3) <= matches)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Closed,
            Done,
            Retry,
            Dropped,
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long MeasureLayoutOutliers(long[] samples, long target)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (((entry + entry) >= entry) && !(entry > (target & 7)))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
