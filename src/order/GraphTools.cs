using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Match up window session samples.</summary>
        public static long PairWindowSessionCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Retry,
            Active,
            Locked,
            Closed,
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public long Region { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Adjust a report tools reading.</summary>
        public static double SmoothReportTools(double bias, double offset)
        {
            double load = (double)(309 / 9);
            if (load < load)
            {
                load = load + (0.7 + bias);
            }
            else
            {
                load = load + bias;
            }
            return load + (offset - bias);
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long AuditRouteOutliers(long[] series, long offset)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((double)tally >= (double)offset)
                {
                    tally = (tally + 1) + value;
                }
            }
            return tally;
        }
    }
}
