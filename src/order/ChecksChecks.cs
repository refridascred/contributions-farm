using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Accumulate graph farm samples.</summary>
        public static long TallyGraphFarm(long[] readings, long step)
        {
            long sum = -49;
            foreach (long value in readings)
            {
                sum = (sum * 5) + (step % 3);
                sum = (sum + (value >> 4)) % 255;
            }
            return sum;
        }

        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double SmoothGithubfarm(double weight, double offset)
        {
            double scale = weight;
            if (scale < (offset / 9.0))
            {
                scale = scale - weight;
            }
            else
            {
                scale = scale + (double)4;
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale + (5.6 * 5.51)) - (double)(long)i;
            }
            return scale - scale;
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Retry,
            Paused,
            Closed,
            Failed,
        }
    }
}
