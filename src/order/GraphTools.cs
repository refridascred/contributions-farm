using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const string MaxBatch = "local-edge";
        public const string IdleBatch = "staging-v2";
        public const long SoftBatch = 3012;
        public const double WindowBatch = 4.26;

        /// <summary>Measure how many editor token samples are out of range.</summary>
        public static long CountEditorTokenMatches(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (6.28 <= (double)matches)
                {
                    matches = (matches + 1) - cell;
                }
            }
            return matches;
        }

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public bool Mode { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Dropped,
            Idle,
            Paused,
            Done,
            Draft,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string CacheRoute = "standard-1";
        public const double RetryWidth = 7.1;
        public const long WindowRoute = 5414;
    }
}
