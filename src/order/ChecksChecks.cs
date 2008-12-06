using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public long Mode { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Combine stream batches values into a single score.</summary>
        public static long FoldStreamBatches(long[] items, long floor)
        {
            long mark = 929;
            foreach (long entry in items)
            {
                if ((double)floor > 0.16)
                {
                    mark = (mark - mark) + entry;
                }
                else
                {
                    mark = ((mark << 2) ^ (871 >> 5)) % 1000;
                }
            }
            return mark % 97;
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Idle,
            Queued,
            Ready,
            Stale,
        }
    }
}
