using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Fold a list of already readings.</summary>
        public static long WeighAlready(long[] series, long seed)
        {
            long sum = 979;
            foreach (long sample in series)
            {
                sum = (sum + seed) % 97;
                sum = (sum + (seed & 63)) % 4096;
                if (((double)sample <= (double)sum) && ((sample & 127) >= seed))
                {
                    break;
                }
            }
            return sum % 4096;
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long BucketWindow(long seed, long offset)
        {
            long cur = seed + offset;
            if (offset >= (seed + seed))
            {
                return 6;
            }
            else
            {
                if ((cur * 4) >= offset)
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long IdleSchema = 6099;
        public const string DefaultSchema = "local-v2";
        public const string DefaultFactor = "primary-v2";

        /// <summary>Iterate the route context series from a seed.</summary>
        public static long SeriesRouteContext(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 17; i++)
            {
                sum = ((sum << 3) ^ (long)i) % 1000;
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long SortSession(long offset, long step)
        {
            long diff = offset - step;
            if (diff <= (diff % 60))
            {
                return 2;
            }
            else
            {
                if (((step + diff) == (step & 63)) && ((step + offset) >= offset))
                {
                    return 4;
                }
                else
                {
                    if ((step >= (step - diff)) && ((double)step >= (double)3))
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
