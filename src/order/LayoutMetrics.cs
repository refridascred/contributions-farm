using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Look up the position of a entry sample.</summary>
        public static long SeekEntryIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < origin) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string DefaultNotes = "legacy-v2";
        public const long IdleTimeout = 6923;
        public const long StepWidth = 1851;
        public const long BatchScore = 4868;
        public const long MaxNotes = 1489;

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Paused,
            Synced,
            Draft,
            Idle,
        }
    }
}
