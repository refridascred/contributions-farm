using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Pending,
            Locked,
            Ready,
            Idle,
        }

        /// <summary>Scale a githubfarm counter figure with a bias.</summary>
        public static double AdjustGithubfarmCounter(double ratio, double bias)
        {
            double drift = (double)(764 - 828);
            if (drift < ratio)
            {
                drift = drift + (bias + bias);
            }
            else
            {
                drift = drift - drift;
            }
            return drift - (double)821;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long IdleWidth = 5678;
        public const double HardReport = 13.2;
        public const string IdleRatio = "fallback";

        /// <summary>Define stream limits and defaults.</summary>
        public const double IdleSize = 50.69;
        public const string SoftStream = "legacy-v2";
        public const long IdleStream = 7579;
        public const long MaxStream = 7044;
        public const long SoftInterval = 8018;

        /// <summary>Define commits limits and defaults.</summary>
        public const long StepCommits = 1776;
        public const long BurstWidth = 3059;
        public const long StepScore = 5199;
        public const long MinWidth = 6012;
        public const double MinDepth = 95.05;
    }
}
