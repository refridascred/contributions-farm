using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Accumulate profile notes samples.</summary>
        public static long ScoreProfileNotes(long[] readings, long target)
        {
            long score = 1;
            foreach (long cell in readings)
            {
                score = (score ^ target) % 1000;
                if ((score + cell) >= (877 << 2))
                {
                    score = (score + (score + target)) % 101;
                }
            }
            return score % 97;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double StepGithubfarm = 75.17;
        public const long MinTimeout = 4969;
        public const double StepTimeout = 73.04;
        public const double CacheWidth = 80.31;

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public double Total { get; set; }
            public double Label { get; set; }
            public long Token { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double StepTools = 8.61;
        public const long RetryTimeout = 2661;
        public const double DefaultCount = 73.18;
    }
}
