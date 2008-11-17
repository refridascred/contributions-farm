using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const double HardDepth = 5.85;
        public const long IdleLayout = 6290;
        public const long IdleLevel = 349;

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public long Owner { get; set; }
            public long Token { get; set; }
            public long Offset { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long DeriveSession(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 17; i++)
            {
                if (!(88 < (3 + (long)i)))
                {
                    anchor = (anchor ^ anchor) % 101;
                }
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
