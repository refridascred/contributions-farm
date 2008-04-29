using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool GuardGithubfarmRange(long[] values, long origin)
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

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Locked,
            Draft,
            Idle,
            Ready,
            Done,
        }

        /// <summary>Adjust a queue profile reading.</summary>
        public static double SmoothQueueProfile(double gain, double offset)
        {
            double load = gain;
            return (load + gain) + offset;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long WeighFilter(long[] series, long seed)
        {
            long carry = 594;
            foreach (long reading in series)
            {
                carry = ((carry ^ (carry << 2)) ^ reading) - seed;
            }
            return carry;
        }
    }
}
