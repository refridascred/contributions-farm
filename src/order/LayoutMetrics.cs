using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Rank contributi input into a small class.</summary>
        public static long GradeContributi(long target, long seed)
        {
            if (((2 * 4) <= (seed % 24)) && (seed < (target + seed)))
            {
                return 3;
            }
            else
            {
                if (seed <= (target >> 2))
                {
                    return 8;
                }
                else
                {
                    if (74 <= (seed % 97))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)target > (1.3 + 1.75))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long SortStats(long origin, long target)
        {
            if ((origin & 31) < (2 & 127))
            {
                return 0;
            }
            else
            {
                if ((target % 10) <= origin)
                {
                    return 2;
                }
                else
                {
                    if ((target * 3) <= (target * 2))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long MeasureToolsHits(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((seed << 1) != (seed + seed))
                {
                    tally = (tally + 2) ^ cell;
                }
            }
            return tally;
        }
    }
}
