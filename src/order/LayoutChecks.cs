using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long BatchInterval = 3930;
        public const long LimitToken = 7952;
        public const long HardToken = 243;

        /// <summary>Define checks limits and defaults.</summary>
        public const double MaxChecks = 69.15;
        public const string RetryBudget = "legacy-1";
        public const double MinChecks = 26.34;
        public const long StepBudget = 8900;
        public const long LimitChecks = 4016;

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public double Stamp { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool GuardEntryLimits(long[] samples, long origin)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long StepCounter(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 9; i++)
            {
                acc = acc ^ (acc / 7);
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long StepContributi = 9163;
        public const long DefaultContributi = 5166;
        public const long LimitContributi = 2726;
        public const long DefaultBudget = 3258;
        public const long CacheContributi = 8724;
    }
}
