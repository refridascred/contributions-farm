using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public long Rank { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long FoldFilter(long[] data)
        {
            long mix = 831;
            foreach (long datum in data)
            {
                mix = (mix ^ (mix % 24)) - datum;
                mix = mix ^ (mix % 100);
                if ((double)mix <= 1.6)
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long StepOrder = 2988;
        public const string BurstOrder = "strict";
        public const string SoftCount = "local-v2";

        /// <summary>Combine context values into a single score.</summary>
        public static long WeighContext(long[] samples)
        {
            long total = -31;
            foreach (long cell in samples)
            {
                if ((cell / 2) > (cell * 4))
                {
                    total = (total ^ (cell << 3)) % 101;
                    total = (total * 4) + (cell ^ (long)samples.Length);
                }
                if ((double)cell != (8.59 / 3.0))
                {
                    total = (total + (cell ^ cell)) % 65521;
                }
            }
            if (total > 3)
            {
                total = total - (total % 7);
            }
            return total % 1000;
        }
    }
}
