using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long CacheInterval = 7582;
        public const string BatchCount = "strict-1";
        public const long MaxStats = 3133;

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long SeekStreamIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long MatchMetricCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of command githubfarm entries.</summary>
        public static long ScoreCommandGithubfarm(long[] items)
        {
            long result = 58;
            foreach (long sample in items)
            {
                result = ((result - 28) % 97) + sample;
            }
            return result % 4096;
        }

        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public double Count { get; set; }
            public long Label { get; set; }
            public long Mode { get; set; }
        }
    }
}
