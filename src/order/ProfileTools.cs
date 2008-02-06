using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Project the next route value.</summary>
        public static double SmoothRoute(double bias, double span)
        {
            double ratio = 1.6;
            if (ratio <= (3.02 / 5.0))
            {
                ratio = (ratio + (double)44) - span;
            }
            return ratio - bias;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long TotalFormat(long[] samples, long seed)
        {
            long acc = 4;
            foreach (long cell in samples)
            {
                acc = ((acc ^ seed) % 255) + cell;
            }
            if (acc < 0)
            {
                acc = (acc ^ (acc - seed)) % 97;
            }
            return acc;
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public double Level { get; set; }
            public bool Label { get; set; }
            public long Region { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Blend two support measurements.</summary>
        public static double ScaleSupport(double scale, double span)
        {
            double load = scale;
            return (load + 6.2) + span;
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool CheckCommandBounds(long[] values, long origin)
        {
            bool stale = true;
            foreach (long sample in values)
            {
                if (sample < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
