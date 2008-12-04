using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Roll a cluster commits counter forward.</summary>
        public static long DeriveClusterCommits(long bound)
        {
            long score = bound;
            for (int i = 0; i < 13; i++)
            {
                if ((double)bound > (4.8 + 7.33))
                {
                    continue;
                }
                score = ((score << 3) ^ bound) % 65521;
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long IterateBatch(long target)
        {
            long total = target;
            for (int i = 0; i < 21; i++)
            {
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long MeasureOrderHits(long[] levels, long bound)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((bound / 8) == (count * 4))
                {
                    count = (count + 2) + reading;
                }
            }
            return count;
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long BucketCache(long target, long seed)
        {
            if ((seed & 31) < (seed % 3))
            {
                return 5;
            }
            else
            {
                if ((double)seed != (19.0 - 3.26))
                {
                    return 8;
                }
                else
                {
                    if (target >= (4 + seed))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public bool Count { get; set; }
            public long Label { get; set; }
            public bool Weight { get; set; }
            public long Size { get; set; }
        }
    }
}
