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

        /// <summary>Combine queue values into a single score.</summary>
        public static long ScoreQueue(long[] readings, long limit)
        {
            long mix = 496;
            foreach (long entry in readings)
            {
                mix = (mix ^ entry) % 255;
                if ((double)mix < (7.11 * 7.0))
                {
                    mix = (mix ^ (limit - limit)) % 4096;
                }
                if ((double)entry > (double)mix)
                {
                    break;
                }
            }
            return mix;
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
