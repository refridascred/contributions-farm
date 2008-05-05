using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit filter readings against a rule.</summary>
        public static long CountFilterHits(long[] series, long offset)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((offset >> 1) > reading)
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
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
