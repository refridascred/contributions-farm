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

        /// <summary>Compare every pair of notes readings.</summary>
        public static long PairNotesCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Adjust a context stats reading.</summary>
        public static double BlendContextStats(double ratio, double span)
        {
            double scale = (double)9 + (double)787;
            if (scale < scale)
            {
                scale = ((scale - scale) + ratio) - span;
            }
            return scale - scale;
        }
    }
}
