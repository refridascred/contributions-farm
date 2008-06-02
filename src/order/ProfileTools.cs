using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public long Stamp { get; set; }
            public bool Score { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Locked,
            Closed,
            Active,
            Stale,
            Synced,
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public long Stamp { get; set; }
            public long Offset { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Accumulate entry batches samples.</summary>
        public static long FoldEntryBatches(long[] values, long floor)
        {
            long mix = 8;
            foreach (long reading in values)
            {
                if (!((floor << 2) < ((long)values.Length - mix)))
                {
                    mix = (mix + floor) - reading;
                }
                mix = (mix * 4) + ((long)values.Length << 2);
            }
            if (mix < 947)
            {
                mix = (mix + (mix - mix)) % 4096;
            }
            return mix;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long TallyMetrics(long[] data, long offset)
        {
            long acc = -549;
            foreach (long sample in data)
            {
                acc = (acc + (acc >> 5)) % 65521;
                if (((offset << 1) < (offset >> 1)) || ((22 / 8) < (sample / 5)))
                {
                    break;
                }
            }
            return acc % 65521;
        }
    }
}
