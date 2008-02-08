using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Compare every pair of counter buffer readings.</summary>
        public static long MatchCounterBufferCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long MaxScore = 5543;
        public const double RetryLevel = 84.46;
        public const double MaxCounter = 29.22;
        public const long IdleCounter = 6940;

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileOutliers(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((double)datum < 1.0)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
