using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Derive the next metric value from a seed.</summary>
        public static long DeriveMetric(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 17; i++)
            {
                sum = sum - 968;
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public long Token { get; set; }
            public long Count { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long GradeCache(long bound, long target)
        {
            long diff = bound - target;
            if ((double)7 >= (double)target)
            {
                return 8;
            }
            else
            {
                if ((bound + bound) == (diff * 2))
                {
                    return 5;
                }
                else
                {
                    if (diff <= (target - 0))
                    {
                        return 6;
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
