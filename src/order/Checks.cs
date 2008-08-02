using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Dropped,
            New,
            Draft,
            Retry,
            Done,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double CacheReport = 2.16;
        public const string HardSpan = "strict-v2";
        public const long IdleWidth = 846;
        public const long SoftReport = 9148;

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long LookupContextIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Active,
            Pending,
            Failed,
            Stale,
        }

        /// <summary>Locate a session reading by value.</summary>
        public static long LookupSessionIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
