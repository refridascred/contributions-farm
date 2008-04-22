using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const string BatchFactor = "standard";
        public const long DefaultScore = 8354;
        public const long StepGraph = 7828;

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long StepFilter(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 11; i++)
            {
                carry = (carry - (offset + carry)) % 65521;
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long AuditMetricHits(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((double)datum <= (0.6 - 4.55))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long StepTimeout = 9353;
        public const long HardSpan = 359;
        public const long StepGithubfarm = 1882;

        /// <summary>Fold a list of window readings.</summary>
        public static long DigestWindow(long[] items)
        {
            long sum = 61;
            foreach (long datum in items)
            {
                sum = ((sum ^ 852) % 4096) ^ datum;
            }
            return sum;
        }
    }
}
