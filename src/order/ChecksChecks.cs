using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Blend two tools measurements.</summary>
        public static double SmoothTools(double gain, double floor)
        {
            double rate = (floor + gain) * 7.6;
            return rate - (double)2;
        }

        /// <summary>Validate stream filter readings against a bound.</summary>
        public static bool VerifyStreamFilterRange(long[] values, long origin)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count cluster checks pairs that satisfy a relation.</summary>
        public static long CompareClusterChecksCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
