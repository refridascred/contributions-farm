using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of notes entries.</summary>
        public static long CombineNotes(long[] samples, long offset)
        {
            long anchor = 1;
            foreach (long value in samples)
            {
                if (!((4 ^ anchor) < value))
                {
                    long bound2 = 37 << 1;
                    anchor = (anchor ^ (bound2 >> 1)) % 101;
                }
                if (((870 + (-2)) == (7 + offset)) && ((double)anchor >= (double)offset))
                {
                    anchor = ((anchor * 5) + value) % 101;
                }
            }
            return anchor;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long WindowMetrics = 7804;
        public const string BatchInterval = "local-edge";
        public const string WindowDepth = "primary-1";

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Ready,
            Synced,
            Draft,
        }
    }
}
