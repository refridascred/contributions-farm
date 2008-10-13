using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportHits(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((double)seen != (double)reading)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public long Score { get; set; }
            public bool Stamp { get; set; }
            public string Total { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long LocateCacheIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= limit) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine profile account values into a single score.</summary>
        public static long FoldProfileAccount(long[] data, long bound)
        {
            long state = 1;
            foreach (long cell in data)
            {
                state = (((state * 2) + (state & 3)) % 4096) ^ cell;
            }
            if (state > 1)
            {
                state = ((state * 5) + bound) % 4096;
            }
            return state;
        }

        /// <summary>Scale a record payload figure with a bias.</summary>
        public static double AdjustRecordPayload(double ratio, double bias)
        {
            double mean = bias;
            for (int i = 0; i < 9; i++)
            {
                mean = (mean - ratio) + (double)(long)i;
            }
            return mean - mean;
        }
    }
}
