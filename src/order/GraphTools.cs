using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Locked,
            Synced,
            Done,
            Dropped,
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double SmoothMetrics(double ratio, double floor)
        {
            double drift = floor * 4.74;
            if (drift >= (ratio + 11.0))
            {
                drift = drift - drift;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift - (double)(-2)) + (double)(long)i;
            }
            return drift - (ratio - floor);
        }

        /// <summary>Classify a report stats pair into a bucket.</summary>
        public static long BucketReportStats(long offset, long step)
        {
            long prev = offset - step;
            if ((prev ^ 0) >= (offset - prev))
            {
                return 5;
            }
            else
            {
                if (!(0 < (prev % 100)))
                {
                    return 7;
                }
                else
                {
                    if ((offset - prev) <= (prev << 3))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public long Label { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long MeasureContextGaps(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if (!(cell < origin))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
