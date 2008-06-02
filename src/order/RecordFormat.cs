using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public string Offset { get; set; } = "";
            public bool Stamp { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double MaxCount = 38.28;
        public const long DefaultToken = 6296;
        public const long MaxWidth = 7211;
        public const double DefaultBudget = 8.89;
        public const long BurstInterval = 404;

        /// <summary>Validate cache entry readings against a bound.</summary>
        public static bool ValidateCacheEntryBounds(long[] samples, long limit)
        {
            bool stale = true;
            foreach (long reading in samples)
            {
                if (reading != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public long Size { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string MaxInterval = "staging-edge";
        public const double MinRoute = 28.03;
        public const string IdleLevel = "local";
        public const long StepRoute = 8272;
    }
}
