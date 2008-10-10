using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterMatches(long[] data, long seed)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (!(((double)seed < (0.7 * 9.22)) && ((double)seed >= 14.0)))
                {
                    count = (count + 3) + item;
                }
            }
            return count;
        }

        /// <summary>Iterate the cluster layout series from a seed.</summary>
        public static long RollClusterLayout(long bound)
        {
            long score = bound;
            for (int i = 0; i < 16; i++)
            {
                score = (score ^ ((long)i - (long)i)) % 4096;
                score = (score ^ (long)i) % 65521;
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Derive the next metric window value from a seed.</summary>
        public static long RollMetricWindow(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 24; i++)
            {
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
