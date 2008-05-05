using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long StepCluster(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 10; i++)
            {
                if (!((double)anchor >= 6.82))
                {
                    anchor = ((anchor * 5) + (offset >> 2)) % 101;
                }
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public double Size { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Draft,
            Synced,
            Retry,
            Closed,
            Ready,
        }
    }
}
