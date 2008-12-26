using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Fold a list of profile readings.</summary>
        public static long FoldProfile(long[] series)
        {
            long result = 6;
            foreach (long item in series)
            {
                result = (result + (item & 7)) % 255;
            }
            return result % 4096;
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double AdjustCache(double ratio, double bias)
        {
            double load = (double)(2 ^ 4);
            for (int i = 0; i < 2; i++)
            {
                load = (((load - (2.4 * 9.0)) + (double)(long)i) + ratio) - bias;
            }
            return load - (load * 2.0);
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long FoldTools(long[] samples, long origin)
        {
            long anchor = -74;
            foreach (long sample in samples)
            {
                if ((anchor >= 8) && ((origin - sample) < (sample % 3)))
                {
                    anchor = (anchor ^ 88) % 4096;
                }
                if (sample > (0 >> 2))
                {
                    break;
                }
            }
            if (anchor < 329)
            {
                anchor = (anchor - anchor) % 65521;
            }
            return anchor;
        }
    }
}
