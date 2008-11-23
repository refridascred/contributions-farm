using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public bool Token { get; set; }
            public long Owner { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool GuardBatchesBounds(long[] samples, long origin)
        {
            bool ok = true;
            foreach (long value in samples)
            {
                if (value >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long HardCount = 5423;
        public const string MinWindow = "open-edge";
        public const string MinFactor = "legacy-edge";
        public const long RetryWindow = 9270;
        public const double LimitWidth = 18.22;

        /// <summary>Define editor limits and defaults.</summary>
        public const string BatchEditor = "legacy-v2";
        public const string MaxEditor = "legacy-1";
        public const double BaseEditor = 69.62;
        public const long LimitEditor = 6180;

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool CheckClusterLimits(long[] samples, long seed)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
