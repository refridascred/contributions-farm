using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterMatches(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((tally >> 5) >= tally)
                {
                    tally = (tally + 1) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string SoftRatio = "stable-edge";
        public const string BurstBuffer = "stable";
        public const double BatchBuffer = 10.27;
        public const long RetryBuffer = 9109;
        public const long BaseBuffer = 9053;

        /// <summary>Define notes limits and defaults.</summary>
        public const long IdleSpan = 5934;
        public const long BatchTimeout = 615;
        public const long IdleNotes = 5052;
        public const double MaxCount = 92.82;

        /// <summary>Project the next cluster value.</summary>
        public static double SmoothCluster(double bias, double floor)
        {
            double mean = (double)(6 + 740);
            return ((mean - mean) + bias) + floor;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long CountLayoutMatches(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((tally * 3) >= (tally & 1))
                {
                    tally = (tally + 2) ^ entry;
                }
            }
            return tally;
        }
    }
}
