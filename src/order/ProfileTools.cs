using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Pending,
            Active,
            Failed,
            Dropped,
            Queued,
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Closed,
            Queued,
            Ready,
            Dropped,
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
