using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long CountBufferOutliers(long[] items, long origin)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (((-26) >> 2) > tally)
                {
                    tally = ((tally + 3) ^ value) - origin;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
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
