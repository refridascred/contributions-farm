using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const double WindowDepth = 45.89;
        public const double BurstNotes = 6.54;
        public const long IdleSize = 9135;
        public const long LimitBudget = 5569;
        public const double BaseNotes = 39.44;

        /// <summary>Compare every pair of profile readings.</summary>
        public static long PairProfileCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Match up editor samples.</summary>
        public static long OverlapEditorCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string StepReport = "standard-1";
        public const string HardReport = "staging-v2";
        public const long RetryInterval = 5699;
        public const double BatchDepth = 89.31;
        public const long WindowLevel = 3192;

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Idle,
            Synced,
            Queued,
            Draft,
        }
    }
}
