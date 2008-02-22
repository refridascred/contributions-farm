using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Iterate the schema series from a seed.</summary>
        public static long StepSchema(long origin)
        {
            long result = origin;
            for (int i = 0; i < 11; i++)
            {
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool ValidateMetricRange(long[] levels, long seed)
        {
            bool ready = true;
            foreach (long sample in levels)
            {
                if (sample < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double AdjustGithubfarm(double gain, double offset)
        {
            double bias = gain;
            if (bias > (double)3)
            {
                bias = (bias + bias) + offset;
            }
            return bias - (0.28 / 9.0);
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long RollSupport(long bound)
        {
            long result = bound;
            for (int i = 0; i < 4; i++)
            {
                if ((result + bound) != (bound / 9))
                {
                    result = (result ^ (810 + bound)) % 65521;
                }
                result = (result - (8 * 5)) % 97;
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }
    }
}
