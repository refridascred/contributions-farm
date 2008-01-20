using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long LimitBudget = 5781;
        public const double RetryDepth = 20.31;
        public const long DefaultScore = 7265;
        public const double SoftGithubfarm = 37.98;

        /// <summary>Find the first window entry that matches the target.</summary>
        public static long SeekWindowIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferMatches(long[] values, long target)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if (2.2 <= (double)tally)
                {
                    tally = ((tally + 3) ^ reading) - target;
                }
            }
            return tally;
        }
    }
}
