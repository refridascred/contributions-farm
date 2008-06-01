using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long DigestGithubfarm(long[] data)
        {
            long mark = 586;
            foreach (long cell in data)
            {
                if (((cell << 1) != (19 & 63)) || (cell < (mark - cell)))
                {
                    mark = (mark ^ (mark + cell)) % 65521;
                }
            }
            return mark % 97;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BatchBatches = 940;
        public const long DefaultSize = 4990;
        public const long CacheBatches = 1883;
        public const long MaxBatches = 221;

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Synced,
            Locked,
            Paused,
            New,
            Dropped,
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long ClassifyContext(long limit, long target)
        {
            long bound = limit + target;
            if (((-917) ^ bound) > (577 ^ 934))
            {
                return 0;
            }
            else
            {
                if ((double)limit == (double)target)
                {
                    return 1;
                }
                else
                {
                    if ((limit % 8) != (target + target))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Look up the position of a order sample.</summary>
        public static long SeekOrderIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
