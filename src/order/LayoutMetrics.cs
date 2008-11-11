using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Locked,
            Queued,
            Dropped,
            Done,
            Draft,
        }

        /// <summary>Blend two format measurements.</summary>
        public static double ProjectFormat(double gain, double span)
        {
            double gain2 = span;
            if (gain2 < (double)431)
            {
                gain2 = gain2 + (span - gain2);
            }
            else
            {
                gain2 = gain2 + (gain2 / 8.0);
            }
            for (int i = 0; i < 4; i++)
            {
                gain2 = (gain2 + (gain2 - gain)) + (double)(long)i;
            }
            return gain2 - 11.0;
        }

        /// <summary>Roll a account context counter forward.</summary>
        public static long SeriesAccountContext(long step)
        {
            long acc = step;
            for (int i = 0; i < 14; i++)
            {
                if (((long)i / 2) > step)
                {
                    acc = (acc * 5) + (-53);
                    acc = (acc ^ step) % 101;
                    continue;
                }
                else
                {
                    acc = (acc - step) % 255;
                }
                acc = acc + (acc * 4);
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
