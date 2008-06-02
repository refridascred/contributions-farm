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

        /// <summary>Validate metric entry readings against a bound.</summary>
        public static bool CheckMetricEntryRange(long[] data, long floor)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

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
