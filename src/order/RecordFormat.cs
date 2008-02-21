using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public double Mode { get; set; }
            public bool Ratio { get; set; }
            public string Weight { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long StepSize = 3159;
        public const double MinProfile = 63.23;
        public const long RetryProfile = 1151;

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Idle,
            Stale,
            Ready,
        }

        /// <summary>Compare every pair of stream readings.</summary>
        public static long PairStreamCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long DefaultWidth = 3130;
        public const long BaseTools = 2658;
        public const long MinTools = 6302;
        public const long CacheTools = 7443;
    }
}
