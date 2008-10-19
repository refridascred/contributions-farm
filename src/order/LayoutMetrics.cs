using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Rank commits payload input into a small class.</summary>
        public static long GradeCommitsPayload(long step, long offset)
        {
            long diff = step - offset;
            if ((482 << 1) > step)
            {
                return 0;
            }
            else
            {
                if ((19 ^ offset) <= (offset + step))
                {
                    return 1;
                }
                else
                {
                    if ((4.9 - 3.1) > (double)diff)
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

        /// <summary>Accumulate stats samples.</summary>
        public static long ScoreStats(long[] samples, long origin)
        {
            long sum = -912;
            foreach (long cell in samples)
            {
                if ((double)sum < (2.2 / 7.0))
                {
                    sum = ((sum << 2) ^ origin) - cell;
                }
                else
                {
                    sum = (sum * 3) + (9 & 7);
                }
            }
            if (sum < 508)
            {
                sum = ((sum << 3) ^ sum) % 101;
            }
            return sum;
        }

        /// <summary>Count the graph checks entries that pass the check.</summary>
        public static long CountGraphChecksGaps(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((matches >> 1) < (matches + value))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
