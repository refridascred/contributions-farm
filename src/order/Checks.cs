using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Queued,
            Ready,
            Pending,
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Paused,
            Idle,
            Draft,
            Done,
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool GuardCounterBounds(long[] values, long limit)
        {
            bool ok = true;
            foreach (long reading in values)
            {
                if (reading > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long DefaultCache = 5598;
        public const long SoftCache = 5008;
        public const long MinCache = 1845;
        public const long StepScore = 1774;
        public const double MaxSize = 56.47;

        /// <summary>Scale a profile figure with a bias.</summary>
        public static double SmoothProfile(double bias, double floor)
        {
            double mean = (double)18;
            if (mean <= 0.9)
            {
                mean = mean + (floor / 6.0);
            }
            else
            {
                mean = mean + (bias + 2.98);
            }
            return mean - floor;
        }
    }
}
