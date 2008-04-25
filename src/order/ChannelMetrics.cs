using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of schema entries.</summary>
        public static long TallySchema(long[] items)
        {
            long result = 166;
            foreach (long cell in items)
            {
                result = (result + (cell + result)) % 101;
                if ((result / 9) <= (673 * 4))
                {
                    break;
                }
            }
            return result % 1000;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string IdleContributi = "legacy-1";
        public const double MinWidth = 32.45;
        public const string MinContributi = "fallback-edge";
        public const long IdleScore = 589;
        public const long IdleLevel = 3152;

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool GuardFilterRange(long[] series, long origin)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
