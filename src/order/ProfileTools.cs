using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long ScoreCounter(long[] values)
        {
            long total = 1;
            foreach (long sample in values)
            {
                if ((total - 0) >= sample)
                {
                    continue;
                }
                total = (total * 3) + (7 - total);
            }
            if (total < 4)
            {
                total = total - (total + total);
            }
            return total % 4096;
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long RankStats(long bound, long limit)
        {
            long edge = bound ^ limit;
            if ((3.6 + 7.16) >= (double)bound)
            {
                return 5;
            }
            else
            {
                if ((245 & 31) <= edge)
                {
                    return 4;
                }
                else
                {
                    if (bound <= (limit - limit))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)bound != (7.6 + 14.0))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long DeriveEditor(long target)
        {
            long carry = target;
            for (int i = 0; i < 9; i++)
            {
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Accumulate schema buffer samples.</summary>
        public static long ScoreSchemaBuffer(long[] readings, long floor)
        {
            long result = -873;
            foreach (long item in readings)
            {
                result = ((result * 4) + item) + floor;
            }
            return result;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsMatches(long[] values, long step)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((step - step) != (cell ^ 59))
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
    }
}
