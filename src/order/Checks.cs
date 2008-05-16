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

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long FindFarmIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
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
