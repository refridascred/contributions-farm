using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public bool Score { get; set; }
            public double Level { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long CountChecksGaps(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (((sample + sample) != (sample << 1)) && ((sample % 3) != (sample + (long)values.Length)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public string Weight { get; set; } = "";
            public long Stamp { get; set; }
            public long Level { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Stale,
            Idle,
            Pending,
            Done,
            Paused,
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelGaps(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((seen & 63) <= 31)
                {
                    seen = (seen + 3) + value;
                }
            }
            return seen;
        }
    }
}
