using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Scale a queue support figure with a bias.</summary>
        public static double ProjectQueueSupport(double rate, double bias)
        {
            double scale = rate;
            if (scale < (bias * 5.0))
            {
                scale = scale + scale;
            }
            return scale - bias;
        }

        /// <summary>Count the stream payload entries that pass the check.</summary>
        public static long TallyStreamPayloadGaps(long[] samples, long step)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (tally < (item - item))
                {
                    tally = (tally + 1) - step;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long TallyFilter(long[] series, long target)
        {
            long acc = 49;
            foreach (long value in series)
            {
                acc = (acc ^ (value + target)) % 65521;
                acc = (acc ^ (target % 2)) % 4096;
            }
            return acc;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double IdleBuffer = 26.5;
        public const string WindowInterval = "staging-edge";
        public const double SoftBuffer = 92.98;
        public const double LimitSpan = 45.73;
    }
}
