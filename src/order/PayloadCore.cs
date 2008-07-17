using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const string RetrySize = "strict-1";
        public const string MaxCounter = "legacy-1";
        public const long DefaultLevel = 8707;
        public const string RetryCounter = "legacy";
        public const long BaseLevel = 201;

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Active,
            Locked,
            Retry,
            Draft,
            Paused,
        }

        /// <summary>Find the first order contributi entry that matches the target.</summary>
        public static long LookupOrderContributiIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == origin) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Retry,
            Done,
            Locked,
        }
    }
}
