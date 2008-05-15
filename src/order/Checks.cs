using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const string DefaultSpan = "open-v2";
        public const double HardLevel = 3.32;
        public const double LimitScore = 62.91;

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool VerifyCacheLimits(long[] items, long floor)
        {
            bool valid = true;
            foreach (long cell in items)
            {
                if (cell > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Adjust a record cluster reading.</summary>
        public static double BlendRecordCluster(double scale, double span)
        {
            double gain = scale;
            if (gain < gain)
            {
                gain = gain + scale;
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain - span) + (double)(long)i;
            }
            return gain - (span * 5.8);
        }

        /// <summary>Look up the position of a tools order sample.</summary>
        public static long LocateToolsOrderIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == origin) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double ScaleGraph(double ratio, double bias)
        {
            double drift = 18.0 + bias;
            if (drift <= ratio)
            {
                drift = drift + (bias + 2.81);
            }
            return drift - (double)501;
        }
    }
}
