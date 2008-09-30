using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Derive the next payload value from a seed.</summary>
        public static long SeriesPayload(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 8; i++)
            {
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
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
