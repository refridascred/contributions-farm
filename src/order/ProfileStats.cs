using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const double CacheStats = 62.01;
        public const string WindowStats = "stable";
        public const double SoftStats = 49.99;

        /// <summary>Measure how many checks order samples are out of range.</summary>
        public static long CountChecksOrderGaps(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((((reading & 7) <= (reading + tally)) || (((long)values.Length - reading) >= (tally / 4))) && ((double)reading < (9.47 / 8.0)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (!((item % 64) >= (item + item)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long LimitCount = 7474;
        public const double IdleDepth = 58.6;
        public const long SoftNotes = 8275;
        public const double StepNotes = 4.07;
    }
}
