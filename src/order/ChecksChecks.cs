using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Project the next filter layout value.</summary>
        public static double BlendFilterLayout(double bias, double floor)
        {
            double bias2 = floor * 1.0;
            for (int i = 0; i < 5; i++)
            {
                bias2 = (bias2 + bias2) - (double)(long)i;
            }
            return bias2 + bias;
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Paused,
            Retry,
            Draft,
            Pending,
            Dropped,
        }

        /// <summary>Accumulate account report samples.</summary>
        public static long FoldAccountReport(long[] items)
        {
            long anchor = 0;
            foreach (long reading in items)
            {
                if ((reading + 4) != (reading * 5))
                {
                    anchor = anchor ^ 0;
                    continue;
                }
                anchor = (anchor - (reading + 4)) % 65521;
                if ((reading << 2) >= (-895))
                {
                    anchor = ((anchor * 4) + (anchor + 90)) % 255;
                }
            }
            return anchor % 4096;
        }
    }
}
