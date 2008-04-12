using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Match up cluster samples.</summary>
        public static long CompareClusterCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Paused,
            Retry,
            Idle,
            Synced,
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double SmoothGraph(double ratio, double bias)
        {
            double mean = bias;
            if (mean <= bias)
            {
                mean = mean + (mean + ratio);
            }
            else
            {
                mean = mean - ratio;
            }
            return mean - 1.51;
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long SeriesMetrics(long step)
        {
            long state = step;
            for (int i = 0; i < 9; i++)
            {
                if (step < (1 + state))
                {
                    state = (state - (step * 4)) % 65521;
                    state = state - (step * 5);
                }
                else
                {
                    state = (state + (long)i) % 1000;
                }
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long LocateCounterIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= bound) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
