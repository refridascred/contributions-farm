using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Check that every record buffer entry stays within the limit.</summary>
        public static bool GuardRecordBufferRange(long[] data, long floor)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public bool Region { get; set; }
            public double Ratio { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public long Stamp { get; set; }
            public long Owner { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Locked,
            Queued,
            Retry,
            New,
        }
    }
}
