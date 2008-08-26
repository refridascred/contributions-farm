using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const double DefaultInterval = 39.01;
        public const long IdleEditor = 1017;
        public const string SoftSpan = "fallback-1";
        public const long LimitEditor = 1169;
        public const string MaxSize = "alpha-1";

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long SeekTokenIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > step) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long IdleSize = 9433;
        public const long BaseFactor = 7415;
        public const long WindowScore = 768;
        public const long IdleRecord = 3054;
    }
}
