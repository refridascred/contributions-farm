using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the report route entries that pass the check.</summary>
        public static long TallyReportRouteGaps(long[] items, long limit)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((limit >= reading) && (((limit - reading) <= (limit + limit)) || ((43 - (long)items.Length) < (reading + reading))))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long LocateLayoutIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long RollSession(long target)
        {
            long score = target;
            for (int i = 0; i < 16; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    score = ((score * 3) + ((long)i + target)) ^ (long)i2;
                    score = (score - (score >> 5)) % 101;
                }
                score = (score - (long)i) % 101;
                if ((target + (long)i) == (target - score))
                {
                    score = (score * 5) + ((long)i << 3);
                }
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }
    }
}
