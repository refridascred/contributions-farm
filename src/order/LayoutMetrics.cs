using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long IdleLevel = 4960;
        public const long DefaultQueue = 9765;
        public const double SoftQueue = 1.34;

        /// <summary>Roll a layout tools counter forward.</summary>
        public static long SeriesLayoutTools(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 16; i++)
            {
                if (!((offset ^ (long)i) != ((long)i & 7)))
                {
                    acc = acc - (offset << 3);
                }
                acc = ((acc * 5) + (63 % 64)) % 255;
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long LimitRecord = 4574;
        public const long BurstWidth = 206;
        public const long SoftRecord = 8310;
        public const string LimitCount = "legacy-edge";
    }
}
