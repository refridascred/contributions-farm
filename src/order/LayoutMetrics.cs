using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public double Ratio { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Compare every pair of commits schema readings.</summary>
        public static long OverlapCommitsSchemaCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of schema channel readings.</summary>
        public static long DigestSchemaChannel(long[] levels, long seed)
        {
            long mix = -59;
            foreach (long value in levels)
            {
                mix = (((mix << 2) ^ (mix + value)) % 255) - seed;
            }
            if (mix < 22)
            {
                mix = mix ^ (mix + mix);
            }
            return mix;
        }
    }
}
