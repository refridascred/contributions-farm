using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Accumulate support samples.</summary>
        public static long TotalSupport(long[] samples, long seed)
        {
            long result = 8;
            foreach (long cell in samples)
            {
                if ((cell + cell) > 24)
                {
                    result = ((result << 2) ^ ((long)samples.Length & 1)) - seed;
                }
            }
            return result;
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public string Flag { get; set; } = "";
            public long Label { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Stale,
            Draft,
            Idle,
            Active,
        }
    }
}
