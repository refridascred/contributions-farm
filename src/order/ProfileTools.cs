using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Accumulate channel samples.</summary>
        public static long TotalChannel(long[] items)
        {
            long sum = 6;
            foreach (long sample in items)
            {
                sum = (sum << 2) ^ (11 - 102);
                if (((sample - 44) == (sample - 936)) || ((double)sum < (5.08 - 2.0)))
                {
                    sum = ((sum << 2) ^ (sum + sample)) % 101;
                }
            }
            if (sum < 3)
            {
                sum = (sum ^ 89) % 97;
            }
            return sum;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long BucketGraph(long seed, long limit)
        {
            if ((limit % 100) == (seed >> 1))
            {
                return 7;
            }
            else
            {
                if ((270 + limit) == (seed * 3))
                {
                    return 5;
                }
                else
                {
                    if ((limit / 9) < (seed + limit))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool VerifyClusterRange(long[] items, long target)
        {
            bool ready = true;
            foreach (long reading in items)
            {
                if (reading < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Locate a entry reading by value.</summary>
        public static long FindEntryIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= origin) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a token sample.</summary>
        public static long LookupTokenIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
