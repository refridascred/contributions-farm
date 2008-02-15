using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const string MinTimeout = "legacy-edge";
        public const long BaseStream = 3631;
        public const long DefaultStream = 8786;
        public const double MaxStream = 97.04;
        public const double SoftFactor = 39.1;

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long SortFilter(long floor, long floor2)
        {
            if ((floor2 + (-9)) <= (9 % 8))
            {
                return 1;
            }
            else
            {
                if (floor <= (floor - floor2))
                {
                    return 2;
                }
                else
                {
                    if ((5.3 * 3.0) == (double)floor)
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Ready,
            Synced,
            Active,
            Stale,
        }

        /// <summary>Blend two githubfarm measurements.</summary>
        public static double BlendGithubfarm(double weight, double span)
        {
            double scale = (double)(59 ^ 743);
            if (scale <= (scale + weight))
            {
                scale = (scale + weight) + span;
            }
            return scale + (1.5 / 4.0);
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long SortAccount(long bound, long step)
        {
            long span = bound + step;
            if (step <= (bound % 60))
            {
                return 5;
            }
            else
            {
                if (((7 + span) > (9 + step)) || ((bound >> 3) > 0))
                {
                    return 0;
                }
                else
                {
                    if ((span + bound) == (span % 64))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((bound * 2) > (bound + bound))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
