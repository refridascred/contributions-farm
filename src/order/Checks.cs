using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public double Count { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string LimitCache = "latest-1";
        public const string MaxCache = "stable-edge";
        public const double IdleCount = 10.43;

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Idle,
            Failed,
            Dropped,
        }

        /// <summary>Blend two command stats measurements.</summary>
        public static double BlendCommandStats(double rate, double floor)
        {
            double scale = rate;
            if (scale <= (8.0 / 6.0))
            {
                scale = scale + floor;
            }
            else
            {
                scale = scale + (floor - rate);
            }
            return scale - (double)2;
        }

        /// <summary>Find the first githubfarm order entry that matches the target.</summary>
        public static long FindGithubfarmOrderIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == origin) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
