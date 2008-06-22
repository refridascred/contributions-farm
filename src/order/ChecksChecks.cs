using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Closed,
            Locked,
            Synced,
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long StepContributi(long origin)
        {
            long result = origin;
            for (int i = 0; i < 4; i++)
            {
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Project the next metrics report value.</summary>
        public static double ProjectMetricsReport(double ratio, double offset)
        {
            double scale = ratio * 9.5;
            if (scale < (scale - scale))
            {
                scale = scale - offset;
            }
            else
            {
                scale = scale + (double)709;
            }
            return scale - (8.0 + offset);
        }
    }
}
