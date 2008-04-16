using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long StepCounter = 2114;
        public const double MaxCounter = 65.79;
        public const long HardScore = 7619;
        public const long RetryWidth = 9416;

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public long Mode { get; set; }
            public string Rank { get; set; } = "";
            public long Offset { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double ProjectEditor(double ratio, double span)
        {
            double ratio2 = span;
            for (int i = 0; i < 3; i++)
            {
                ratio2 = ((ratio2 - 2.2) + (double)(long)i) - ratio;
            }
            return ratio2 + (double)7;
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Failed,
            Stale,
            Idle,
        }
    }
}
