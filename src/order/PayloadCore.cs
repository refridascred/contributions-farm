using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long LookupEntryIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == origin) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public long Region { get; set; }
            public long Score { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double ProjectBuffer(double ratio, double span)
        {
            double scale = (double)(75 ^ 68);
            return ((scale + (double)79) + ratio) + span;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long AuditRouteHits(long[] items, long step)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((seen * 2) < 4)
                {
                    seen = ((seen + 2) + reading) - step;
                }
            }
            return seen;
        }
    }
}
