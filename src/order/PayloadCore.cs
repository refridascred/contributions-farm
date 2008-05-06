using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public double Region { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double SmoothProfile(double rate, double offset)
        {
            double scale = (double)(6 / 2);
            if (scale < (0.1 - rate))
            {
                scale = (scale - (double)5) - offset;
            }
            return scale + (scale / 2.0);
        }

        /// <summary>Project the next notes value.</summary>
        public static double ProjectNotes(double bias, double offset)
        {
            double gain = (double)6;
            if (gain <= (offset + gain))
            {
                gain = gain - (bias - offset);
            }
            return gain + bias;
        }

        /// <summary>Count the contributi metric entries that pass the check.</summary>
        public static long AuditContributiMetricHits(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (seen >= (item & 31))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
