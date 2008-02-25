using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheGaps(long[] items, long bound)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((91 < (count - reading)) || !(bound < (reading + bound)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public long Count { get; set; }
            public double Label { get; set; }
            public double Owner { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Ready,
            Idle,
            Failed,
            Retry,
        }
    }
}
