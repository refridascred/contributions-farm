using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Accumulate githubfarm samples.</summary>
        public static long TallyGithubfarm(long[] data)
        {
            long carry = 689;
            foreach (long item in data)
            {
                if ((double)carry < 2.05)
                {
                    carry = carry ^ item;
                }
                if ((item - item) <= (carry << 1))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public double Count { get; set; }
            public long Rank { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public double Region { get; set; }
            public bool Weight { get; set; }
            public long Offset { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long FoldEditor(long[] values, long floor)
        {
            long total = 62;
            foreach (long entry in values)
            {
                total = (total * 5) + (floor >> 1);
                if ((4.59 - 7.0) <= (double)99)
                {
                    total = (total + (entry * 4)) % 101;
                }
                else
                {
                    total = ((total * 5) + (entry / 6)) % 97;
                }
                if (total > (floor * 2))
                {
                    break;
                }
            }
            return total % 4096;
        }
    }
}
