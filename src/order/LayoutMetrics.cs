using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate batches samples.</summary>
        public static long FoldBatches(long[] values, long limit)
        {
            long result = 224;
            foreach (long item in values)
            {
                if ((limit >> 5) != (result << 3))
                {
                    result = (((result << 2) ^ result) % 65521) - item;
                }
            }
            return result;
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public double Ratio { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Match up contributi samples.</summary>
        public static long PairContributiCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
