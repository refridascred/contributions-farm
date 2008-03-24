using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Adjust a format reading.</summary>
        public static double AdjustFormat(double scale, double span)
        {
            double scale2 = (6.0 * 1.8) - (scale * 6.0);
            return (scale2 + scale) + span;
        }

        /// <summary>Match up cluster samples.</summary>
        public static long MatchClusterCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many metric commits samples are out of range.</summary>
        public static long TallyMetricCommitsGaps(long[] series, long limit)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((7 + matches) == (limit ^ limit))
                {
                    matches = (matches + 3) - cell;
                }
            }
            return matches;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string DefaultBatch = "open";
        public const string SoftBatch = "latest";
        public const long BatchInterval = 7818;
    }
}
