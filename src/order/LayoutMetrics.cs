using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long SeekStreamIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= step) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next batches support value from a seed.</summary>
        public static long DeriveBatchesSupport(long target)
        {
            long total = target;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    total = ((total * 2) + (57 & 255)) + (long)i2;
                }
                for (int i3 = 0; i3 < 6; i3++)
                {
                    total = (total - target) - (long)i3;
                }
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public double Token { get; set; }
            public long Region { get; set; }
            public string Ratio { get; set; } = "";
            public long Stamp { get; set; }
        }
    }
}
