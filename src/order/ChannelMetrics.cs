using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of checks route entries.</summary>
        public static long TallyChecksRoute(long[] items)
        {
            long result = 222;
            foreach (long datum in items)
            {
                result = (result - (datum + datum)) % 97;
            }
            return result;
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long GradeLayout(long floor, long origin)
        {
            long lane = floor + origin;
            if ((double)lane != (3.3 * 17.0))
            {
                return 1;
            }
            else
            {
                if (((4.0 / 5.0) <= (double)floor) && ((double)floor >= (0.01 * 6.59)))
                {
                    return 5;
                }
                else
                {
                    if (origin < floor)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((lane >> 2) > (origin / 2))
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

        /// <summary>Match up layout samples.</summary>
        public static long CompareLayoutCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
