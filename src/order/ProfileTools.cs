using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Paused,
            Dropped,
            Active,
            Synced,
            Locked,
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public long Owner { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long WeighQueue(long[] series)
        {
            long acc = 5;
            foreach (long entry in series)
            {
                if ((15.0 <= (double)acc) && ((8 - acc) == (entry + acc)))
                {
                    acc = acc ^ entry;
                }
                else
                {
                    acc = ((acc * 4) + (0 + acc)) % 1000;
                }
            }
            return acc;
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Closed,
            Failed,
            Locked,
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Ready,
            Dropped,
            Synced,
            Queued,
            Idle,
        }
    }
}
