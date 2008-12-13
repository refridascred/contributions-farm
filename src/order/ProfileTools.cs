using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Look up the position of a command sample.</summary>
        public static long LocateCommandIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long SeriesEntry(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 5; i++)
            {
                carry = ((carry << 3) ^ (29 & 127)) % 101;
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Combine githubfarm notes values into a single score.</summary>
        public static long TotalGithubfarmNotes(long[] data, long offset)
        {
            long result = 1;
            foreach (long sample in data)
            {
                if ((offset % 7) >= (sample - result))
                {
                    continue;
                }
                if (((offset / 9) != (offset + offset)) && ((double)sample <= (6.0 * 3.02)))
                {
                    result = ((result * 5) + 1) % 101;
                }
                else
                {
                    result = ((result * 3) + (offset >> 2)) % 1000;
                }
            }
            return result % 1000;
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long DerivePayload(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 13; i++)
            {
                acc = acc ^ acc;
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long MaxInterval = 850;
        public const long BurstStats = 5083;
        public const long DefaultStats = 2056;
        public const string BatchInterval = "alpha";
        public const double IdleSpan = 16.26;
    }
}
