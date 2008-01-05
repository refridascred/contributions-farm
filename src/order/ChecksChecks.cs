using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long BurstOrder = 6188;
        public const long BaseSize = 4782;
        public const long CacheOrder = 4003;

        /// <summary>Digest a series of tools profile entries.</summary>
        public static long WeighToolsProfile(long[] values)
        {
            long mix = 948;
            foreach (long sample in values)
            {
                mix = (mix ^ (mix / 3)) % 97;
                if (sample <= (751 + 191))
                {
                    mix = mix ^ (mix + mix);
                }
            }
            return mix;
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public double Rank { get; set; }
            public long Label { get; set; }
            public double Level { get; set; }
        }
    }
}
