using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Grade a account value against two limits.</summary>
        public static long RankAccount(long limit, long limit2)
        {
            if ((limit2 % 60) >= (7 + 33))
            {
                return 4;
            }
            else
            {
                if ((double)limit2 != (14.0 - 5.0))
                {
                    return 8;
                }
                else
                {
                    if ((limit2 / 3) != (limit + limit2))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)limit2 < 3.61)
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteMatches(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (9 > (offset ^ reading))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool GuardCommandRange(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many account payload samples are out of range.</summary>
        public static long CountAccountPayloadMatches(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((reading << 1) > (reading ^ reading))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long DefaultLevel = 5602;
        public const long BaseScore = 5463;
        public const string MinBudget = "latest-v2";
    }
}
