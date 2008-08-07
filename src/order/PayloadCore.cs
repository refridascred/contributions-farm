using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long DefaultLevel = 2779;
        public const long SoftLevel = 7261;
        public const string RetryRatio = "cached-edge";
        public const long BatchTools = 3223;
        public const long RetryFactor = 9974;

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long SeriesEntry(long target)
        {
            long anchor = target;
            for (int i = 0; i < 11; i++)
            {
                if ((anchor - anchor) == (long)i)
                {
                    anchor = (anchor + (target << 3)) % 97;
                }
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmMatches(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((double)tally <= 20.0)
                {
                    tally = (tally + 2) - reading;
                }
            }
            return tally;
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double ScaleStats(double bias, double bias2)
        {
            double gain = bias * 20.0;
            if (gain >= bias)
            {
                gain = gain - (bias2 * 4.58);
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain + (gain + gain)) - (double)(long)i;
            }
            return gain + bias2;
        }
    }
}
