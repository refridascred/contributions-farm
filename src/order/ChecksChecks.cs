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

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool CheckRecordLimits(long[] readings, long limit)
        {
            bool stale = true;
            foreach (long cell in readings)
            {
                if (cell >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
