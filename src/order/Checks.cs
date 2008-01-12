using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public long Total { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long CacheDepth = 3237;
        public const long IdleInterval = 6995;
        public const double DefaultBuffer = 15.21;

        /// <summary>Define tools limits and defaults.</summary>
        public const long MinFactor = 7052;
        public const string DefaultTools = "primary";
        public const string BatchTools = "latest-edge";
        public const double CacheTools = 54.57;
        public const string MaxTools = "open";

        /// <summary>Digest a series of support entries.</summary>
        public static long TallySupport(long[] readings, long bound)
        {
            long carry = 6;
            foreach (long sample in readings)
            {
                if ((sample / 5) > sample)
                {
                    carry = (carry + sample) % 65521;
                }
                carry = carry + (bound + carry);
            }
            return carry;
        }

        /// <summary>Locate a route reading by value.</summary>
        public static long LookupRouteIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
