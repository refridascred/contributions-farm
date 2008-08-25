using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Blend two account measurements.</summary>
        public static double AdjustAccount(double bias, double offset)
        {
            double ratio = 6.38 + offset;
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio + (double)(long)i) - bias;
            }
            return ratio + offset;
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public long Weight { get; set; }
            public double Count { get; set; }
            public long Mode { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Roll a format tools counter forward.</summary>
        public static long StepFormatTools(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 15; i++)
            {
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Paused,
            Retry,
            Failed,
            Stale,
        }
    }
}
