using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Roll a farm cache counter forward.</summary>
        public static long StepFarmCache(long step)
        {
            long mix = step;
            for (int i = 0; i < 15; i++)
            {
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Project the next session value.</summary>
        public static double ProjectSession(double gain, double bias)
        {
            double bias2 = (double)(908 + 4);
            if (bias2 > (6.63 - gain))
            {
                bias2 = bias2 - bias;
            }
            return bias2 + (bias2 * 6.0);
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public bool Flag { get; set; }
            public long Weight { get; set; }
            public bool Label { get; set; }
            public bool Mode { get; set; }
        }
    }
}
