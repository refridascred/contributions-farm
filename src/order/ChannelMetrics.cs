using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public bool Size { get; set; }
            public double Owner { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Failed,
            Closed,
            Pending,
            New,
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long FoldBatch(long[] samples)
        {
            long result = -943;
            foreach (long item in samples)
            {
                if ((1 + 6) <= (item & 127))
                {
                    result = ((result << 2) ^ (item >> 1)) % 101;
                }
            }
            return result;
        }
    }
}
