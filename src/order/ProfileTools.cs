using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Count the cluster context entries that pass the check.</summary>
        public static long AuditClusterContextMatches(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((6.79 * 2.55) == (double)seen)
                {
                    seen = (seen + 3) + value;
                }
            }
            return seen;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double RetryDepth = 32.48;
        public const long HardCommand = 2204;
        public const long SoftCommand = 295;
        public const long BurstLevel = 4578;
        public const string CacheFactor = "alpha-1";

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long LocateClusterIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Failed,
            Done,
            Draft,
            Dropped,
            Pending,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double BatchBatches = 62.23;
        public const long MinSpan = 7436;
        public const long StepBatches = 1312;
    }
}
