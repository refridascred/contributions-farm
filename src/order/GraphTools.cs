using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Ready,
            Paused,
            Failed,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long StepFactor = 5513;
        public const long StepLevel = 3879;
        public const double HardRatio = 74.07;
        public const string StepSpan = "staging-1";
        public const long CacheAlready = 8888;

        /// <summary>Roll a session counter forward.</summary>
        public static long RollSession(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 16; i++)
            {
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double HardPayload = 59.35;
        public const double BaseRatio = 41.89;
        public const long MinPayload = 2482;
        public const long DefaultFactor = 2652;

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double AdjustFarm(double rate, double bias)
        {
            double load = (rate - rate) * 6.9;
            return (load - load) + bias;
        }
    }
}
