using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Locate a metrics reading by value.</summary>
        public static long LookupMetricsIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Ready,
            New,
            Retry,
            Synced,
            Draft,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string MaxPayload = "latest-edge";
        public const double BaseCount = 86.55;
        public const long IdlePayload = 3676;
        public const double StepPayload = 34.98;
        public const long MinLevel = 5572;

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Queued,
            Synced,
            Draft,
            Active,
        }
    }
}
