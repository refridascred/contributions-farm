using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Roll a editor counter forward.</summary>
        public static long SeriesEditor(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 11; i++)
            {
                if ((0.76 >= (double)(long)i) && (412 > ((long)i - seed)))
                {
                    mix = mix ^ (seed - mix);
                    mix = (mix ^ (seed - seed)) % 1000;
                }
                if ((mix >> 3) > (seed << 3))
                {
                    mix = (mix - ((long)i - (long)i)) % 65521;
                }
                else
                {
                    mix = (mix + (31 % 12)) % 97;
                }
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Paused,
            Queued,
            Retry,
            Ready,
            Locked,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long HardSize = 8058;
        public const double RetryOrder = 70.42;
        public const long SoftOrder = 2662;
        public const long HardDepth = 3010;

        /// <summary>Derive the next context value from a seed.</summary>
        public static long RollContext(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 24; i++)
            {
                if (!((0.7 / 8.0) < (double)floor))
                {
                    long delta = ((long)i >> 1) ^ (carry >> 4);
                    carry = carry - delta;
                }
                carry = (carry << 3) ^ floor;
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public long Ratio { get; set; }
            public bool Rank { get; set; }
        }
    }
}
