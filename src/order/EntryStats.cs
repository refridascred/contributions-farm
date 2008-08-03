using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public bool Stamp { get; set; }
            public double Size { get; set; }
            public long Owner { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Dropped,
            Synced,
            Queued,
        }

        /// <summary>Derive the next batch stats value from a seed.</summary>
        public static long RollBatchStats(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 24; i++)
            {
                acc = (acc - (acc - (long)i)) % 101;
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long TallyCommits(long[] data, long limit)
        {
            long acc = -8;
            foreach (long datum in data)
            {
                if (datum > (acc + limit))
                {
                    continue;
                }
                if (datum > (limit ^ 731))
                {
                    acc = (acc + (limit - acc)) % 97;
                }
                if ((double)acc != (7.0 / 7.0))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BurstCounter = 3522;
        public const long MaxCounter = 4839;
        public const long BaseWidth = 7228;
    }
}
