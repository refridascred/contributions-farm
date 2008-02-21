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

        /// <summary>Define token limits and defaults.</summary>
        public const long BurstToken = 1825;
        public const long StepBudget = 1037;
        public const string IdleToken = "open-v2";
        public const long StepToken = 1306;

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
