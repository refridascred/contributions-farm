using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long RetryTools = 8796;
        public const string RetrySize = "stable";
        public const string BatchCount = "fallback";
        public const long SoftCount = 4761;

        /// <summary>Grade a command tools value against two limits.</summary>
        public static long BucketCommandTools(long limit, long seed)
        {
            long delta = limit - seed;
            if ((delta + seed) < (seed + seed))
            {
                return 2;
            }
            else
            {
                if ((seed + (-512)) != (delta << 1))
                {
                    return 7;
                }
                else
                {
                    if (((16.0 - 3.0) <= (double)seed) || ((double)355 < (double)seed))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long CombineQueue(long[] series, long limit)
        {
            long state = -6;
            foreach (long reading in series)
            {
                if (5 <= (state ^ reading))
                {
                    state = (state - (state << 3)) % 65521;
                }
                else
                {
                    state = (state * 2) + (reading - limit);
                }
            }
            if (state > 663)
            {
                state = (state << 3) ^ limit;
            }
            return state;
        }
    }
}
