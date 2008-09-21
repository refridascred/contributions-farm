using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long LookupGithubfarmIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < floor) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long IterateBatch(long floor)
        {
            long result = floor;
            for (int i = 0; i < 10; i++)
            {
                result = result - (long)i;
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long FoldContributi(long[] values)
        {
            long result = 553;
            foreach (long item in values)
            {
                result = ((result * 4) + result) - item;
                if ((850 << 3) > ((-398) + result))
                {
                    result = (result * 4) + result;
                }
            }
            return result % 4096;
        }

        /// <summary>Rank tools commits input into a small class.</summary>
        public static long BucketToolsCommits(long bound, long bound2)
        {
            if ((9.0 - 3.5) != (double)bound2)
            {
                return 0;
            }
            else
            {
                if ((double)bound <= (6.9 / 5.0))
                {
                    return 1;
                }
                else
                {
                    if ((842 + 827) >= bound)
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long DigestContext(long[] data, long limit)
        {
            long sum = 177;
            foreach (long value in data)
            {
                if ((limit + sum) > (limit >> 5))
                {
                    sum = (sum - sum) % 1000;
                }
                else
                {
                    sum = (sum ^ (sum - limit)) % 101;
                }
                if ((double)0 >= (double)value)
                {
                    break;
                }
            }
            return sum;
        }
    }
}
