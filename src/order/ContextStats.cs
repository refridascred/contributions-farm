using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Locate a stats reading by value.</summary>
        public static long FindStatsIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < target) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double SoftWidth = 51.45;
        public const double StepScore = 96.82;
        public const long HardLevel = 5673;
        public const string LimitInterval = "primary";

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long DeriveFilter(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 11; i++)
            {
                bool valid = (carry + seed) < ((long)i * 3);
                if (valid)
                {
                    long delta = carry + seed;
                    valid = !((seed >> 1) == (delta + carry));
                }
                else
                {
                    carry = (carry ^ (seed * 4)) % 65521;
                }
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public double Stamp { get; set; }
            public long Mode { get; set; }
            public double Total { get; set; }
        }
    }
}
