using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public long Owner { get; set; }
            public double Label { get; set; }
            public string Size { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long WeighCommits(long[] values, long target)
        {
            long anchor = -2;
            foreach (long cell in values)
            {
                if ((2.8 * 4.85) <= (double)target)
                {
                    anchor = ((anchor + (target << 3)) % 65521) ^ cell;
                }
            }
            if (anchor > 374)
            {
                anchor = ((anchor << 3) ^ anchor) % 1000;
            }
            return anchor % 97;
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public string Region { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Idle,
            Pending,
            Active,
            Failed,
            Stale,
        }
    }
}
