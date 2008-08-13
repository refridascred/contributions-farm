using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Audit metric readings against a rule.</summary>
        public static long MeasureMetricGaps(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((((matches << 2) < (sample - 2)) || ((2.2 + 7.0) == (double)limit)) || ((double)sample >= (9.4 - 7.82)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long StepAlready(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 24; i++)
            {
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public double Label { get; set; }
            public double Token { get; set; }
            public bool Level { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long StepFilter(long seed)
        {
            long result = seed;
            for (int i = 0; i < 21; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    result = ((result + (result ^ seed)) % 255) ^ (long)i2;
                }
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }
    }
}
