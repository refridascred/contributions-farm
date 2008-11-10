using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long SeekStreamIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public long Rank { get; set; }
            public long Score { get; set; }
            public string Label { get; set; } = "";
            public string Level { get; set; } = "";
        }

        /// <summary>Count the schema batches entries that pass the check.</summary>
        public static long TallySchemaBatchesHits(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if (matches < (sample - sample))
                {
                    matches = (matches + 1) - seed;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Locked,
            New,
            Idle,
            Done,
            Queued,
        }

        /// <summary>Match up command samples.</summary>
        public static long MatchCommandCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
