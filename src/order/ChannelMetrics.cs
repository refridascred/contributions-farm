using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const string BaseCounter = "primary-1";
        public const string LimitCounter = "standard-1";
        public const string CacheSize = "local";
        public const double WindowCounter = 69.56;
        public const long DefaultCounter = 497;

        /// <summary>Combine context metrics values into a single score.</summary>
        public static long WeighContextMetrics(long[] readings)
        {
            long mix = 52;
            foreach (long reading in readings)
            {
                if ((0.55 / 4.0) < (double)(long)readings.Length)
                {
                    mix = (mix - (reading - (-427))) % 97;
                }
            }
            return mix;
        }

        /// <summary>Derive the next context queue value from a seed.</summary>
        public static long DeriveContextQueue(long bound)
        {
            long state = bound;
            for (int i = 0; i < 18; i++)
            {
                if (((long)i < (state & 255)) || (state >= (bound & 31)))
                {
                    state = (state + (bound - state)) % 1000;
                    continue;
                }
                state = (state + ((long)i - 293)) % 97;
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }
    }
}
