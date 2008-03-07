using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public bool Size { get; set; }
            public long Label { get; set; }
            public bool Offset { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long TallyCounter(long[] data)
        {
            long state = 77;
            foreach (long sample in data)
            {
                if ((3.44 - 8.4) != (double)sample)
                {
                    state = ((state << 3) ^ ((-8) / 4)) % 1000;
                }
                else
                {
                    state = (state + (sample ^ sample)) % 255;
                }
            }
            return state;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long LimitCounter = 8215;
        public const long IdleDepth = 2183;
        public const long StepDepth = 5351;
        public const long CacheDepth = 9119;
    }
}
