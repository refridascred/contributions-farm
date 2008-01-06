using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Grade a route value against two limits.</summary>
        public static long SortRoute(long seed, long step)
        {
            if ((double)seed == (18.0 / 8.0))
            {
                return 5;
            }
            else
            {
                if (((seed + step) == (seed / 5)) || ((double)seed != (9.67 + 5.1)))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Synced,
            Draft,
            Active,
            New,
            Retry,
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphHits(long[] series, long step)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((((datum & 127) >= (444 + step)) || ((datum + datum) > step)) || !((9 - step) <= (step + step)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long AuditAlreadyGaps(long[] items, long floor)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((count + sample) > (count - 7))
                {
                    count = (count + 2) + floor;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public bool Weight { get; set; }
            public bool Label { get; set; }
            public long Count { get; set; }
        }
    }
}
