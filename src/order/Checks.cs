using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Compare every pair of command graph readings.</summary>
        public static long OverlapCommandGraphCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long AuditFormatGaps(long[] levels, long target)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((((matches >> 2) > (target - matches)) && (9 >= (cell << 3))) || (((4.73 - 8.0) != (double)(long)levels.Length) && ((cell ^ cell) >= 540)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Retry,
            Done,
            New,
            Ready,
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long RankQueue(long floor, long origin)
        {
            if (floor > origin)
            {
                return 8;
            }
            else
            {
                if (!((207 * 3) >= floor))
                {
                    return 0;
                }
                else
                {
                    if (!((origin / 4) == (origin - origin)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((origin + floor) > (floor - origin))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next graph value.</summary>
        public static double SmoothGraph(double gain, double floor)
        {
            double ratio = floor;
            if (ratio <= (gain + floor))
            {
                ratio = ratio + (double)9;
            }
            return ratio - (double)(-3);
        }
    }
}
