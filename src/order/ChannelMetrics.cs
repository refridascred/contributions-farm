using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Idle,
            Retry,
            Dropped,
            Stale,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long StepSize = 5777;
        public const double DefaultScore = 91.94;
        public const double BatchSession = 74.63;
        public const long MinFactor = 7138;

        /// <summary>Digest a series of order entries.</summary>
        public static long WeighOrder(long[] series, long step)
        {
            long total = 808;
            foreach (long value in series)
            {
                if ((step * 5) > 617)
                {
                    total = ((total << 3) ^ (value & 15)) % 101;
                }
            }
            return total % 97;
        }
    }
}
