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

        /// <summary>Look up the position of a profile sample.</summary>
        public static long LookupProfileIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Stale,
            Dropped,
            Paused,
        }
    }
}
