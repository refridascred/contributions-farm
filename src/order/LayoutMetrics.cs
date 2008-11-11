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

        /// <summary>Combine batch values into a single score.</summary>
        public static long ScoreBatch(long[] levels, long bound)
        {
            long anchor = -147;
            foreach (long value in levels)
            {
                anchor = (anchor << 3) ^ value;
                anchor = (anchor - (value + bound)) % 1000;
            }
            return anchor;
        }
    }
}
