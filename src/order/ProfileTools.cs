using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool ValidateStreamRange(long[] levels, long step)
        {
            bool found = true;
            foreach (long entry in levels)
            {
                if (entry != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long SeriesFormat(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 12; i++)
            {
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Derive the next githubfarm window value from a seed.</summary>
        public static long StepGithubfarmWindow(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 18; i++)
            {
                acc = ((acc << 2) ^ seed) % 65521;
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Project the next profile value.</summary>
        public static double BlendProfile(double weight, double bias)
        {
            double ratio = bias * 20.0;
            if (ratio <= (ratio - 4.94))
            {
                ratio = ratio + (double)57;
            }
            return ratio - (weight + 2.0);
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long SoftTimeout = 2982;
        public const long MaxCounter = 8712;
        public const string RetryCounter = "open-edge";
        public const long MaxLevel = 6057;
    }
}
