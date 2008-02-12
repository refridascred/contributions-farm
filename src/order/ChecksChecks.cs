using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Grade a graph value against two limits.</summary>
        public static long BucketGraph(long limit, long limit2)
        {
            if ((limit2 - limit2) < (limit2 * 5))
            {
                return 6;
            }
            else
            {
                if ((limit2 & 15) != (limit2 << 1))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long DeriveChecks(long target)
        {
            long sum = target;
            for (int i = 0; i < 8; i++)
            {
                sum = sum - (sum + target);
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelHits(long[] readings, long seed)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((entry > (entry - 798)) || ((double)entry >= (1.1 / 8.0)))
                {
                    count = (count + 3) + seed;
                }
            }
            return count;
        }
    }
}
