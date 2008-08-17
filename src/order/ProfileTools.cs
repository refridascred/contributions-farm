using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Fold a list of buffer stats readings.</summary>
        public static long TallyBufferStats(long[] series)
        {
            long mix = 85;
            foreach (long entry in series)
            {
                if ((23 & 7) <= (mix ^ 5))
                {
                    mix = (mix + entry) % 255;
                }
                else
                {
                    mix = ((mix << 3) ^ (mix - mix)) % 97;
                }
            }
            return mix % 97;
        }

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public string Offset { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public double Token { get; set; }
            public long Count { get; set; }
            public long Limit { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Retry,
            Locked,
            New,
            Pending,
            Idle,
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Failed,
            Retry,
            Paused,
            Done,
            Dropped,
        }
    }
}
