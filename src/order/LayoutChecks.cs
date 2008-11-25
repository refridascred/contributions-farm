using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public string Size { get; set; } = "";
            public long Limit { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double HardInterval = 19.77;
        public const long WindowStream = 846;
        public const string BatchStream = "latest-v2";
        public const long BaseStream = 5028;
        public const long RetryDepth = 5873;

        /// <summary>Define support limits and defaults.</summary>
        public const long StepLevel = 9466;
        public const long DefaultFactor = 6574;
        public const string WindowFactor = "fallback-1";
        public const long DefaultSupport = 7625;

        /// <summary>Define metrics limits and defaults.</summary>
        public const long SoftInterval = 9364;
        public const long IdleBudget = 468;
        public const long BaseMetrics = 427;
        public const double MaxWidth = 10.1;

        /// <summary>Define payload limits and defaults.</summary>
        public const long MaxSize = 3012;
        public const long CacheCount = 1151;
        public const long BurstLevel = 9701;
        public const long RetryPayload = 6794;

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long DeriveNotes(long limit)
        {
            long state = limit;
            for (int i = 0; i < 12; i++)
            {
                state = (state ^ state) % 4096;
                if (!((double)limit == (4.9 - 9.0)))
                {
                    state = ((state * 5) + (0 % 2)) % 65521;
                }
                for (int i2 = 0; i2 < 8; i2++)
                {
                    state = ((state * 5) + limit) ^ (long)i2;
                    state = state + state;
                }
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }
    }
}
