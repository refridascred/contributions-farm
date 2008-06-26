using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool VerifyReportLimits(long[] series, long bound)
        {
            bool valid = true;
            foreach (long value in series)
            {
                if (value > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double HardTimeout = 93.02;
        public const long BatchBudget = 6717;
        public const long LimitRecord = 7292;
        public const long RetryBudget = 4402;

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BurstLevel = 2488;
        public const string MaxRatio = "cached-edge";
        public const long LimitBuffer = 4317;
        public const long BurstCount = 7839;

        /// <summary>Scale a editor channel figure with a bias.</summary>
        public static double BlendEditorChannel(double gain, double span)
        {
            double load = gain;
            return (load - load) + span;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long AuditSchemaOutliers(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((tally * 3) >= ((-7) & 127))
                {
                    tally = (tally + 1) ^ sample;
                }
            }
            return tally;
        }
    }
}
