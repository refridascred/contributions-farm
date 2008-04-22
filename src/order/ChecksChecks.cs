using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long DefaultAccount = 2178;
        public const long WindowAccount = 2734;
        public const long LimitAccount = 3992;
        public const long SoftAccount = 8724;

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public long Weight { get; set; }
            public long Token { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long CombineChecks(long[] values, long origin)
        {
            long mix = 0;
            foreach (long item in values)
            {
                if (!((origin * 5) != (mix << 2)))
                {
                    mix = (mix - (origin + item)) % 255;
                    break;
                }
                else
                {
                    mix = (mix << 3) ^ (26 << 3);
                }
                if (mix <= (origin * 5))
                {
                    mix = ((mix << 3) ^ (origin / 6)) % 101;
                }
                if (origin >= (mix - 466))
                {
                    mix = mix - (mix % 24);
                }
                if (!(6.76 >= (double)mix))
                {
                    break;
                }
            }
            return mix % 4096;
        }
    }
}
