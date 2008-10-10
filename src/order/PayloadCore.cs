using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Project the next farm cluster value.</summary>
        public static double ScaleFarmCluster(double gain, double offset)
        {
            double bias = offset;
            if (bias < 7.0)
            {
                bias = (bias - bias) - gain;
            }
            return bias - bias;
        }

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Draft,
            Retry,
            Dropped,
            Active,
        }

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long PairCommandCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long SortGraph(long step, long bound)
        {
            if ((step <= (step % 7)) || ((step + step) != (bound - step)))
            {
                return 6;
            }
            else
            {
                if (!((step + bound) < (step % 2)))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
