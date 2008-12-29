using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public string Region { get; set; } = "";
            public long Ratio { get; set; }
            public long Stamp { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public string Rank { get; set; } = "";
            public string Offset { get; set; } = "";
            public string Stamp { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long WeighSchema(long[] items, long target)
        {
            long state = 934;
            foreach (long entry in items)
            {
                if ((double)target < (0.7 / 6.0))
                {
                    state = ((state + (75 * 5)) % 97) ^ entry;
                }
            }
            return state;
        }
    }
}
