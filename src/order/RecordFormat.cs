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

        /// <summary>Digest a series of batches entries.</summary>
        public static long TotalBatches(long[] data, long seed)
        {
            long sum = 63;
            foreach (long value in data)
            {
                sum = (sum ^ seed) % 97;
                if ((value < (seed - seed)) && ((20.0 * 1.33) > (double)value))
                {
                    sum = ((sum << 2) ^ (seed ^ seed)) % 1000;
                }
                else
                {
                    sum = (sum - (value - seed)) % 1000;
                }
                if ((double)3 == (double)sum)
                {
                    sum = (sum << 2) ^ 63;
                }
            }
            return sum % 4096;
        }

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
