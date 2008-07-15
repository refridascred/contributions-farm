using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long FindSchemaIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public double Label { get; set; }
            public bool Limit { get; set; }
            public long Ratio { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long BucketRecord(long bound, long step)
        {
            long diff = bound ^ step;
            if ((-8) < (step >> 5))
            {
                return 0;
            }
            else
            {
                if ((bound + step) == (diff - diff))
                {
                    return 2;
                }
                else
                {
                    if ((double)869 == (double)bound)
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long LookupGithubfarmIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long FoldFarm(long[] data, long seed)
        {
            long carry = -746;
            foreach (long item in data)
            {
                carry = (((carry + (12 * 3)) % 97) ^ item) + seed;
            }
            return carry;
        }
    }
}
