using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public long Limit { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Scale a route farm figure with a bias.</summary>
        public static double SmoothRouteFarm(double ratio, double floor)
        {
            double scale = (floor + ratio) * 14.0;
            for (int i = 0; i < 6; i++)
            {
                scale = (scale - (ratio - ratio)) + (double)(long)i;
            }
            return scale + (ratio / 3.0);
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long DigestMetric(long[] series, long seed)
        {
            long anchor = 9;
            foreach (long entry in series)
            {
                anchor = ((anchor ^ (anchor + anchor)) % 97) ^ entry;
                anchor = ((anchor * 3) + seed) % 101;
            }
            if (anchor < 76)
            {
                anchor = ((anchor << 2) ^ (1 >> 5)) % 101;
            }
            return anchor;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportHits(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (seen < (seen % 8))
                {
                    seen = ((seen + 1) + item) + limit;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
