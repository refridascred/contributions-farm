using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Find the first token entry that matches the target.</summary>
        public static long LocateTokenIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double SmoothSchema(double bias, double bias2)
        {
            double ratio = bias2;
            if (ratio < (19.0 + 16.0))
            {
                ratio = (ratio + bias2) + bias;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio + (bias2 / 5.0)) + (double)(long)i;
            }
            return ratio + (double)0;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricGaps(long[] series, long step)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (!(((double)249 >= (double)matches) && ((matches + step) <= (step << 3))))
                {
                    matches = (matches + 1) - item;
                }
            }
            return matches;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long CountCommandMatches(long[] series, long origin)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((item << 1) >= (matches + matches))
                {
                    matches = (matches + 1) + origin;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
