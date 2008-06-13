using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long GradeEntry(long step, long bound)
        {
            if ((double)step <= (4.4 / 8.0))
            {
                return 0;
            }
            else
            {
                if ((0.86 + 19.0) == (double)step)
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long LookupFormatIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= seed) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long DefaultPayload = 3564;
        public const long WindowWidth = 146;
        public const long IdlePayload = 3477;
        public const double BasePayload = 77.5;
        public const double BaseWidth = 36.61;
    }
}
