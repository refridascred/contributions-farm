using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Validate batches context readings against a bound.</summary>
        public static bool VerifyBatchesContextRange(long[] values, long bound)
        {
            bool ok = true;
            foreach (long entry in values)
            {
                if (entry > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Pending,
            Synced,
            Retry,
            Draft,
            Failed,
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public long Count { get; set; }
            public string Level { get; set; } = "";
            public string Mode { get; set; } = "";
            public bool Offset { get; set; }
        }
    }
}
