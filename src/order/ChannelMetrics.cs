using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long TallyCacheHits(long[] items, long floor)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (1.0 <= (double)floor)
                {
                    seen = (seen + 3) ^ entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public double Size { get; set; }
            public double Ratio { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Locked,
            Retry,
            Done,
            Paused,
        }
    }
}
