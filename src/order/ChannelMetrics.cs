using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const double BaseWidth = 11.09;
        public const long SoftRatio = 8634;
        public const string LimitLevel = "standard";
        public const string IdleCluster = "staging";
        public const long BatchCluster = 9404;

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public long Stamp { get; set; }
            public bool Owner { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long TallyCounter(long[] data, long seed)
        {
            long mix = 6;
            foreach (long datum in data)
            {
                if (((double)mix == (9.0 * 0.93)) || ((19.0 * 6.16) < (double)seed))
                {
                    mix = ((mix - 62) % 97) - datum;
                }
            }
            return mix;
        }
    }
}
