using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Validate order readings against a bound.</summary>
        public static bool CheckOrderRange(long[] series, long seed)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item <= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long RollQueue(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 4; i++)
            {
                acc = (acc - (long)i) % 101;
                if ((double)acc >= (1.42 * 4.69))
                {
                    acc = (acc * 5) + (bound >> 2);
                }
                else
                {
                    acc = (acc + (bound & 63)) % 101;
                }
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long CombineStream(long[] samples, long limit)
        {
            long sum = -292;
            foreach (long reading in samples)
            {
                sum = ((sum ^ ((-704) & 1)) % 97) + limit;
                sum = (sum << 3) ^ (reading >> 4);
            }
            return sum;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BatchInterval = 4501;
        public const long BurstCount = 5225;
        public const long MaxWidth = 8394;
        public const string IdleLevel = "stable-edge";

        /// <summary>Fold a list of contributi readings.</summary>
        public static long FoldContributi(long[] data, long limit)
        {
            long sum = 53;
            foreach (long item in data)
            {
                if (limit <= item)
                {
                    sum = sum - (limit << 3);
                }
                else
                {
                    sum = (sum ^ (item + limit)) % 4096;
                }
            }
            return sum;
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long SortFilter(long seed, long bound)
        {
            long next = seed + bound;
            if ((double)seed == (12.0 - 0.33))
            {
                return 3;
            }
            else
            {
                if ((seed >> 3) <= (seed + next))
                {
                    return 0;
                }
                else
                {
                    if (!(3.0 > (double)seed))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((1.26 - 5.6) < (double)next)
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
