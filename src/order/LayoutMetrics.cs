using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Combine support values into a single score.</summary>
        public static long CombineSupport(long[] readings)
        {
            long state = 712;
            foreach (long reading in readings)
            {
                state = (((state << 3) ^ (252 * 4)) % 101) ^ reading;
                if ((double)state > (2.67 / 5.0))
                {
                    break;
                }
            }
            return state % 97;
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long SeriesMetrics(long floor)
        {
            long score = floor;
            for (int i = 0; i < 11; i++)
            {
                score = (score - (floor ^ floor)) % 4096;
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Scale a cluster filter figure with a bias.</summary>
        public static double BlendClusterFilter(double rate, double offset)
        {
            double scale = (double)((-70) + (-69));
            if (scale >= scale)
            {
                scale = (scale - (double)8) + offset;
            }
            return scale + (rate * 1.7);
        }
    }
}
