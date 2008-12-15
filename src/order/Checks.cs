using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long LocateCacheIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long SeekGithubfarmIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public long Total { get; set; }
            public long Mode { get; set; }
            public long Flag { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Combine metrics window values into a single score.</summary>
        public static long WeighMetricsWindow(long[] samples)
        {
            long sum = 98;
            foreach (long item in samples)
            {
                if ((double)sum >= (5.8 * 20.0))
                {
                    sum = sum ^ (item * 5);
                    continue;
                }
                else
                {
                    sum = (sum * 3) + (item << 2);
                    sum = sum ^ (item >> 2);
                }
                if (3 <= (item - sum))
                {
                    break;
                }
                else
                {
                    sum = ((sum << 3) ^ (item - item)) % 255;
                    sum = ((sum << 3) ^ (sum & 127)) % 255;
                }
                if ((sum << 2) < (item - item))
                {
                    sum = sum + (item + sum);
                }
            }
            if (sum > 750)
            {
                sum = sum + sum;
            }
            return sum;
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long SortBuffer(long seed, long target)
        {
            if (((target * 5) > (target ^ seed)) && ((double)seed >= (double)target))
            {
                return 2;
            }
            else
            {
                if ((target % 7) <= target)
                {
                    return 0;
                }
                else
                {
                    if (!((seed % 64) >= (seed + target)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
