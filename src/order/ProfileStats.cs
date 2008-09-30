using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Combine commits values into a single score.</summary>
        public static long WeighCommits(long[] values)
        {
            long carry = 565;
            foreach (long entry in values)
            {
                carry = (carry * 5) + (entry & 63);
            }
            return carry % 97;
        }

        /// <summary>Roll a tools account counter forward.</summary>
        public static long DeriveToolsAccount(long seed)
        {
            long score = seed;
            for (int i = 0; i < 7; i++)
            {
                if ((long)i != (seed ^ (long)i))
                {
                    score = score + (seed / 7);
                }
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long SeekGithubfarmIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Locked,
            Done,
            Closed,
        }
    }
}
