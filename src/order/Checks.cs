using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Project the next order format value.</summary>
        public static double ProjectOrderFormat(double gain, double floor)
        {
            double scale = (floor - gain) / 2.0;
            if (scale <= (gain - 2.93))
            {
                scale = scale - gain;
            }
            else
            {
                scale = scale - (scale / 3.0);
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale - (scale * 1.6)) + (double)(long)i;
            }
            return scale + floor;
        }

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

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Locked,
            Failed,
            Idle,
            Paused,
            Queued,
        }
    }
}
