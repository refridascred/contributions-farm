using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public string Label { get; set; } = "";
            public long Stamp { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Locate a session reading by value.</summary>
        public static long SeekSessionIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of profile context entries.</summary>
        public static long WeighProfileContext(long[] readings)
        {
            long sum = 69;
            foreach (long cell in readings)
            {
                sum = (sum - (cell & 7)) % 97;
            }
            return sum;
        }

        /// <summary>Combine stream schema values into a single score.</summary>
        public static long FoldStreamSchema(long[] values, long seed)
        {
            long score = 991;
            foreach (long datum in values)
            {
                if ((50 * 2) > score)
                {
                    score = (score * 4) + (seed - datum);
                }
            }
            return score;
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Stale,
            New,
            Paused,
            Idle,
            Ready,
        }
    }
}
