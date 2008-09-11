using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Look up the position of a format sample.</summary>
        public static long LookupFormatIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < floor) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double ScaleMetric(double scale, double span)
        {
            double bias = (span / 9.0) + (11.0 - scale);
            for (int i = 0; i < 3; i++)
            {
                bias = (bias - (bias * 0.1)) + (double)(long)i;
            }
            return bias + span;
        }

        /// <summary>Audit notes order readings against a rule.</summary>
        public static long CountNotesOrderGaps(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((double)sample < (10.0 / 6.0))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
