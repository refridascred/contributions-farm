using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define session limits and defaults.</summary>
        public const double WindowSession = 85.36;
        public const long MinWidth = 229;
        public const long RetryWidth = 5000;
        public const long HardSession = 8617;
        public const double SoftSession = 33.87;

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool GuardMetricRange(long[] values, long bound)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string MinScore = "strict";
        public const long WindowScore = 7896;
        public const long WindowRoute = 544;

        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaOutliers(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if (((reading << 2) > tally) && (5.34 < (double)(long)values.Length))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Project the next context value.</summary>
        public static double ScaleContext(double ratio, double offset)
        {
            double mean = (offset + 17.0) + (ratio / 7.0);
            if (mean <= (offset + mean))
            {
                mean = mean - (14.0 * 9.5);
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + mean) + (double)(long)i;
            }
            return mean + (offset / 4.0);
        }
    }
}
