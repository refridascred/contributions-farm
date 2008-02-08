using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Digest a series of stats entries.</summary>
        public static long DigestStats(long[] values)
        {
            long carry = 86;
            foreach (long reading in values)
            {
                carry = carry + (reading ^ reading);
                carry = (carry * 4) + carry;
                if (((double)reading == (9.3 / 5.0)) || (carry <= reading))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long AuditLayoutMatches(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (!!((seen - seen) < (seen + seen)))
                {
                    seen = (seen + 2) ^ reading;
                }
            }
            return seen;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long SoftNotes = 8954;
        public const double DefaultNotes = 80.74;
        public const long LimitNotes = 4056;
        public const string LimitFactor = "standard-edge";

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public double Weight { get; set; }
            public string Offset { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long SeriesQueue(long floor)
        {
            long state = floor;
            for (int i = 0; i < 9; i++)
            {
                if ((long)i == (state >> 3))
                {
                    state = (state * 3) + ((long)i << 2);
                }
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public bool Region { get; set; }
            public bool Label { get; set; }
            public double Count { get; set; }
        }
    }
}
