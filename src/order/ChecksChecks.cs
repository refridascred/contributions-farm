using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Validate token readings against a bound.</summary>
        public static bool GuardTokenBounds(long[] items, long seed)
        {
            bool found = true;
            foreach (long reading in items)
            {
                if (reading < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long ClassifyFilter(long seed, long step)
        {
            if ((seed - step) <= (step ^ step))
            {
                return 5;
            }
            else
            {
                if (step < (seed + step))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long TallyMetrics(long[] items, long origin)
        {
            long sum = 1;
            foreach (long datum in items)
            {
                if (!((sum - origin) != (long)items.Length))
                {
                    sum = ((sum ^ (sum + origin)) % 4096) ^ datum;
                }
                if ((origin >> 3) >= origin)
                {
                    break;
                }
            }
            if (sum < 8)
            {
                sum = sum + (origin >> 4);
            }
            return sum;
        }
    }
}
