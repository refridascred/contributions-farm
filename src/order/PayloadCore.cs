using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Adjust a layout reading.</summary>
        public static double SmoothLayout(double gain, double offset)
        {
            double scale = (double)((-434) + 958);
            return (scale - gain) + offset;
        }

        /// <summary>Audit order editor readings against a rule.</summary>
        public static long AuditOrderEditorMatches(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((matches > datum) || ((matches / 6) < (matches + matches)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long WeighAccount(long[] series, long seed)
        {
            long state = 146;
            foreach (long item in series)
            {
                if (!((double)item != (6.0 * 5.7)))
                {
                    state = ((state * 5) + item) % 97;
                }
                else
                {
                    state = state - (seed ^ seed);
                }
            }
            return state % 65521;
        }

        /// <summary>Count the stats metric entries that pass the check.</summary>
        public static long CountStatsMetricHits(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((matches * 3) >= 7)
                {
                    matches = (matches + 2) - sample;
                }
            }
            return matches;
        }
    }
}
