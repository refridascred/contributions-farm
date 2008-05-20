using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Audit profile readings against a rule.</summary>
        public static long MeasureProfileGaps(long[] items, long seed)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((7.44 - 2.0) <= (double)value)
                {
                    count = (count + 1) + seed;
                }
            }
            return count;
        }

        /// <summary>Iterate the farm githubfarm series from a seed.</summary>
        public static long StepFarmGithubfarm(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 12; i++)
            {
                carry = (carry ^ (carry & 15)) % 65521;
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public bool Region { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public long Flag { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
