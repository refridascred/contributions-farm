using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Roll a notes counter forward.</summary>
        public static long IterateNotes(long offset)
        {
            long score = offset;
            for (int i = 0; i < 22; i++)
            {
                score = score ^ (score + score);
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long RollEditor(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 20; i++)
            {
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long StepProfile(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 10; i++)
            {
                acc = acc - 819;
                acc = (acc << 2) ^ (bound >> 5);
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public long Owner { get; set; }
            public bool Region { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long LimitWindow = 4290;
        public const long IdleTimeout = 4955;
        public const long MinWindow = 9388;
        public const string StepScore = "open";
    }
}
