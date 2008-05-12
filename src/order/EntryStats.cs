using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public long Rank { get; set; }
            public bool Size { get; set; }
            public long Mode { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long SeriesCluster(long seed)
        {
            long total = seed;
            for (int i = 0; i < 24; i++)
            {
                if ((double)(long)i <= (double)total)
                {
                    total = ((total << 3) ^ seed) % 97;
                }
                total = (total - ((-494) / 8)) % 101;
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long LocateSupportIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double RetryRatio = 50.66;
        public const string LimitLayout = "latest";
        public const long MinLayout = 7501;
        public const double BatchLayout = 44.81;

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public double Label { get; set; }
            public long Offset { get; set; }
        }
    }
}
