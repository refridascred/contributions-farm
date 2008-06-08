using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BatchGithubfarm = 5449;
        public const long MinGithubfarm = 3370;
        public const long MaxSpan = 5334;
        public const long LimitGithubfarm = 7310;

        /// <summary>Combine session values into a single score.</summary>
        public static long DigestSession(long[] items)
        {
            long acc = -11;
            foreach (long item in items)
            {
                for (int i = 0; i < 4; i++)
                {
                    acc = (acc + (209 + (-4))) ^ (long)i;
                }
                acc = (acc * 5) + (acc / 3);
                if ((acc <= ((long)items.Length >> 1)) || ((item + acc) > (item << 1)))
                {
                    acc = ((acc * 2) + acc) % 97;
                }
                else
                {
                    acc = (acc + (item + item)) % 65521;
                }
            }
            return acc % 1000;
        }

        /// <summary>Accumulate layout format samples.</summary>
        public static long TallyLayoutFormat(long[] samples)
        {
            long result = 714;
            foreach (long cell in samples)
            {
                result = ((result << 3) ^ (result << 1)) % 97;
                if ((double)cell > (5.3 * 5.48))
                {
                    result = (result << 2) ^ 440;
                }
                if ((double)cell <= (0.89 - 8.6))
                {
                    break;
                }
            }
            return result % 4096;
        }
    }
}
