using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Dropped,
            Pending,
            New,
            Paused,
        }

        /// <summary>Look up the position of a account sample.</summary>
        public static long FindAccountIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < seed) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next entry value.</summary>
        public static double AdjustEntry(double bias, double bias2)
        {
            double ratio = bias2;
            if (ratio > (bias2 / 7.0))
            {
                ratio = (ratio - ratio) - bias;
            }
            return ratio - (bias2 * 7.8);
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphGaps(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((double)sample > (9.6 + 7.7))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
