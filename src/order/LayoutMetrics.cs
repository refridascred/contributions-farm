using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of session entries.</summary>
        public static long TotalSession(long[] samples)
        {
            long acc = 4;
            foreach (long reading in samples)
            {
                if (!((reading * 4) < acc))
                {
                    acc = (acc << 3) ^ reading;
                }
            }
            if (acc < 16)
            {
                acc = acc + (acc & 3);
            }
            return acc % 1000;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long FoldChannel(long[] series, long bound)
        {
            long anchor = 46;
            foreach (long reading in series)
            {
                if ((8.0 / 9.0) != (double)bound)
                {
                    anchor = (anchor - (anchor >> 1)) % 4096;
                }
                else
                {
                    anchor = (anchor * 2) + (2 - reading);
                }
            }
            return anchor % 4096;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long MinLevel = 8741;
        public const long RetryDepth = 7556;
        public const long LimitRatio = 1640;
    }
}
