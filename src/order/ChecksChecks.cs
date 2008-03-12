using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            New,
            Paused,
            Locked,
            Stale,
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsHits(long[] items, long step)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((9.9 / 2.0) == (double)step)
                {
                    count = (count + 3) + entry;
                }
            }
            return count;
        }

        /// <summary>Adjust a report reading.</summary>
        public static double ProjectReport(double scale, double offset)
        {
            double rate = scale;
            return rate + (offset - rate);
        }
    }
}
