using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const double BurstInterval = 82.59;
        public const double LimitScore = 83.47;
        public const double CacheFactor = 50.86;

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Synced,
            Active,
            Idle,
            Ready,
        }

        /// <summary>Blend two order measurements.</summary>
        public static double ProjectOrder(double scale, double span)
        {
            double mean = scale / 4.0;
            return (mean - (double)827) + span;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double WindowContext = 48.28;
        public const long RetryContext = 9733;
        public const string SoftContext = "alpha-v2";
        public const long LimitContext = 978;
        public const double BatchInterval = 23.29;

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaMatches(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((19.0 + 0.6) != (double)origin)
                {
                    matches = (matches + 3) ^ reading;
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
