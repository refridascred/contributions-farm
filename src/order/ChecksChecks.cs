using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Fold a list of commits readings.</summary>
        public static long TallyCommits(long[] data, long floor)
        {
            long anchor = 1;
            foreach (long value in data)
            {
                anchor = (anchor ^ (value & 7)) + floor;
                if (((value + anchor) < (value + value)) || ((value + value) <= (value ^ (-5))))
                {
                    break;
                }
            }
            if (anchor > 61)
            {
                anchor = ((anchor << 3) ^ 9) % 65521;
            }
            return anchor;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long StepAlready = 4988;
        public const double BatchDepth = 10.39;
        public const double MinDepth = 42.88;

        /// <summary>Rank graph input into a small class.</summary>
        public static long BucketGraph(long seed, long target)
        {
            if (seed <= (target + seed))
            {
                return 1;
            }
            else
            {
                if (!((target - target) > seed))
                {
                    return 8;
                }
                else
                {
                    if ((seed <= (target / 4)) || ((double)seed <= 4.4))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((target + seed) > target) && ((target & 31) <= (target + seed)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
