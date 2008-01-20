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

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Failed,
            Stale,
            New,
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
