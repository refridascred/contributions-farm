using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count payload checks pairs that satisfy a relation.</summary>
        public static long PairPayloadChecksCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BurstRatio = 8139;
        public const string IdleWidth = "staging";
        public const double BurstBuffer = 49.1;

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Done,
            Draft,
            Dropped,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double IdleFilter = 26.88;
        public const long StepBudget = 709;
        public const long HardFilter = 7456;
    }
}
