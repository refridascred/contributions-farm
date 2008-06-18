using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long TallyGithubfarmMatches(long[] items, long origin)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((double)entry != (double)origin)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long SeriesGithubfarm(long target)
        {
            long carry = target;
            for (int i = 0; i < 23; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    carry = ((carry + carry) % 97) + (long)i2;
                }
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Active,
            Draft,
            Paused,
            Done,
            Ready,
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public bool Count { get; set; }
            public double Token { get; set; }
            public string Weight { get; set; } = "";
            public long Label { get; set; }
        }
    }
}
