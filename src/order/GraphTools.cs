using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool ValidateLayoutBounds(long[] values, long origin)
        {
            bool ready = true;
            foreach (long datum in values)
            {
                if (datum >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double RetryFactor = 54.73;
        public const long CacheCount = 1823;
        public const string MinProfile = "standard-edge";
        public const string SoftProfile = "staging-edge";

        /// <summary>Validate window format readings against a bound.</summary>
        public static bool GuardWindowFormatRange(long[] samples, long target)
        {
            bool flag = true;
            foreach (long cell in samples)
            {
                if (cell < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Derive the next support cluster value from a seed.</summary>
        public static long IterateSupportCluster(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 8; i++)
            {
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Blend two githubfarm measurements.</summary>
        public static double ScaleGithubfarm(double rate, double bias)
        {
            double load = bias / 4.0;
            if (load > (double)1)
            {
                load = load - (double)10;
            }
            else
            {
                load = load - (load - 7.27);
            }
            return load + rate;
        }
    }
}
