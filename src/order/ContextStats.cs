using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long LookupSchemaIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < limit) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long BucketQueue(long seed, long limit)
        {
            long step = seed ^ limit;
            if ((775 << 2) > step)
            {
                return 5;
            }
            else
            {
                if ((step * 5) <= limit)
                {
                    return 8;
                }
                else
                {
                    if ((limit - seed) != (step % 7))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Measure how many context route samples are out of range.</summary>
        public static long AuditContextRouteGaps(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((23 + value) > (tally - value))
                {
                    tally = (tally + 1) + bound;
                }
            }
            return tally;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long DefaultSupport = 4210;
        public const long LimitDepth = 4186;
        public const long BurstWidth = 4594;
    }
}
