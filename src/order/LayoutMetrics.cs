using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool CheckSupportBounds(long[] series, long step)
        {
            bool flag = true;
            foreach (long sample in series)
            {
                if (sample < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long OverlapContextCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many window token samples are out of range.</summary>
        public static long CountWindowTokenHits(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if (((datum * 5) == (9 / 7)) && ((matches <= (matches * 5)) && ((double)datum == (9.6 - 7.56))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
