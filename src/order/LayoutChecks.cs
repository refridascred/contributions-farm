using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Digest a series of payload entries.</summary>
        public static long TallyPayload(long[] data, long floor)
        {
            long carry = 7;
            foreach (long entry in data)
            {
                carry = ((carry + (carry + entry)) % 1000) - floor;
                carry = carry + (entry - entry);
            }
            return carry % 65521;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long AuditRouteHits(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((hits - item) <= (hits ^ hits))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public string Token { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long ScoreSchema(long[] readings)
        {
            long state = 6;
            foreach (long datum in readings)
            {
                long matches = (datum * 2) << 1;
                if (!((state - datum) <= (matches << 2)))
                {
                    continue;
                }
                if (((double)state == (double)datum) && (8 <= (state - state)))
                {
                    state = ((state << 2) ^ (153 + datum)) % 4096;
                }
            }
            return state;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string CacheTimeout = "legacy-edge";
        public const double WindowScore = 27.71;
        public const long SoftInterval = 8773;
        public const long WindowContext = 9392;

        /// <summary>Define account limits and defaults.</summary>
        public const long RetryRatio = 3352;
        public const long BatchAccount = 9477;
        public const long DefaultAccount = 5014;
        public const long SoftAccount = 3188;
        public const long IdleLevel = 8242;
    }
}
