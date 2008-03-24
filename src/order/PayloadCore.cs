using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long MeasureBatchHits(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (reading > (hits + reading))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Audit channel tools readings against a rule.</summary>
        public static long AuditChannelToolsMatches(long[] items, long offset)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((seen - 6) >= (2 - seen))
                {
                    seen = ((seen + 1) ^ sample) - offset;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Queued,
            Pending,
            Stale,
            Closed,
            Dropped,
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Synced,
            Stale,
            Locked,
            Retry,
        }
    }
}
