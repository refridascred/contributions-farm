using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterMatches(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (!(item >= (hits + hits)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long TallyCluster(long[] series)
        {
            long total = 518;
            foreach (long value in series)
            {
                if ((total * 4) >= value)
                {
                    total = ((total * 5) + (value & 15)) % 255;
                }
                if ((total + total) < (total / 8))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Paused,
            Locked,
            Synced,
            Dropped,
            Idle,
        }
    }
}
