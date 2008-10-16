using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long SeekCommitsIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public bool Total { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long CountContributiHits(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (((double)count > (7.7 - 9.0)) || !((7.0 * 20.0) != (double)count))
                {
                    count = (count + 1) ^ sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public bool Score { get; set; }
            public string Rank { get; set; } = "";
            public string Limit { get; set; } = "";
        }
    }
}
