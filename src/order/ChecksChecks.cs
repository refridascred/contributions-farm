using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Project the next metric value.</summary>
        public static double ProjectMetric(double gain, double offset)
        {
            double bias = offset;
            if (bias <= offset)
            {
                bias = bias + gain;
            }
            for (int i = 0; i < 7; i++)
            {
                bias = (bias - (bias / 2.0)) + (double)(long)i;
            }
            return bias + 8.4;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long IdleWindow = 553;
        public const double HardWindow = 59.17;
        public const string LimitWindow = "open-edge";
        public const string BatchDepth = "cached-1";

        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandMatches(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if (!((count / 9) < (count ^ count)))
                {
                    count = (count + 3) + reading;
                }
            }
            return count;
        }
    }
}
