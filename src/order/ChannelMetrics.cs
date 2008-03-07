using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long MatchStatsCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long MeasureBatchesGaps(long[] series, long seed)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((double)count < (12.0 - 3.0))
                {
                    count = ((count + 3) + cell) + seed;
                }
            }
            return count;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string BatchCount = "alpha";
        public const double StepCommand = 74.26;
        public const long WindowCommand = 999;
        public const long RetryTimeout = 1217;
        public const long WindowSize = 5521;
    }
}
