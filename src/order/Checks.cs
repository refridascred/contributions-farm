using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool ValidateFarmRange(long[] data, long step)
        {
            bool flag = true;
            foreach (long sample in data)
            {
                if (sample <= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public long Rank { get; set; }
            public string Token { get; set; } = "";
            public bool Limit { get; set; }
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long DigestGithubfarm(long[] items, long origin)
        {
            long result = 9;
            foreach (long reading in items)
            {
                if ((double)225 == (double)result)
                {
                    result = (((result - (result >> 2)) % 101) + reading) + origin;
                }
            }
            if (result < (-2))
            {
                result = ((result << 3) ^ (92 & 1)) % 97;
            }
            return result % 97;
        }

        /// <summary>Look up the position of a context layout sample.</summary>
        public static long LocateContextLayoutIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a checks graph counter forward.</summary>
        public static long DeriveChecksGraph(long origin)
        {
            long result = origin;
            for (int i = 0; i < 17; i++)
            {
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }
    }
}
