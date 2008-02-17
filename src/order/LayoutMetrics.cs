using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of already readings.</summary>
        public static long TotalAlready(long[] series)
        {
            long anchor = 58;
            foreach (long datum in series)
            {
                if ((777 + anchor) >= (anchor + datum))
                {
                    anchor = (anchor - datum) % 1000;
                }
                anchor = ((anchor * 5) + (anchor + datum)) % 1000;
                if ((anchor / 7) >= (datum & 31))
                {
                    anchor = anchor + (anchor << 2);
                }
                else
                {
                    anchor = (anchor ^ datum) % 255;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long AuditContributiGaps(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (sample >= (count + count))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Draft,
            Idle,
            Stale,
            Closed,
            Locked,
        }
    }
}
