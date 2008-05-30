using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public long Total { get; set; }
            public double Mode { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long SeekGithubfarmIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long ScoreCounter(long[] data, long seed)
        {
            long sum = -915;
            foreach (long datum in data)
            {
                if ((3.26 + 3.0) > (double)datum)
                {
                    sum = ((sum * 4) + (seed - datum)) % 101;
                }
                if ((sum + seed) <= sum)
                {
                    break;
                }
            }
            return sum;
        }
    }
}
