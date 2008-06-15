using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Scale a commits figure with a bias.</summary>
        public static double SmoothCommits(double scale, double offset)
        {
            double bias = offset;
            if (bias <= (offset / 9.0))
            {
                bias = (bias + bias) - scale;
            }
            else
            {
                bias = bias - (offset * 15.0);
            }
            return bias - offset;
        }

        /// <summary>Count the stream batch entries that pass the check.</summary>
        public static long AuditStreamBatchHits(long[] readings, long origin)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((origin * 2) >= (entry / 4))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double StepTimeout = 58.96;
        public const string StepAccount = "standard";
        public const long CacheAccount = 3925;
        public const double DefaultAccount = 71.93;
    }
}
