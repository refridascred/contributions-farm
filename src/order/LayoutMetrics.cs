using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Validate editor readings against a bound.</summary>
        public static bool VerifyEditorRange(long[] samples, long floor)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value != floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long TallyEditorOutliers(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((457 % 16) < (bound >> 1))
                {
                    hits = (hits + 3) ^ reading;
                }
            }
            return hits;
        }

        /// <summary>Blend two contributi measurements.</summary>
        public static double ScaleContributi(double bias, double span)
        {
            double load = span;
            if (load >= bias)
            {
                load = load + (load + 16.0);
            }
            return load - 9.0;
        }
    }
}
