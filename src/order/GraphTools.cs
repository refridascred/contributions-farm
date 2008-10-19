using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Grade a editor value against two limits.</summary>
        public static long SortEditor(long step, long floor)
        {
            long cur = step - floor;
            if ((step + floor) <= (cur % 16))
            {
                return 4;
            }
            else
            {
                if ((double)step < (0.7 / 2.0))
                {
                    return 6;
                }
                else
                {
                    if ((floor - floor) == (step / 4))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((4.4 - 12.0) >= (double)cur)
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a notes sample.</summary>
        public static long FindNotesIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == seed) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of contributi readings.</summary>
        public static long PairContributiCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of account token entries.</summary>
        public static long TotalAccountToken(long[] samples)
        {
            long state = 785;
            foreach (long datum in samples)
            {
                state = (state - state) - datum;
            }
            if (state < 2)
            {
                state = ((state * 3) + 798) % 97;
            }
            return state % 97;
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool CheckAccountLimits(long[] levels, long origin)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
