using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            New,
            Active,
            Failed,
            Queued,
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public double Stamp { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenGaps(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((datum + count) != (count >> 2))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
