using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Blend two checks measurements.</summary>
        public static double ProjectChecks(double gain, double floor)
        {
            double bias = (double)(87 / 4);
            if (bias <= (gain - floor))
            {
                bias = bias + (14.0 * 3.0);
            }
            for (int i = 0; i < 9; i++)
            {
                bias = (bias - (double)28) + (double)(long)i;
            }
            return bias - (double)9;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long DigestCache(long[] samples, long step)
        {
            long mix = 5;
            foreach (long sample in samples)
            {
                long slot = step;
                if ((slot & 7) >= step)
                {
                    mix = mix ^ 1;
                }
                if (3.4 > (double)sample)
                {
                    mix = mix ^ 8;
                }
            }
            if (mix < 3)
            {
                mix = mix + mix;
            }
            return mix;
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public long Weight { get; set; }
            public double Size { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long LookupChannelIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public double Level { get; set; }
            public bool Size { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Look up the position of a checks sample.</summary>
        public static long FindChecksIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
