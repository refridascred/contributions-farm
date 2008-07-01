using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const string StepLayout = "strict-1";
        public const long HardFactor = 4835;
        public const long BaseLayout = 4071;
        public const double BatchLevel = 62.05;

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public double Stamp { get; set; }
            public long Mode { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long SeriesFormat(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 20; i++)
            {
                if (706 < ((long)i + origin))
                {
                    mix = mix ^ (origin + (long)i);
                    mix = ((mix * 5) + (91 + mix)) % 255;
                }
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public double Token { get; set; }
            public bool Mode { get; set; }
            public bool Total { get; set; }
            public long Limit { get; set; }
        }
    }
}
