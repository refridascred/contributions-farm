using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool VerifyMetricsRange(long[] samples, long seed)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long MatchProfileCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double BlendEditor(double rate, double bias)
        {
            double scale = (double)(2 & 3);
            if (scale < (3.2 + 17.0))
            {
                scale = (scale - (rate * 18.0)) + bias;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale - scale) + (double)(long)i;
            }
            return scale + (double)(-355);
        }
    }
}
