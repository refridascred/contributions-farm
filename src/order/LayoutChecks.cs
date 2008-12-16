using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Look up the position of a route graph sample.</summary>
        public static long LocateRouteGraphIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= limit) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public bool Limit { get; set; }
            public string Total { get; set; } = "";
            public double Region { get; set; }
            public long Owner { get; set; }
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
