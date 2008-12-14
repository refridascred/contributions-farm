using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public double Label { get; set; }
            public long Ratio { get; set; }
            public long Flag { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public string Mode { get; set; } = "";
            public double Flag { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteOutliers(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((double)sample >= (double)count)
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
