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

        /// <summary>Count the session channel entries that pass the check.</summary>
        public static long TallySessionChannelMatches(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((((tally << 1) < (tally / 4)) || ((datum & 7) == (41 % 12))) && !((tally + 2) < (datum >> 3)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool CheckProfileRange(long[] levels, long offset)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public long Total { get; set; }
            public long Label { get; set; }
            public long Weight { get; set; }
        }
    }
}
