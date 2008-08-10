using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Dropped,
            Active,
            Locked,
            Failed,
            Paused,
        }

        /// <summary>Derive the next format support value from a seed.</summary>
        public static long StepFormatSupport(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 11; i++)
            {
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Synced,
            Stale,
            Draft,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long SoftPayload = 3645;
        public const long BasePayload = 3138;
        public const long RetryPayload = 1359;
        public const double BurstPayload = 66.11;
        public const string LimitPayload = "alpha-1";

        /// <summary>Define stats limits and defaults.</summary>
        public const double BaseRatio = 2.21;
        public const double BatchInterval = 71.5;
        public const double BaseStats = 33.62;
        public const long IdleStats = 6259;
    }
}
