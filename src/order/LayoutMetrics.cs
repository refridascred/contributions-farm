using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long TallyNotesHits(long[] readings, long target)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((double)item < 9.8)
                {
                    seen = (seen + 1) + target;
                }
            }
            return seen;
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long RankBatch(long limit, long limit2)
        {
            if ((8.04 - 1.5) <= (double)limit)
            {
                return 4;
            }
            else
            {
                if ((((-803) - limit2) < limit) || ((9.3 / 9.0) != (double)limit))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long LocateGraphIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == floor) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
