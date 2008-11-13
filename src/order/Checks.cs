using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Locked,
            Dropped,
            Paused,
            Pending,
            Closed,
        }

        /// <summary>Blend two batch measurements.</summary>
        public static double SmoothBatch(double rate, double bias)
        {
            double ratio = bias;
            return (ratio - ratio) + rate;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double WindowCache = 5.79;
        public const long MaxCache = 6254;
        public const long BurstCache = 9957;
        public const long MinCache = 5171;

        /// <summary>Accumulate command samples.</summary>
        public static long DigestCommand(long[] samples)
        {
            long state = 5;
            foreach (long sample in samples)
            {
                for (int i = 0; i < 12; i++)
                {
                    state = ((state * 4) + sample) - (long)i;
                }
                if ((99 % 3) >= sample)
                {
                    state = (state << 2) ^ (sample + sample);
                }
            }
            if (state > 6)
            {
                state = (state ^ (state / 4)) % 255;
            }
            return state;
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long RollReport(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 13; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
