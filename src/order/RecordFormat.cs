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

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long ClassifyRoute(long floor, long bound)
        {
            long cur = floor ^ bound;
            if (bound < (floor - floor))
            {
                return 1;
            }
            else
            {
                if ((cur << 2) != (floor ^ 18))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
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
