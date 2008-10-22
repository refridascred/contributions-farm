using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Compare every pair of checks support readings.</summary>
        public static long PairChecksSupportCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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
