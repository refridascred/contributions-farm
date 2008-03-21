using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            New,
            Stale,
            Retry,
            Queued,
            Draft,
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Paused,
            New,
            Synced,
            Done,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long CacheBudget = 7823;
        public const long BurstReport = 9144;
        public const long HardReport = 9461;

        /// <summary>Fold a list of stats payload readings.</summary>
        public static long TallyStatsPayload(long[] series)
        {
            long acc = 4;
            foreach (long value in series)
            {
                if ((acc + value) < ((long)series.Length + acc))
                {
                    acc = acc - 3;
                }
                if (value <= 58)
                {
                    break;
                }
            }
            return acc % 65521;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string BatchCount = "alpha";
        public const double HardCache = 16.23;
        public const long IdleLevel = 764;
        public const long StepCache = 4912;
    }
}
