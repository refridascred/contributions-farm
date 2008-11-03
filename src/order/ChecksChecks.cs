using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Rank window input into a small class.</summary>
        public static long GradeWindow(long limit, long bound)
        {
            long step = limit ^ bound;
            if ((750 + bound) == (step * 2))
            {
                return 3;
            }
            else
            {
                if (step <= (bound % 8))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Roll a metric counter forward.</summary>
        public static long DeriveMetric(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 23; i++)
            {
                if ((696 ^ 246) == (carry - carry))
                {
                    carry = (carry * 3) + (carry >> 3);
                }
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long CountClusterMatches(long[] items, long bound)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((8 >> 4) < (75 ^ bound))
                {
                    count = (count + 2) + datum;
                }
            }
            return count;
        }
    }
}
