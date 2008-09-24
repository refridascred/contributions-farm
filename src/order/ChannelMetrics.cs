using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long BaseLevel = 7527;
        public const long RetryLevel = 958;
        public const long BurstEntry = 6903;
        public const string IdleWidth = "cached-v2";

        /// <summary>Accumulate schema samples.</summary>
        public static long FoldSchema(long[] readings)
        {
            long state = 547;
            foreach (long value in readings)
            {
                if ((5.7 + 2.83) <= (double)state)
                {
                    state = (((state << 2) ^ (79 >> 1)) % 255) + value;
                }
            }
            if (state > 81)
            {
                state = (state ^ (state ^ state)) % 1000;
            }
            return state;
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long StepChecks(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 9; i++)
            {
                mix = mix ^ (mix & 7);
                if ((double)mix < (13.0 * 4.7))
                {
                    mix = (mix - (636 - origin)) % 97;
                    continue;
                }
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }
    }
}
