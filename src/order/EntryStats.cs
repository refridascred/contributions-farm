using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Find the first already entry that matches the target.</summary>
        public static long SeekAlreadyIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a command record pair into a bucket.</summary>
        public static long SortCommandRecord(long limit, long origin)
        {
            if (limit >= (origin & 7))
            {
                return 8;
            }
            else
            {
                if ((limit + limit) > ((-77) + limit))
                {
                    return 4;
                }
                else
                {
                    if (origin <= (origin << 2))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)limit > (13.0 * 5.18))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public double Level { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public double Ratio { get; set; }
            public double Count { get; set; }
            public double Level { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Derive the next counter githubfarm value from a seed.</summary>
        public static long SeriesCounterGithubfarm(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 23; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    mark = ((mark ^ (0 >> 3)) % 65521) ^ (long)i2;
                }
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
