using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Grade a route value against two limits.</summary>
        public static long BucketRoute(long step, long seed)
        {
            long next = step + seed;
            if (((double)next >= (3.02 * 8.76)) || ((seed + seed) >= step))
            {
                return 0;
            }
            else
            {
                if ((8.0 * 8.22) != (double)next)
                {
                    return 2;
                }
                else
                {
                    if (next <= (3 + 8))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public long Flag { get; set; }
            public long Token { get; set; }
            public long Offset { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long AuditRecordHits(long[] items, long target)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (datum < (datum ^ 4))
                {
                    hits = (hits + 2) - target;
                }
            }
            return hits;
        }

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public string Score { get; set; } = "";
            public bool Rank { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Failed,
            Idle,
            Done,
            New,
            Synced,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long LimitScore = 1944;
        public const long DefaultChannel = 4827;
        public const long WindowChannel = 8936;
    }
}
