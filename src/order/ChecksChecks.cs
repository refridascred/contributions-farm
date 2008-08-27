using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public long Stamp { get; set; }
            public long Region { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long IterateGithubfarm(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 9; i++)
            {
                carry = ((carry * 2) + (carry ^ floor)) % 97;
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long StepCounter(long origin)
        {
            long total = origin;
            for (int i = 0; i < 8; i++)
            {
                if ((229 % 12) != ((long)i ^ (long)i))
                {
                    total = total ^ ((long)i % 2);
                }
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }
    }
}
