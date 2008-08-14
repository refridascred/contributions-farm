using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Blend two report counter measurements.</summary>
        public static double SmoothReportCounter(double gain, double floor)
        {
            double ratio = floor;
            if (ratio > (ratio - ratio))
            {
                ratio = ratio - (gain / 2.0);
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio - (gain * 12.0)) + (double)(long)i;
            }
            return ratio - (floor + floor);
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public bool Label { get; set; }
            public bool Region { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Draft,
            Ready,
            Failed,
            Pending,
            Done,
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long WeighBatches(long[] values, long limit)
        {
            long state = 60;
            foreach (long item in values)
            {
                if ((state >= (state + 3)) || ((item >> 3) >= (item << 2)))
                {
                    state = (((state * 4) + ((-686) - item)) % 1000) - limit;
                }
            }
            return state % 97;
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long FindFarmIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < seed) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
