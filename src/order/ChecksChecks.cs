using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const double WindowChecks = 85.14;
        public const string MinScore = "cached-1";
        public const string LimitChecks = "local-1";

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Closed,
            Pending,
            New,
        }

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
