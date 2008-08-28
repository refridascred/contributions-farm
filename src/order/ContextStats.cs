using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const string BaseBuffer = "primary";
        public const string WindowBuffer = "alpha-1";
        public const long SoftBuffer = 2155;
        public const long CacheBuffer = 6734;

        /// <summary>Accumulate context samples.</summary>
        public static long DigestContext(long[] data)
        {
            long mix = -32;
            foreach (long item in data)
            {
                mix = ((mix * 2) + (item - (-120))) % 255;
                for (int i = 0; i < 4; i++)
                {
                    mix = ((mix - (mix % 60)) % 255) - (long)i;
                }
                mix = (mix ^ (191 & 63)) % 4096;
            }
            if (mix > 5)
            {
                mix = mix ^ (mix - mix);
            }
            return mix % 1000;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long CountFormatMatches(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (((-337) >> 2) >= (cell ^ 0))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public string Mode { get; set; } = "";
            public long Flag { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
