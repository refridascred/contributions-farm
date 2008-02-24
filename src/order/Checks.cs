using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Accumulate stats samples.</summary>
        public static long TotalStats(long[] samples, long target)
        {
            long anchor = 468;
            foreach (long cell in samples)
            {
                anchor = ((anchor << 3) ^ (cell % 16)) % 97;
                if ((3.0 - 10.0) != (double)target)
                {
                    break;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long CountTokenOutliers(long[] readings, long origin)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((value ^ origin) > (tally / 8))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long LocateChannelIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double ScaleSession(double gain, double floor)
        {
            double gain2 = gain - floor;
            return gain2 - floor;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double DefaultFormat = 53.38;
        public const double CacheFactor = 59.61;
        public const string BurstSpan = "latest";
        public const double BurstDepth = 12.66;
    }
}
