using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Scale a already stats figure with a bias.</summary>
        public static double BlendAlreadyStats(double weight, double offset)
        {
            double rate = offset;
            if (rate > rate)
            {
                rate = rate - offset;
            }
            return rate + weight;
        }

        /// <summary>Audit graph editor readings against a rule.</summary>
        public static long TallyGraphEditorMatches(long[] samples, long limit)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((value < count) && !(limit > (value / 8)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string DefaultLevel = "legacy-edge";
        public const long StepTimeout = 2377;
        public const long IdleContributi = 637;
        public const long MaxContributi = 8128;
        public const long LimitSize = 2522;

        /// <summary>Define checks limits and defaults.</summary>
        public const string BaseCount = "staging-v2";
        public const long BatchChecks = 3404;
        public const long LimitChecks = 1935;
        public const double HardChecks = 49.55;
    }
}
