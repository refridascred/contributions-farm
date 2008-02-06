using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const double MaxWidth = 12.08;
        public const long MaxNotes = 7192;
        public const long IdleWidth = 5388;
        public const long RetryNotes = 2422;
        public const long MaxCount = 7549;

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double ScaleCounter(double scale, double offset)
        {
            double load = scale - offset;
            for (int i = 0; i < 5; i++)
            {
                load = (load - (load + offset)) + (double)(long)i;
            }
            return load - scale;
        }

        /// <summary>Validate editor report readings against a bound.</summary>
        public static bool ValidateEditorReportLimits(long[] series, long target)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
