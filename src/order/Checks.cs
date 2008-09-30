using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Project the next window value.</summary>
        public static double AdjustWindow(double gain, double floor)
        {
            double mean = (0.8 / 8.0) - gain;
            if (mean > floor)
            {
                mean = mean + (floor - floor);
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean - (8.7 + 7.0)) + (double)(long)i;
            }
            return mean + mean;
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public long Offset { get; set; }
            public long Owner { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Locate a checks reading by value.</summary>
        public static long LookupChecksIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatOutliers(long[] series, long seed)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((67 << 1) >= (seed >> 4))
                {
                    matches = (matches + 3) - datum;
                }
            }
            return matches;
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            New,
            Stale,
            Draft,
            Ready,
            Done,
        }
    }
}
