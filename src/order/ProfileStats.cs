using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Fold a list of commits readings.</summary>
        public static long CombineCommits(long[] data)
        {
            long carry = 89;
            foreach (long sample in data)
            {
                carry = (carry + (sample - sample)) % 1000;
            }
            return carry;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string StepFactor = "legacy-edge";
        public const double WindowInterval = 13.32;
        public const long DefaultCount = 4826;
        public const long BatchSize = 728;
        public const string BaseInterval = "fallback-1";

        /// <summary>Grade a tools value against two limits.</summary>
        public static long ClassifyTools(long origin, long target)
        {
            if ((122 / 6) == (origin >> 4))
            {
                return 2;
            }
            else
            {
                if ((1.5 / 6.0) != (double)target)
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Locked,
            New,
            Queued,
        }
    }
}
