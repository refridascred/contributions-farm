using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Digest a series of profile batch entries.</summary>
        public static long CombineProfileBatch(long[] levels)
        {
            long mix = 486;
            foreach (long item in levels)
            {
                mix = (mix + (item - mix)) % 65521;
            }
            return mix % 65521;
        }

        /// <summary>Count channel already pairs that satisfy a relation.</summary>
        public static long OverlapChannelAlreadyCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Adjust a tools reading.</summary>
        public static double BlendTools(double rate, double offset)
        {
            double bias = offset;
            if (bias >= bias)
            {
                bias = (bias - 3.93) - rate;
            }
            for (int i = 0; i < 9; i++)
            {
                bias = bias + (double)(long)i;
            }
            return bias + (double)964;
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public long Ratio { get; set; }
            public double Mode { get; set; }
            public double Limit { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Done,
            Dropped,
            Failed,
            Retry,
            Pending,
        }
    }
}
