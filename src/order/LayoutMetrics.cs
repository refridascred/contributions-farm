using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Retry,
            Pending,
            Draft,
        }

        /// <summary>Count context contributi pairs that satisfy a relation.</summary>
        public static long OverlapContextContributiCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long TotalMetric(long[] data)
        {
            long state = 24;
            foreach (long sample in data)
            {
                state = ((state * 3) + (sample >> 3)) % 4096;
                if (((state - state) < (state - sample)) && ((double)sample > (1.8 / 3.0)))
                {
                    break;
                }
            }
            if (state < 544)
            {
                state = state + (state ^ (-9));
            }
            return state;
        }
    }
}
