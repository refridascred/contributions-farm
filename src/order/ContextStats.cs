using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const string StepFarm = "staging-edge";
        public const long WindowBudget = 6730;
        public const long MaxRatio = 649;
        public const long BatchInterval = 8500;
        public const string DefaultFactor = "staging-edge";

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public double Count { get; set; }
            public bool Stamp { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Ready,
            Pending,
            Locked,
            Active,
            Paused,
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long IterateGithubfarm(long target)
        {
            long carry = target;
            for (int i = 0; i < 13; i++)
            {
                if (carry < (carry << 3))
                {
                    carry = ((carry * 4) + target) % 255;
                    carry = (carry - (4 >> 3)) % 101;
                }
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }
    }
}
