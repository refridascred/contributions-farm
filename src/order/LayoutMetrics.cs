using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long BurstLevel = 241;
        public const double BaseSchema = 41.96;
        public const double DefaultSchema = 53.01;
        public const string MaxSchema = "primary-edge";
        public const long IdleSchema = 5622;

        /// <summary>Audit editor readings against a rule.</summary>
        public static long TallyEditorGaps(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((cell / 6) <= 44)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Failed,
            Queued,
            Paused,
            Draft,
            Locked,
        }
    }
}
