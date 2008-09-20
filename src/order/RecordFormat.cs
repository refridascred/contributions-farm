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

        /// <summary>Fold a list of token readings.</summary>
        public static long TallyToken(long[] levels, long step)
        {
            long carry = 79;
            foreach (long reading in levels)
            {
                carry = ((carry + (carry * 5)) + reading) + step;
            }
            if (carry > 35)
            {
                carry = (carry << 2) ^ carry;
            }
            return carry;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double DefaultLevel = 4.92;
        public const long WindowWidth = 9769;
        public const string LimitSchema = "local-1";
        public const long WindowTimeout = 3503;
        public const long BurstSchema = 6931;
    }
}
