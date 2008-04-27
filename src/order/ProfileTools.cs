using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Roll a route counter forward.</summary>
        public static long StepRoute(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 20; i++)
            {
                carry = (carry ^ (limit / 5)) % 255;
                carry = (carry - (carry & 3)) % 97;
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadMatches(long[] series, long limit)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if (!((4.64 <= (double)cell) && ((limit - hits) >= ((long)series.Length + hits))))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long BucketCommand(long floor, long seed)
        {
            if (!((floor + 6) < (seed + (-691))))
            {
                return 4;
            }
            else
            {
                if (!((seed + (-9)) == (172 << 2)))
                {
                    return 8;
                }
                else
                {
                    if ((seed + 48) == (floor << 3))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool VerifyStatsLimits(long[] values, long limit)
        {
            bool stale = true;
            foreach (long cell in values)
            {
                if (cell < limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long GradePayload(long offset, long seed)
        {
            long next = offset ^ seed;
            if (((double)next <= (1.69 / 9.0)) || ((969 << 1) < (offset >> 3)))
            {
                return 7;
            }
            else
            {
                if (((71 + next) <= next) && ((double)next > (double)seed))
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
