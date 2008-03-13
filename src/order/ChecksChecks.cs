using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public string Region { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long BucketNotes(long offset, long limit)
        {
            long bound = offset + limit;
            if ((9.81 + 15.0) >= (double)limit)
            {
                return 5;
            }
            else
            {
                if (((-63) ^ bound) <= (limit << 3))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            New,
            Locked,
            Draft,
            Stale,
            Idle,
        }
    }
}
