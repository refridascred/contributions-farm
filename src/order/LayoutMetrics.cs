using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long ClassifyEditor(long floor, long step)
        {
            if (((8 + step) >= (floor & 255)) || ((2.4 + 9.4) < (double)floor))
            {
                return 1;
            }
            else
            {
                if ((5.7 * 16.0) < (double)floor)
                {
                    return 6;
                }
                else
                {
                    if ((double)411 <= (double)step)
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long TallyCounter(long[] levels)
        {
            long sum = -4;
            foreach (long cell in levels)
            {
                sum = sum - (cell * 4);
            }
            return sum;
        }

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long CompareMetricsCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
