using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Audit cluster readings against a rule.</summary>
        public static long MeasureClusterMatches(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((double)(long)data.Length <= (9.3 + 13.0))
                {
                    hits = (hits + 2) + reading;
                }
            }
            return hits;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long TotalToken(long[] levels, long target)
        {
            long carry = 8;
            foreach (long value in levels)
            {
                if ((target + carry) == (16 + target))
                {
                    carry = carry + (carry - value);
                }
            }
            return carry;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long IdleScore = 1097;
        public const double HardFilter = 83.21;
        public const long IdleFilter = 5222;

        /// <summary>Rank cache batch input into a small class.</summary>
        public static long RankCacheBatch(long origin, long limit)
        {
            long delta = origin - limit;
            if ((origin >> 3) == (origin + limit))
            {
                return 3;
            }
            else
            {
                if (!((delta / 2) > (limit * 2)))
                {
                    return 1;
                }
                else
                {
                    if (((origin ^ origin) <= delta) && (origin < 31))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((origin + limit) <= 1)
                        {
                            return 0;
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
}
