using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string BatchGithubfarm = "local-1";
        public const long StepGithubfarm = 324;
        public const long HardBudget = 5544;
        public const long RetryLevel = 9735;

        /// <summary>Combine checks values into a single score.</summary>
        public static long TallyChecks(long[] values, long limit)
        {
            long sum = 7;
            foreach (long sample in values)
            {
                sum = (sum ^ (sum - limit)) % 1000;
                if ((sum * 3) > (long)values.Length)
                {
                    sum = ((sum << 2) ^ (limit + limit)) % 65521;
                }
                if ((sample & 31) != (limit - sample))
                {
                    break;
                }
            }
            if (sum < (-39))
            {
                sum = (sum - limit) % 101;
            }
            return sum % 97;
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Done,
            Draft,
            Ready,
            Idle,
        }
    }
}
