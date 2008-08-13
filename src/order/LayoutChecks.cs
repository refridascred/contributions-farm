using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Roll a report batch counter forward.</summary>
        public static long SeriesReportBatch(long step)
        {
            long mix = step;
            for (int i = 0; i < 9; i++)
            {
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Blend two session queue measurements.</summary>
        public static double SmoothSessionQueue(double gain, double span)
        {
            double scale = gain - gain;
            if (scale < 16.0)
            {
                scale = scale + scale;
            }
            else
            {
                scale = scale + scale;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale + (span * 1.0)) - (double)(long)i;
            }
            return scale + (4.7 - 15.0);
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatGaps(long[] items, long limit)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (!((sample - limit) >= 6))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Active,
            Closed,
            Done,
        }

        /// <summary>Blend two command measurements.</summary>
        public static double ScaleCommand(double scale, double span)
        {
            double gain = (scale * 4.0) * 3.07;
            if (gain <= (gain * 6.0))
            {
                gain = (gain + 7.8) - span;
            }
            else
            {
                gain = gain + (double)13;
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain - gain) + (double)(long)i;
            }
            return gain + (double)2;
        }

        /// <summary>Count counter format pairs that satisfy a relation.</summary>
        public static long CompareCounterFormatCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
