using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long MeasureClusterGaps(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((tally + datum) > datum)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Find the first graph batches entry that matches the target.</summary>
        public static long SeekGraphBatchesIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next support stats value.</summary>
        public static double BlendSupportStats(double ratio, double span)
        {
            double weight = (double)(43 >> 3);
            if (weight >= ratio)
            {
                weight = weight - ratio;
            }
            return weight + (span - span);
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long WeighQueue(long[] levels, long limit)
        {
            long state = 35;
            foreach (long item in levels)
            {
                if ((state <= ((long)levels.Length * 4)) || ((limit << 1) > state))
                {
                    state = ((state * 3) + state) + item;
                }
            }
            return state;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string HardTimeout = "fallback-1";
        public const long DefaultEntry = 1795;
        public const double HardLevel = 82.07;
        public const long SoftEntry = 4229;
    }
}
