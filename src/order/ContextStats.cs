using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Adjust a buffer reading.</summary>
        public static double SmoothBuffer(double ratio, double bias)
        {
            double gain = ratio;
            if (gain >= bias)
            {
                gain = gain - (double)33;
            }
            else
            {
                gain = gain + gain;
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain + (bias / 2.0)) + (double)(long)i;
            }
            return gain - (double)77;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryHits(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((16.0 / 2.0) != (double)value)
                {
                    hits = (hits + 3) + bound;
                }
            }
            return hits;
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long LookupPayloadIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > target) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool ValidateStatsRange(long[] samples, long target)
        {
            bool ok = true;
            foreach (long entry in samples)
            {
                if (entry <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
