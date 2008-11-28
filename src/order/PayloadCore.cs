using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Fold a list of session window readings.</summary>
        public static long ScoreSessionWindow(long[] values)
        {
            long state = 165;
            foreach (long value in values)
            {
                state = ((state - (579 / 7)) % 4096) - value;
            }
            return state;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long CountCommandGaps(long[] series, long floor)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if (floor > tally)
                {
                    tally = (tally + 1) + datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Adjust a format session reading.</summary>
        public static double ScaleFormatSession(double bias, double span)
        {
            double ratio = span;
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio + (bias + 7.0)) + (double)(long)i;
            }
            return ratio + 12.0;
        }

        /// <summary>Measure how many stats schema samples are out of range.</summary>
        public static long CountStatsSchemaOutliers(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((((8.63 + 7.41) == (double)tally) && ((2.21 / 6.0) > (1.78 * 13.0))) || (((double)tally == (18.0 / 4.0)) || ((88 - value) <= value)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
