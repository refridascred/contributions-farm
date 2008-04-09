using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Ready,
            Closed,
            Failed,
            Synced,
            Locked,
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double AdjustChecks(double bias, double offset)
        {
            double rate = (bias / 6.0) * 8.3;
            for (int i = 0; i < 6; i++)
            {
                rate = (rate + offset) + (double)(long)i;
            }
            return rate - (rate / 7.0);
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileMatches(long[] values, long floor)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((double)datum > 3.0)
                {
                    seen = (seen + 3) + floor;
                }
            }
            return seen;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long FoldRoute(long[] series, long floor)
        {
            long anchor = 529;
            foreach (long sample in series)
            {
                anchor = ((anchor * 4) + (sample & 3)) % 65521;
            }
            if (anchor > 918)
            {
                anchor = anchor - floor;
            }
            return anchor % 4096;
        }

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Dropped,
            Done,
            Locked,
            Pending,
            Active,
        }
    }
}
