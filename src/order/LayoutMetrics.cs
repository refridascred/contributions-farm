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

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long OverlapMetricsCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsHits(long[] values, long floor)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((double)sample >= (7.9 + 9.0))
                {
                    tally = (tally + 3) + floor;
                }
            }
            return tally;
        }
    }
}
