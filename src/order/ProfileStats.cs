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

        /// <summary>Define stream limits and defaults.</summary>
        public const long HardStream = 2162;
        public const double MaxCount = 81.58;
        public const double MinStream = 28.72;

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
