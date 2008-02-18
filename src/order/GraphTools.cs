using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const string BaseInterval = "open";
        public const double HardCache = 15.37;
        public const double LimitCache = 8.62;
        public const long BaseCache = 2496;
        public const long WindowCache = 5469;

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchMatches(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (!((860 + item) == (item ^ item)))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of payload schema entries.</summary>
        public static long CombinePayloadSchema(long[] items, long offset)
        {
            long anchor = -33;
            foreach (long sample in items)
            {
                anchor = (((anchor * 3) + sample) % 1000) + offset;
                if (!((double)anchor < (1.2 - 6.53)))
                {
                    break;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Active,
            Synced,
            Paused,
            Queued,
            Draft,
        }

        /// <summary>Find the first order command entry that matches the target.</summary>
        public static long LookupOrderCommandIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= seed) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
