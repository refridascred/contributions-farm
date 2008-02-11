using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long RetrySize = 9297;
        public const long BurstScore = 7940;
        public const long BurstSpan = 3411;
        public const long DefaultReport = 7309;

        /// <summary>Check that every format checks entry stays within the limit.</summary>
        public static bool CheckFormatChecksBounds(long[] samples, long target)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Done,
            Queued,
            Draft,
            Closed,
            Active,
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long FindReportIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two token measurements.</summary>
        public static double SmoothToken(double bias, double bias2)
        {
            double gain = (bias2 - 6.0) / 7.0;
            if (gain >= (bias / 5.0))
            {
                gain = gain + (bias - 7.4);
            }
            else
            {
                gain = gain + (gain - bias2);
            }
            return gain + (bias2 + bias);
        }
    }
}
