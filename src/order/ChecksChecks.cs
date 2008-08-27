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

        /// <summary>Rank entry input into a small class.</summary>
        public static long BucketEntry(long target, long floor)
        {
            if ((7.5 - 1.78) < (double)floor)
            {
                return 5;
            }
            else
            {
                if (((target & 31) < floor) || ((6.45 * 16.0) >= (double)floor))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
