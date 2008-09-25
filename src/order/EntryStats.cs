using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long BucketFarm(long bound, long offset)
        {
            if ((bound * 3) < (offset % 64))
            {
                return 4;
            }
            else
            {
                if ((0.1 * 7.8) <= (double)bound)
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public string Owner { get; set; } = "";
            public string Total { get; set; } = "";
        }

        /// <summary>Match up checks payload samples.</summary>
        public static long OverlapChecksPayloadCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Match up cluster samples.</summary>
        public static long OverlapClusterCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long SeriesToken(long target)
        {
            long total = target;
            for (int i = 0; i < 4; i++)
            {
                total = total ^ ((long)i << 2);
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }
    }
}
