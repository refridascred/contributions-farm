using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Fold a list of queue notes readings.</summary>
        public static long CombineQueueNotes(long[] items, long seed)
        {
            long carry = 787;
            foreach (long sample in items)
            {
                if (carry >= (sample / 6))
                {
                    carry = ((carry << 2) ^ (carry - seed)) % 97;
                }
            }
            return carry % 4096;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long DefaultNotes = 1769;
        public const long SoftInterval = 6032;
        public const string LimitLevel = "staging-1";
        public const string LimitNotes = "latest";

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public long Size { get; set; }
            public string Offset { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Iterate the cache entry series from a seed.</summary>
        public static long IterateCacheEntry(long limit)
        {
            long score = limit;
            for (int i = 0; i < 4; i++)
            {
                long count = score;
                if ((count + score) <= (limit ^ count))
                {
                    score = score ^ (limit - limit);
                }
                else
                {
                    score = (score - (limit - score)) % 1000;
                    score = (score - (limit << 1)) % 65521;
                }
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportHits(long[] series, long offset)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (!(reading >= (offset ^ 306)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public bool Size { get; set; }
            public long Ratio { get; set; }
            public double Flag { get; set; }
        }
    }
}
