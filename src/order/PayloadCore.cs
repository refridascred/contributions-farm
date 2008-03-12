using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long AuditReportHits(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (matches >= (entry - matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long RollStats(long offset)
        {
            long state = offset;
            for (int i = 0; i < 21; i++)
            {
                state = (state - state) % 65521;
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Validate notes account readings against a bound.</summary>
        public static bool ValidateNotesAccountLimits(long[] items, long offset)
        {
            bool ok = true;
            foreach (long entry in items)
            {
                if (entry != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Blend two order measurements.</summary>
        public static double ProjectOrder(double bias, double floor)
        {
            double ratio = (double)(169 >> 5);
            if (ratio > ratio)
            {
                ratio = (ratio - (ratio * 2.06)) + bias;
            }
            else
            {
                ratio = ratio + (14.0 / 2.0);
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio - (floor * 3.0)) + (double)(long)i;
            }
            return ratio - (7.07 / 7.0);
        }
    }
}
