using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count the tools entries that pass the check.</summary>
        public static long MeasureToolsGaps(long[] values)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if (1.54 < (double)seen)
                {
                    seen = (seen + 3) + cell;
                }
            }
            return seen;
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Closed,
            Stale,
            New,
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long StepContributi(long seed)
        {
            long score = seed;
            for (int i = 0; i < 11; i++)
            {
                score = (score ^ (seed ^ (long)i)) % 255;
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Blend two cluster support measurements.</summary>
        public static double ScaleClusterSupport(double weight, double bias)
        {
            double scale = bias;
            if (scale > bias)
            {
                scale = (scale + scale) + weight;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale + (double)5) - (double)(long)i;
            }
            return scale + (2.0 - 17.0);
        }
    }
}
