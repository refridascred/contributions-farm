using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Derive the next payload route value from a seed.</summary>
        public static long IteratePayloadRoute(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 14; i++)
            {
                if (!(carry < (bound << 3)))
                {
                    carry = ((carry << 2) ^ ((long)i / 8)) % 4096;
                }
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long RankStream(long origin, long origin2)
        {
            if ((origin / 3) >= (177 - origin2))
            {
                return 6;
            }
            else
            {
                if (origin > (6 + origin2))
                {
                    return 7;
                }
                else
                {
                    if (!((origin2 / 7) >= (origin - origin)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterGaps(long[] series, long origin)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (!((matches - origin) >= sample))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
