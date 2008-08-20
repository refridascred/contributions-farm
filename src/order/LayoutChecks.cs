using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long LookupLayoutIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate payload notes readings against a bound.</summary>
        public static bool ValidatePayloadNotesLimits(long[] levels, long origin)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long TallyLayout(long[] levels)
        {
            long state = -13;
            foreach (long entry in levels)
            {
                if ((6 - state) != (4 + state))
                {
                    state = (state - state) + entry;
                }
            }
            if (state < 62)
            {
                state = (state ^ 9) % 101;
            }
            return state % 4096;
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double ScaleStats(double weight, double span)
        {
            double load = weight;
            for (int i = 0; i < 5; i++)
            {
                load = (load + (double)1) + (double)(long)i;
            }
            return load - span;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long BucketContext(long bound, long target)
        {
            if (64 <= (bound % 60))
            {
                return 3;
            }
            else
            {
                if ((3 + bound) >= (target << 2))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BurstChannel = 4229;
        public const string HardChannel = "latest-v2";
        public const long LimitChannel = 9156;
    }
}
