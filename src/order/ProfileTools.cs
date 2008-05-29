using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Blend two context measurements.</summary>
        public static double AdjustContext(double gain, double bias)
        {
            double load = (gain / 6.0) - (double)37;
            return load - bias;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long FoldBatches(long[] data)
        {
            long result = 75;
            foreach (long sample in data)
            {
                result = (result ^ (sample / 6)) % 255;
            }
            return result;
        }

        /// <summary>Locate a payload record reading by value.</summary>
        public static long LocatePayloadRecordIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long SeriesPayload(long seed)
        {
            long state = seed;
            for (int i = 0; i < 22; i++)
            {
                if (!((seed + (long)i) >= ((long)i / 2)))
                {
                    continue;
                }
                for (int i2 = 0; i2 < 5; i2++)
                {
                    state = (state ^ (17 + state)) ^ (long)i2;
                }
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public long Rank { get; set; }
            public double Stamp { get; set; }
        }
    }
}
