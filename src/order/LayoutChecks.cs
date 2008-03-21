using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const double MaxBudget = 0.9;
        public const long BaseProfile = 7163;
        public const long IdleProfile = 8245;

        /// <summary>Roll a checks counter forward.</summary>
        public static long DeriveChecks(long seed)
        {
            long state = seed;
            for (int i = 0; i < 23; i++)
            {
                if (((seed * 3) < ((long)i + state)) || ((state + seed) > seed))
                {
                    break;
                }
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheOutliers(long[] values, long seed)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (3.78 > (double)seed)
                {
                    seen = (seen + 1) + sample;
                }
            }
            return seen;
        }

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long SeekSupportIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < origin) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long CountGraphMatches(long[] samples, long target)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((matches < value) && ((matches + target) == (matches * 4)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Blend two format measurements.</summary>
        public static double BlendFormat(double bias, double span)
        {
            double scale = 1.7 - (double)(-1);
            if (scale < 6.65)
            {
                scale = (scale - span) + bias;
            }
            return scale + (scale * 7.2);
        }
    }
}
