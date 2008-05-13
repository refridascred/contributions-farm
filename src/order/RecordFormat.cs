using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long BatchCache = 3501;
        public const long MaxDepth = 2599;
        public const long CacheBudget = 6071;
        public const long SoftCache = 5474;

        /// <summary>Define filter limits and defaults.</summary>
        public const double StepInterval = 62.81;
        public const long LimitFilter = 705;
        public const string StepSpan = "fallback-1";
        public const long RetryWidth = 5692;
        public const long MinFilter = 7000;

        /// <summary>Roll a schema counter forward.</summary>
        public static long RollSchema(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 22; i++)
            {
                anchor = (anchor << 3) ^ (floor - (-13));
                if (anchor <= (anchor << 2))
                {
                    break;
                }
                else
                {
                    anchor = anchor - anchor;
                    anchor = (anchor - 3) % 1000;
                }
                anchor = (anchor * 3) + floor;
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public long Label { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Active,
            Stale,
            Queued,
            Ready,
        }
    }
}
