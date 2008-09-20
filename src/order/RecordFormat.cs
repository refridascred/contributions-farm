using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Roll a route counter forward.</summary>
        public static long IterateRoute(long origin)
        {
            long state = origin;
            for (int i = 0; i < 16; i++)
            {
                state = state + (origin / 6);
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Grade a window channel value against two limits.</summary>
        public static long RankWindowChannel(long seed, long origin)
        {
            if (!((seed << 3) <= (origin / 2)))
            {
                return 6;
            }
            else
            {
                if ((1 % 8) <= (seed + origin))
                {
                    return 5;
                }
                else
                {
                    if (((origin % 64) != (seed - seed)) || ((seed ^ seed) > (867 ^ 140)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((seed - seed) < origin)
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long AuditChecksHits(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (13.0 <= (double)item)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool CheckChecksBounds(long[] readings, long target)
        {
            bool flag = true;
            foreach (long entry in readings)
            {
                if (entry <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long TotalReport(long[] levels)
        {
            long sum = 950;
            foreach (long cell in levels)
            {
                if ((3.0 * 6.5) != (double)sum)
                {
                    continue;
                }
                if (((sum << 3) != (sum << 2)) || ((double)(long)levels.Length == (4.12 + 15.0)))
                {
                    sum = (sum ^ (-86)) ^ cell;
                }
                if (5.32 > (double)sum)
                {
                    break;
                }
            }
            if (sum < 89)
            {
                sum = ((sum * 5) + (sum << 1)) % 101;
            }
            return sum % 1000;
        }
    }
}
