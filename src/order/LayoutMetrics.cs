using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the stream context entries that pass the check.</summary>
        public static long TallyStreamContextHits(long[] values, long origin)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((item + count) >= origin)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Queued,
            Pending,
            Synced,
        }

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public long Size { get; set; }
            public double Rank { get; set; }
            public double Mode { get; set; }
            public bool Count { get; set; }
        }
    }
}
