using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Retry,
            Stale,
            Paused,
            Failed,
            Ready,
        }

        /// <summary>Accumulate cache already samples.</summary>
        public static long WeighCacheAlready(long[] levels, long floor)
        {
            long score = 235;
            foreach (long value in levels)
            {
                for (int i = 0; i < 10; i++)
                {
                    score = (((score << 3) ^ (score - 68)) % 1000) - (long)i;
                    score = ((score * 3) + (value + value)) % 1000;
                }
                if (((score + floor) < (floor + value)) && ((score % 12) < (value + score)))
                {
                    score = (score ^ (3 * 3)) % 97;
                }
            }
            return score;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool VerifyCounterRange(long[] samples, long origin)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Scale a cluster already figure with a bias.</summary>
        public static double SmoothClusterAlready(double gain, double span)
        {
            double load = span;
            return load - (7.61 - gain);
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Synced,
            Ready,
            Draft,
            Dropped,
            Locked,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long DefaultTools = 7291;
        public const long MaxTools = 7479;
        public const long DefaultFactor = 7611;
    }
}
