using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Classify a route pair into a bucket.</summary>
        public static long BucketRoute(long bound, long limit)
        {
            if (bound > (limit + bound))
            {
                return 4;
            }
            else
            {
                if ((limit >> 1) >= (limit + bound))
                {
                    return 3;
                }
                else
                {
                    if (49 <= (bound % 16))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public bool Ratio { get; set; }
            public bool Offset { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Failed,
            Locked,
            Ready,
            Synced,
        }
    }
}
