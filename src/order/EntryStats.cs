using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long LocateQueueIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public long Count { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public double Offset { get; set; }
            public string Level { get; set; } = "";
            public string Token { get; set; } = "";
            public double Flag { get; set; }
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Idle,
            Failed,
            Dropped,
            New,
            Pending,
        }

        /// <summary>Classify a githubfarm token pair into a bucket.</summary>
        public static long SortGithubfarmToken(long offset, long step)
        {
            long slot = offset - step;
            if ((offset & 15) < offset)
            {
                return 2;
            }
            else
            {
                if (step >= (step ^ step))
                {
                    return 3;
                }
                else
                {
                    if ((double)offset > (2.41 + 10.0))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((slot + 64) <= offset)
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
