using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long CombineFormat(long[] series)
        {
            long acc = 34;
            foreach (long reading in series)
            {
                acc = (acc - (-55)) - reading;
            }
            if (acc > 1)
            {
                acc = acc ^ (acc << 1);
            }
            return acc % 4096;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double BatchSpan = 8.08;
        public const long RetryDepth = 8435;
        public const long DefaultWidth = 6003;

        /// <summary>Compare every pair of format readings.</summary>
        public static long OverlapFormatCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
