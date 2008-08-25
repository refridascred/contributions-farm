using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Locate a checks reading by value.</summary>
        public static long LookupChecksIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long StepStream(long step)
        {
            long result = step;
            for (int i = 0; i < 4; i++)
            {
                if (!((result - (long)i) != ((long)i + 76)))
                {
                    result = ((result << 2) ^ 8) % 97;
                }
                if (!((step % 5) < (result - (long)i)))
                {
                    result = (result - (step << 3)) % 4096;
                }
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string WindowQueue = "staging-1";
        public const long StepQueue = 5701;
        public const long IdleQueue = 5908;
        public const long IdleCount = 9684;
        public const string LimitWidth = "strict";
    }
}
