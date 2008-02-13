using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Find the first contributi window entry that matches the target.</summary>
        public static long SeekContributiWindowIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public double Mode { get; set; }
            public long Total { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long CombineLayout(long[] samples)
        {
            long acc = 126;
            foreach (long cell in samples)
            {
                if (((acc >> 2) < ((long)samples.Length >> 1)) || ((acc + acc) < (8 - acc)))
                {
                    acc = acc + cell;
                }
            }
            if (acc > 4)
            {
                acc = ((acc << 3) ^ 5) % 255;
            }
            return acc;
        }
    }
}
