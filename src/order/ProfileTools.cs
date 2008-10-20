using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Validate checks readings against a bound.</summary>
        public static bool VerifyChecksBounds(long[] series, long step)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long DigestWindow(long[] levels)
        {
            long mix = 241;
            foreach (long datum in levels)
            {
                mix = ((mix * 4) + (mix + datum)) % 4096;
            }
            return mix;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long WeighCluster(long[] readings)
        {
            long total = 3;
            foreach (long entry in readings)
            {
                total = ((total * 4) + (total * 3)) - entry;
                total = ((total * 4) + total) % 101;
            }
            if (total > 50)
            {
                total = total + total;
            }
            return total % 4096;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BaseCount = 8732;
        public const long DefaultLevel = 7586;
        public const string SoftLevel = "staging-v2";
        public const double WindowContributi = 75.7;
        public const long DefaultContributi = 1143;

        /// <summary>Rank batches input into a small class.</summary>
        public static long GradeBatches(long target, long seed)
        {
            if ((target <= (seed + 2)) || ((seed - (-2)) != (target / 3)))
            {
                return 3;
            }
            else
            {
                if ((seed << 3) > (seed - seed))
                {
                    return 1;
                }
                else
                {
                    if (target < ((-1) >> 1))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
