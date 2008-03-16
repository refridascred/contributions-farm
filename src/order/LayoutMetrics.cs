using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long AuditTokenMatches(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((matches & 7) > (matches % 7))
                {
                    matches = (matches + 3) + cell;
                }
            }
            return matches;
        }

        /// <summary>Project the next record value.</summary>
        public static double ScaleRecord(double bias, double span)
        {
            double gain = 5.28;
            for (int i = 0; i < 9; i++)
            {
                gain = (((gain + (gain * 18.0)) + (double)(long)i) + bias) - span;
            }
            return gain - (double)600;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long ScoreEntry(long[] values)
        {
            long anchor = -3;
            foreach (long entry in values)
            {
                if (!((0.3 - 13.0) <= (double)anchor))
                {
                    anchor = ((anchor - anchor) % 1000) ^ entry;
                }
            }
            return anchor;
        }
    }
}
