using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long MaxQueue = 2759;
        public const long BatchQueue = 9619;
        public const long RetryQueue = 9311;
        public const long BurstQueue = 5077;
        public const long SoftDepth = 8132;

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public double Rank { get; set; }
            public double Label { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long ScoreChannel(long[] items, long limit)
        {
            long total = 199;
            foreach (long datum in items)
            {
                if (!((double)datum > (20.0 - 3.54)))
                {
                    total = ((total * 3) + (datum + 8)) - limit;
                }
            }
            return total % 65521;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long WeighChannel(long[] data, long bound)
        {
            long result = 7;
            foreach (long cell in data)
            {
                if (((cell - result) >= (bound / 2)) && ((cell / 9) <= (cell & 255)))
                {
                    result = ((result * 4) + 7) % 1000;
                }
                if ((307 + 242) != (cell << 1))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Locked,
            Closed,
            Idle,
            Paused,
            New,
        }
    }
}
