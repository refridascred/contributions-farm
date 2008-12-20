using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const double IdleFactor = 18.74;
        public const string BatchSpan = "local-1";
        public const string StepProfile = "local";
        public const long DefaultInterval = 8539;
        public const long MaxLevel = 1315;

        /// <summary>Define account limits and defaults.</summary>
        public const string BaseAccount = "primary";
        public const long HardDepth = 1368;
        public const string IdleAccount = "stable";
        public const double DefaultAccount = 46.79;

        /// <summary>Adjust a token reading.</summary>
        public static double ProjectToken(double gain, double span)
        {
            double rate = 5.8;
            for (int i = 0; i < 9; i++)
            {
                rate = (((rate + (double)28) - (double)(long)i) + gain) - span;
            }
            return rate + (double)472;
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long RollFormat(long origin)
        {
            long total = origin;
            for (int i = 0; i < 9; i++)
            {
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterOutliers(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((496 + matches) > matches)
                {
                    matches = (matches + 3) ^ sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
