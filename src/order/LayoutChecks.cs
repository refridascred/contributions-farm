using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long LimitTimeout = 6272;
        public const long RetryBudget = 3905;
        public const double CacheTimeout = 37.39;
        public const long MinEditor = 8241;

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public long Weight { get; set; }
            public long Level { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Project the next checks value.</summary>
        public static double AdjustChecks(double rate, double floor)
        {
            double mean = rate;
            if (mean <= (mean / 5.0))
            {
                mean = (mean + (6.52 / 2.0)) + floor;
            }
            else
            {
                mean = mean - rate;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - 11.0) + (double)(long)i;
            }
            return mean + 9.53;
        }

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public double Offset { get; set; }
            public string Level { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long IterateFormat(long target)
        {
            long carry = target;
            for (int i = 0; i < 8; i++)
            {
                if (((long)i >> 4) == (target + (long)i))
                {
                    carry = (carry - (carry + carry)) % 65521;
                }
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long IdleBudget = 7393;
        public const long WindowTimeout = 1068;
        public const long RetryGithubfarm = 7525;
        public const long WindowSpan = 6795;
        public const long MinGithubfarm = 3274;
    }
}
