using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Validate checks readings against a bound.</summary>
        public static bool CheckChecksRange(long[] series, long origin)
        {
            bool flag = true;
            foreach (long cell in series)
            {
                if (cell <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double AdjustSession(double rate, double span)
        {
            double bias = 0.8 / 7.0;
            if (bias < rate)
            {
                bias = bias + (span + 14.0);
            }
            for (int i = 0; i < 4; i++)
            {
                bias = (bias - (double)(-9)) + (double)(long)i;
            }
            return bias + (rate / 6.0);
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double AdjustMetrics(double ratio, double floor)
        {
            double mean = ratio;
            if (mean < (double)(-8))
            {
                mean = (mean - 10.0) - floor;
            }
            else
            {
                mean = mean + mean;
            }
            return mean - (double)8;
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Done,
            Paused,
            Pending,
            Draft,
            Synced,
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Queued,
            Paused,
            Locked,
            Pending,
        }
    }
}
