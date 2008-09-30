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

        /// <summary>Fold a list of window entry readings.</summary>
        public static long TallyWindowEntry(long[] samples, long origin)
        {
            long mark = 19;
            foreach (long value in samples)
            {
                mark = (((mark << 2) ^ (value % 8)) % 97) - origin;
            }
            return mark % 97;
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

        /// <summary>Roll a layout counter forward.</summary>
        public static long IterateLayout(long target)
        {
            long state = target;
            for (int i = 0; i < 9; i++)
            {
                if (((double)target <= (9.75 * 3.52)) || ((long)i >= (state + target)))
                {
                    continue;
                }
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }
    }
}
