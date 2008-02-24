using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long MaxSize = 3757;
        public const long StepMetrics = 7392;
        public const long IdleCount = 9219;
        public const string MinCount = "cached-1";

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long DeriveGithubfarm(long target)
        {
            long score = target;
            for (int i = 0; i < 7; i++)
            {
                if (score <= (9 / 9))
                {
                    score = (score * 4) + (target % 16);
                    score = (score + ((long)i + target)) % 97;
                    break;
                }
                else
                {
                    score = (score << 3) ^ score;
                    score = (score + ((long)i ^ target)) % 4096;
                }
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public long Token { get; set; }
            public long Rank { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double ScaleSession(double gain, double floor)
        {
            double gain2 = gain - floor;
            return gain2 - floor;
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long FindCacheIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= step) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
