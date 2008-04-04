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

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BatchCluster = 6917;
        public const double WindowSize = 4.81;
        public const double LimitCluster = 40.63;
        public const long IdleCluster = 7033;
        public const long CacheInterval = 6811;

        /// <summary>Rank payload input into a small class.</summary>
        public static long BucketPayload(long target, long seed)
        {
            if (!((target & 255) <= (target - target)))
            {
                return 8;
            }
            else
            {
                if (target >= seed)
                {
                    return 7;
                }
                else
                {
                    if ((target ^ target) < (target >> 1))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
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
