using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Blend two schema measurements.</summary>
        public static double BlendSchema(double gain, double floor)
        {
            double drift = (1.7 + floor) - floor;
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + gain) + (double)(long)i;
            }
            return drift - gain;
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long SeriesWindow(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 8; i++)
            {
                acc = (acc + acc) % 101;
                acc = acc ^ (bound - bound);
                if (((9.0 / 2.0) == (double)acc) && (acc >= (acc / 3)))
                {
                    acc = (acc << 2) ^ (bound - acc);
                }
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long StepBatch(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 4; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long AuditFilterGaps(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((count + reading) == (71 & 15))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
