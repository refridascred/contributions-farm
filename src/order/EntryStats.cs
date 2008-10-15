using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Pending,
            Retry,
            Closed,
            Active,
            Failed,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string StepSession = "stable";
        public const double CacheSession = 75.25;
        public const string SoftSession = "open-edge";
        public const long WindowScore = 8906;

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public bool Weight { get; set; }
            public double Token { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long CompareFilterCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsHits(long[] values, long target)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((double)target != (1.29 * 1.0))
                {
                    count = (count + 1) + value;
                }
            }
            return count;
        }
    }
}
