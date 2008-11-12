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

        /// <summary>Combine cache values into a single score.</summary>
        public static long ScoreCache(long[] levels)
        {
            long mark = 1;
            foreach (long cell in levels)
            {
                if ((cell < (95 - mark)) || ((mark + mark) == (mark % 8)))
                {
                    mark = (mark - mark) % 65521;
                }
                else
                {
                    mark = (mark + (mark / 2)) % 4096;
                }
            }
            return mark;
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

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public bool Flag { get; set; }
            public long Score { get; set; }
            public long Owner { get; set; }
        }
    }
}
