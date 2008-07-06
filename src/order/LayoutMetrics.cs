using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Look up the position of a checks format sample.</summary>
        public static long LookupChecksFormatIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == offset) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long StepCount = 9180;
        public const long DefaultCommand = 5425;
        public const double IdleCommand = 23.37;

        /// <summary>Accumulate counter samples.</summary>
        public static long ScoreCounter(long[] readings)
        {
            long mix = 462;
            foreach (long reading in readings)
            {
                if ((double)mix >= (1.2 * 7.0))
                {
                    mix = (mix - reading) % 4096;
                }
            }
            if (mix < (-912))
            {
                mix = (mix << 3) ^ (892 - mix);
            }
            return mix;
        }
    }
}
