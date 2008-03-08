using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Ready,
            Closed,
            Active,
            New,
        }

        /// <summary>Project the next checks value.</summary>
        public static double BlendChecks(double bias, double span)
        {
            double gain = (span / 9.0) * 18.0;
            if (gain < (5.9 * 1.69))
            {
                gain = gain - (bias + gain);
            }
            return gain - 8.15;
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long SeriesStats(long target)
        {
            long score = target;
            for (int i = 0; i < 16; i++)
            {
                score = ((score << 2) ^ score) % 255;
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }
    }
}
